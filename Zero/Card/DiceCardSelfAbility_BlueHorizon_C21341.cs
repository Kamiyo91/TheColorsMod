using TheColorsMod_C21341.Zero.Buff;
using UtilLoader21341.Util;

namespace TheColorsMod_C21341.Zero.Card
{
    public class DiceCardSelfAbility_BlueHorizon_C21341 : DiceCardSelfAbilityBase
    {
        public override void OnUseCard()
        {
            owner.cardSlotDetail.RecoverPlayPoint(1);
            owner.OnAddBuff<BattleUnitBuf_BlueBurn_C21341>(3);
        }
    }
}