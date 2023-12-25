namespace TheColorsMod_C21341.CustomFloor.EgoCard
{
    public class DiceCardSelfAbility_SaeFloorEgo_C21341 : DiceCardSelfAbility_EgoOneScene_C21341
    {
        public override string SkinName => "SaeRage_C21341";

        public override void OnUseCard()
        {
            base.OnUseCard();
            if (owner.hp > owner.MaxHp * 0.25f) return;
            card.ApplyDiceStatBonus(DiceMatch.AllDice, new DiceStatBonus { min = 2, max = 2 });
        }
    }
}