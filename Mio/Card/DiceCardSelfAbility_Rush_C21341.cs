using UtilLoader21341.Util;

namespace TheColorsMod_C21341.Mio.Card
{
    public class DiceCardSelfAbility_Rush_C21341 : DiceCardSelfAbilityBase
    {
        private const int Check = 2;

        public override void OnUseCard()
        {
            owner.allyCardDetail.DrawCards(1);
            owner.bufListDetail.AddKeywordBufByCard(KeywordBuf.Quickness, 1, owner);
            if (!card.CheckTargetSpeedByCard(Check)) return;
            owner.ChangeSameCardsCost(card, -1);
        }
    }
}