namespace TheColorsMod_C21341.Mio.Card
{
    public class DiceCardSelfAbility_GodAuraCard_C21341 : DiceCardSelfAbilityBase
    {
        public override bool OnChooseCard(BattleUnitModel owner)
        {
            return owner.emotionDetail.EmotionLevel >= TheColorsModParameters.EgoEmotionLevel &&
                   !owner.bufListDetail.HasAssimilation();
        }
    }
}