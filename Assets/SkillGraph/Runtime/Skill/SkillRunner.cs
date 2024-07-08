using UnityEngine;

namespace SkillGraph
{
    public class SkillRunner : MonoBehaviour
    {
        public CombatEntity Source { get; set; }
        public CombatEntity Target { get; set; }


        public StatSystem Attacker => Source.StatSystem;
        public StatSystem Defender => Target.StatSystem;


        void TryToHit()
        {
            int roll = Random.Range(1, 21);
            float armorClass = Defender.GetStat(StatEnum.ArmorClass).Value;
            // int score = roll + Attacker.GetAbilityScore(Stat);
            Debug.Log($"Roll: {roll} is > armorClass: {armorClass}");
            if (roll > armorClass)
            {
                Debug.Log("Hit!");
            }
            else
            {
                Debug.Log("Miss!");
            }
        }


    }
}