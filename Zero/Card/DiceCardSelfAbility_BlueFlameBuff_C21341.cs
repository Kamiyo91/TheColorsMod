using TheColorsMod_C21341.Zero.Buff;
using UtilLoader21341.Util;

namespace TheColorsMod_C21341.Zero.Card
{
    public class DiceCardSelfAbility_BlueFlameBuff_C21341 : DiceCardSelfAbilityBase
    {
        public override bool OnChooseCard(BattleUnitModel owner)
        {
            return owner.GetActiveBuff<BattleUnitBuf_BlueBurn_C21341>()?.stack > 9 &&
                   !owner.cardSlotDetail.cardAry.Exists(x =>
                       x?.card?.GetID() == new LorId(TheColorsModParameters.PackageId, 45));
        }

        public override void OnUseInstance(BattleUnitModel unit, BattleDiceCardModel self, BattleUnitModel targetUnit)
        {
            Activate(unit);
            self.exhaust = true;
        }

        private static void Activate(BattleUnitModel unit)
        {
            //SkinUtil.BurnEffect(unit);
            unit.AddBuff<BattleUnitBuf_BlueBurn_C21341>(-10, true);
            unit.cardSlotDetail.RecoverPlayPoint(1);
            unit.allyCardDetail.DrawCards(1);
        }

        public override bool IsTargetableSelf()
        {
            return true;
        }
    }
}