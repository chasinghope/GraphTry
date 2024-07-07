using UnityEngine;
using GraphProcessor;

namespace SkillGraph
{
    
    [System.Serializable, NodeMenuItem("Skill/传递节点") ]
    public class SkillPassNode : SkillLinearConditionalNode
    {
        public override Color color => new Color(173 / 255f, 216 / 255f, 230 / 255f);
        public override string name => "传递节点";

        protected override void Process()
        {
            Debug.Log(name);
        }
    }
}