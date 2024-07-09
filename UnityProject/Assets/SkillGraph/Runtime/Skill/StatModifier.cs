using UnityEngine;

namespace SkillGraph
{
    public abstract class StatModifier : MonoBehaviour
    {
        public float Value;
        public StatEnum Type;

        public abstract void ChangeValue(ModifiedValue modifiedValue);
    }
}