using System.Collections.Generic;
using System.Reflection;
using NodeGraphProcessor.Examples;

namespace SkillGraph
{
    public struct SkillFlowLink { }

    public interface ISkillFlowLinkNode
    {
        IEnumerable<SkillConditionalNode> GetExecutedNodes();
        
        FieldInfo[] GetNodeFields(); 
    }
}