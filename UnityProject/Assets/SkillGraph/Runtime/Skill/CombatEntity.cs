using UnityEngine;

namespace SkillGraph
{
    public class CombatEntity : MonoBehaviour
    {
        public StatSystem StatSystem;


        public void AddModifier(StatEnum type, float value)
        {
            AddValueModifier mod = StatSystem.gameObject.AddComponent<AddValueModifier>();
            mod.Type = type;
            mod.Value = value;
        }

        public void MultiplyModifier(StatEnum type, float value)
        {
            MultiValueModifier mod = StatSystem.gameObject.AddComponent<MultiValueModifier>();
            mod.Type = type;
            mod.Value = value;
        }
        
    }
}