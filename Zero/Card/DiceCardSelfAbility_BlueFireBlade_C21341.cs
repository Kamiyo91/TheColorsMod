using TheColorsMod_C21341.Zero.Buff;
using UtilLoader21341.Util;

namespace TheColorsMod_C21341.Zero.Card
{
    public class DiceCardSelfAbility_BlueFireBlade_C21341 : DiceCardSelfAbilityBase
    {
        public override void OnUseCard()
        {
            owner.allyCardDetail.DrawCards(1);
            owner.bufListDetail.AddKeywordBufByCard(KeywordBuf.Strength, 1, null);
            owner.bufListDetail.AddKeywordBufByCard(KeywordBuf.Endurance, 1, null);
            owner.AddBuffCustom<BattleUnitBuf_BlueBurn_C21341>(10, maxStack: 999);
        }
    }
}