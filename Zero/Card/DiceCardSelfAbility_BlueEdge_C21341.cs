using TheColorsMod_C21341.Zero.Buff;
using UtilLoader21341.Util;

namespace TheColorsMod_C21341.Zero.Card
{
    public class DiceCardSelfAbility_BlueEdge_C21341 : DiceCardSelfAbilityBase
    {
        public override void OnUseCard()
        {
            owner.allyCardDetail.DrawCards(1);
            owner.OnAddBuff<BattleUnitBuf_BlueBurn_C21341>(3);
        }
    }
}