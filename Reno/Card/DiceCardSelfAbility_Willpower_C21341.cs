namespace TheColorsMod_C21341.Reno.Card
{
    public class DiceCardSelfAbility_Willpower_C21341 : DiceCardSelfAbilityBase
    {
        public override void OnUseCard()
        {
            owner.allyCardDetail.DrawCards(1);
            owner.cardSlotDetail.RecoverPlayPoint(1);
            owner.RecoverHP(5);
            owner.breakDetail.RecoverBreak(5);
        }
    }
}