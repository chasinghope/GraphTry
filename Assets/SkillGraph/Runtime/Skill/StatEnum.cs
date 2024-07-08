namespace SkillGraph
{
    [System.Serializable]
    public class Stat
    {
        public float Value;
        public StatEnum Type;
    }
    
    public enum StatEnum
    {
        MaxHp = 0,
        Hp,
        MaxMp,
        Mp,
        Strength,
        Deterity,
        Constitution,
        Agility,
        Intelligence,
        Wisdom,
        ArmorClass,
        
        MAX,
    }
}