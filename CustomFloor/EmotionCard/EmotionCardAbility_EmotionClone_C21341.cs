namespace TheColorsMod_C21341.CustomFloor.EmotionCard
{
    public class EmotionCardAbility_EmotionClone_C21341 : EmotionCardAbilityBase
    {
        private readonly LorId _cloneCard = new LorId(TheColorsModParameters.PackageId, 2021);

        public override void OnSelectEmotion()
        {
            _owner.personalEgoDetail.AddCard(_cloneCard);
        }

        public override void OnWaveStart()
        {
            _owner.personalEgoDetail.AddCard(_cloneCard);
        }
    }
}