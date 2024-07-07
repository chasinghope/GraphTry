using System.Collections.Generic;
using System.Linq;
using GraphProcessor;
using UnityEngine;

namespace SkillGraph
{
    [System.Serializable, NodeMenuItem("Skill/开始节点")]
    public class SkillStartNode : SkillBaseNode, ISkillFlowLinkNode
    {
        [Output("Out")]
        public SkillFlowLink output;

        public override Color color => new Color(207/255f,113/255f,175/255f);
        public override string name => "开始节点";


        protected override void Process()
        {
            Debug.Log("Skill StartNode");
        }


        public IEnumerable<SkillConditionalNode> GetExecutedNodes()
        {
            return GetOutputNodes().Where(n => n is SkillConditionalNode).Select(n => n as SkillConditionalNode);
        }
    }
}