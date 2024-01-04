using TheColorsMod_C21341.Wonderland.Buff;
using UtilLoader21341.Util;

namespace TheColorsMod_C21341.Wonderland.Card
{
    public class DiceCardSelfAbility_SmokeScreen_C21341 : DiceCardSelfAbilityBase
    {
        public override bool OnChooseCard(BattleUnitModel owner)
        {
            return owner.GetActiveBuff<BattleUnitBuf_SmokeBomb_C21341>()?.stack > 4 &&
                   BattleObjectManager.instance.GetAliveList(owner.faction).Count > 1 &&
                   !owner.cardSlotDetail.cardAry.Exists(x =>
                       x?.card?.GetID() == new LorId(TheColorsModParameters.PackageId, 36));
        }

        public override void OnUseInstance(BattleUnitModel unit, BattleDiceCardModel self, BattleUnitModel targetUnit)
        {
            Activate(unit);
            self.exhaust = true;
        }

        private static void Activate(BattleUnitModel unit)
        {
            var buff = unit.GetActiveBuff<BattleUnitBuf_SmokeBomb_C21341>();
            if (buff != null)
            {
                unit.bufListDetail.AddKeywordBufThisRoundByEtc(KeywordBuf.Smoke, buff.stack, unit);
                buff.AddBufCustom(-10);
            }

            unit.AddBuffCustom<BattleUnitBuf_SmokeScreen_C21341>(0);
            unit.RemoveDiceTargets(false);
        }

        public override bool IsTargetableSelf()
        {
            return true;
        }
    }
}