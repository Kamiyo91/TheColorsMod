namespace TheColorsMod_C21341.Kamiyo.Card
{
    public class DiceCardSelfAbility_ShadowEgoCard_C21341 : DiceCardSelfAbilityBase
    {
        public override bool OnChooseCard(BattleUnitModel owner)
        {
            return owner.emotionDetail.EmotionLevel >= TheColorsModParameters.EgoEmotionLevel &&
                   !owner.bufListDetail.HasAssimilation();
        }
    }
}