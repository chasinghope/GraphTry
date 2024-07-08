namespace SkillGraph
{
    public class AddValueModifier : StatModifier
    {
        public override void ChangeValue(ModifiedValue modifiedValue)
        {
            modifiedValue.ModdedValue += Value;
        }
    }
}