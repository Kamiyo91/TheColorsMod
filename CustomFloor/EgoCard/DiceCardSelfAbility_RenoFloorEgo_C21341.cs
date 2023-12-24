namespace TheColorsMod_C21341.CustomFloor.EgoCard
{
    public class DiceCardSelfAbility_RenoFloorEgo_C21341 : DiceCardSelfAbility_EgoOneScene_C21341
    {
        public override string SkinName => "GreenHunterEgo_C21341";

        public override void OnUseCard()
        {
            base.OnUseCard();
            if (owner.hp < owner.MaxHp * 0.50f)
                card.ApplyDiceStatBonus(DiceMatch.AllDice, new DiceStatBonus
                {
                    power = 1
                });
            if (owner.hp < owner.MaxHp * 0.25f)
                card.ApplyDiceStatBonus(DiceMatch.AllDice, new DiceStatBonus
                {
                    power = 2
                });
        }
    }
}