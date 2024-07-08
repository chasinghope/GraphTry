using UnityEngine;

namespace SkillGraph
{
    public class StatSystem : MonoBehaviour
    {
        public Stat[] Stats = new Stat[(int)StatEnum.MAX];
        
        public Transform modifierParent;
        
        public Stat GetStat(StatEnum type)
        {
            return Stats[(int)type];
        }
        
        public int GetAbilityScore(StatEnum type)
        {
            Stat stat = GetStat(type);
            ModifiedValue modifiedValue = new ModifiedValue(stat.Value);
            
            foreach (StatModifier mod in modifierParent.GetComponentsInChildren<StatModifier>())
            {
                mod.ChangeValue(modifiedValue);
            }
            
            Debug.Log($"Initial: {modifiedValue.InitialValue} Modded: {modifiedValue.ModdedValue}");


            float score = (stat.Value - 10) / 2f;
            return Mathf.RoundToInt(score);
        }
        
        
        [ContextMenu("SetStats")]
        void SetStats()
        {
            for (int i = 0; i < Stats.Length; i++)
            {
                Stats[i].Type = (StatEnum)i;
            }
        }
    }
}