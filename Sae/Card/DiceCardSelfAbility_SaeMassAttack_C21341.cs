namespace TheColorsMod_C21341.Sae.Card
{
    public class DiceCardSelfAbility_SaeMassAttack_C21341 : DiceCardSelfAbilityBase
    {
        public override bool OnChooseCard(BattleUnitModel owner)
        {
            return owner.emotionDetail.EmotionLevel > 2;
        }

        public override void OnUseCard()
        {
            if (owner.hp > owner.MaxHp * 0.25f) return;
            card.ApplyDiceStatBonus(DiceMatch.AllDice, new DiceStatBonus { min = 2, max = 2 });
        }
    }
}