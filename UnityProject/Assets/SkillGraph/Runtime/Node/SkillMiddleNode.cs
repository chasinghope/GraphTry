using GraphProcessor;
using UnityEngine;

namespace SkillGraph
{
    [System.Serializable, NodeMenuItem("Skill/中间节点") ]
    public class SkillMiddleNode : SkillLinearConditionalNode
    {
        public int num;
        
        public override Color color => new Color(173 / 255f, 216 / 255f, 230 / 255f);
        public override string name => "中间节点";

        protected override void Process()
        {
            Debug.Log(name);
        }
    }
}