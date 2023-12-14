using TheColorsMod_C21341.Zero.Buff;
using UtilLoader21341.Util;

namespace TheColorsMod_C21341.Zero.Card
{
    public class DiceCardSelfAbility_BlueSmithing_C21341 : DiceCardSelfAbilityBase
    {
        public override void OnUseCard()
        {
            owner.cardSlotDetail.RecoverPlayPoint(1);
            owner.allyCardDetail.DrawCards(1);
            owner.AddBuff<BattleUnitBuf_BlueBurn_C21341>(1, maxStack: 999);
        }
    }
}