using System.Linq;
using TheColorsMod_C21341.Wonderland.Buff;
using UtilLoader21341;
using UtilLoader21341.Util;

namespace TheColorsMod_C21341.Wonderland.Card
{
    public class DiceCardSelfAbility_SummonClone_C21341 : DiceCardSelfAbilityBase
    {
        public override bool OnChooseCard(BattleUnitModel owner)
        {
            return owner.GetActiveBuff<BattleUnitBuf_SmokeBomb_C21341>()?.stack > 4 &&
                   !owner.cardSlotDetail.cardAry.Exists(x =>
                       x?.card?.GetID() == new LorId(TheColorsModParameters.PackageId, 36));
        }

        public override void OnUseInstance(BattleUnitModel unit, BattleDiceCardModel self, BattleUnitModel targetUnit)
        {
            Activate(unit);
            self.exhaust = true;
        }

        public static void Activate(BattleUnitModel unit)
        {
            var buff = unit.GetActiveBuff<BattleUnitBuf_SmokeBomb_C21341>();
            buff?.OnAddBuf(-5);
            SummonSpecialUnit(unit.emotionDetail.EmotionLevel, unit.faction);
            UnitUtil.RefreshCombatUI();
        }

        public override bool IsTargetableSelf()
        {
            return true;
        }

        public static BattleUnitModel SummonSpecialUnit(int emotionLevel, Faction faction)
        {
            var unit = ModParameters.UnitModels.FirstOrDefault(x =>
                x.PackageId == TheColorsModParameters.PackageId && x.Id == 10000901);
            if (unit == null) return null;
            return faction == Faction.Player
                ? UnitUtil.AddNewUnitPlayerSideCustomData(unit,
                    BattleObjectManager.instance.GetList(Faction.Player).Count, emotionLevel)
                : UnitUtil.AddNewUnitWithDefaultData(unit, BattleObjectManager.instance.GetList(Faction.Enemy).Count,
                    true, emotionLevel);
        }
    }
}