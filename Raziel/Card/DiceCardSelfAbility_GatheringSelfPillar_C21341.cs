using System.Linq;
using TheColorsMod_C21341.Raziel.Buff;
using UtilLoader21341.Util;

namespace TheColorsMod_C21341.Raziel.Card
{
    public class DiceCardSelfAbility_GatheringSelfPillar_C21341 : DiceCardSelfAbilityBase
    {
        public override void OnUseInstance(BattleUnitModel unit, BattleDiceCardModel self, BattleUnitModel targetUnit)
        {
            Activate(unit);
            self.exhaust = true;
        }

        private static void Activate(BattleUnitModel unit)
        {
            unit.OnAddBuff<BattleUnitBuf_DirectImmortal_C21341>(0);
            foreach (var buff in BattleObjectManager.instance.GetAliveList(unit.faction.ReturnOtherSideFaction())
                         .Select(enemy =>
                             enemy.OnAddBuff<BattleUnitBuf_RedirectOnSelf_C21341>(0) as
                                 BattleUnitBuf_RedirectOnSelf_C21341))
                buff?.SetTarget(unit);
            foreach (var allyUnit in BattleObjectManager.instance.GetAliveList(unit.faction)
                         .Where(x => x != unit))
                allyUnit.RemoveDiceTargets(false);
        }

        public override bool IsTargetableSelf()
        {
            return true;
        }
    }
}