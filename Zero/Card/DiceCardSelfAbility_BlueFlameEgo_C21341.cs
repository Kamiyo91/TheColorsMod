namespace TheColorsMod_C21341.Zero.Card
{
    public class DiceCardSelfAbility_BlueFlameEgo_C21341 : DiceCardSelfAbilityBase
    {
        public override bool OnChooseCard(BattleUnitModel owner)
        {
            return owner.emotionDetail.EmotionLevel >= TheColorsModParameters.EgoEmotionLevel &&
                   !owner.bufListDetail.HasAssimilation();
        }
    }
}