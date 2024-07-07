using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using GraphProcessor;
using UnityEngine;

namespace SkillGraph
{
    public abstract class SkillBaseNode : BaseNode
    {
        
    }
    
    public abstract class SkillConditionalNode : BaseNode, ISkillFlowLinkNode
    {
        // These booleans will controls wether or not the execution of the folowing nodes will be done or discarded.
        [Input(name = "In", allowMultiple = true)]
        public SkillFlowLink	executed;
        
        public abstract IEnumerable< SkillConditionalNode >	GetExecutedNodes();
        
        public override FieldInfo[] GetNodeFields()
        {
            var fields = base.GetNodeFields();
            Array.Sort(fields, (f1, f2) => f1.Name == nameof(executed) ? -1 : 1);
            return fields;
        }
    }

    public abstract class SkillLinearConditionalNode : SkillConditionalNode
    {
        [Output(name = "Out")]
        public SkillFlowLink executes;
        
        public override IEnumerable<SkillConditionalNode> GetExecutedNodes()
        {
            return outputPorts.FirstOrDefault(n => n.fieldName == nameof(executes)).GetEdges()
                .Select(e => e.inputNode as SkillConditionalNode);
        }
    }
}