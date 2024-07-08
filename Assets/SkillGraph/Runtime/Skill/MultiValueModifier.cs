namespace SkillGraph
{
    public class MultiValueModifier : StatModifier
    {
        public override void ChangeValue(ModifiedValue modifiedValue)
        {
            modifiedValue.ModdedValue += (Value / 100) * modifiedValue.InitialValue;
        }
    }
}