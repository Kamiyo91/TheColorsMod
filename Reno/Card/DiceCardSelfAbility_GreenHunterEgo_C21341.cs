namespace TheColorsMod_C21341.Reno.Card
{
    public class DiceCardSelfAbility_GreenHunterEgo_C21341 : DiceCardSelfAbilityBase
    {
        public override bool OnChooseCard(BattleUnitModel owner)
        {
            return owner.emotionDetail.EmotionLevel >= TheColorsModParameters.EgoEmotionLevel &&
                   !owner.bufListDetail.HasAssimilation();
        }
    }
}