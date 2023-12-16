namespace TheColorsMod_C21341.Raziel.Card
{
    public class DiceCardSelfAbility_GatheringSelfInquisitor_C21341 : DiceCardSelfAbilityBase
    {
        public override void OnUseCard()
        {
            owner.bufListDetail.AddKeywordBufByCard(KeywordBuf.Protection, 1, owner);
            owner.cardSlotDetail.RecoverPlayPoint(1);
        }
    }
}