using GraphProcessor;
using UnityEngine;

namespace SkillGraph
{
    [System.Serializable, NodeMenuItem("Skill/buff节点") ]
    public class SkillBuffNode : SkillLinearConditionalNode
    {
        public BuffType buffType;
        public int count;
        public BuffHandleType handleType;
        
        
        // [Setting("AffectTarget")]
        public AffectTarget affectTarget;
        
        
        public override Color color => new Color(173 / 255f, 216 / 255f, 230 / 255f);
        public override string name => "buff节点";

        protected override void Process()
        {
            Debug.Log($"{name}:  {buffType}  count: {count}   handleType: {handleType}  affectTarget: {affectTarget}");
        }
    }
}