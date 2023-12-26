namespace TheColorsMod_C21341.CustomFloor.EmotionCard.Miyu
{
    public class EmotionCardAbility_LastMagicCall_C21341 : EmotionCardAbilityBase
    {
        public override void OnSelectEmotion()
        {
            _owner.personalEgoDetail.AddCard(new LorId(TheColorsModParameters.PackageId, 2022));
        }
    }
}