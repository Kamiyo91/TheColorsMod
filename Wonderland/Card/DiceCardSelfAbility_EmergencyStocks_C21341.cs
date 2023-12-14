using TheColorsMod_C21341.Wonderland.Buff;
using UtilLoader21341.Util;

namespace TheColorsMod_C21341.Wonderland.Card
{
    public class DiceCardSelfAbility_EmergencyStocks_C21341 : DiceCardSelfAbilityBase
    {
        public override void OnUseInstance(BattleUnitModel unit, BattleDiceCardModel self, BattleUnitModel targetUnit)
        {
            Activate(unit);
            self.exhaust = true;
        }

        private static void Activate(BattleUnitModel unit)
        {
            unit.OnAddBuff<BattleUnitBuf_SmokeBomb_C21341>(10);
            unit.cardSlotDetail.RecoverPlayPoint(unit.MaxPlayPoint);
            unit.allyCardDetail.DrawCards(2);
            unit.bufListDetail.AddKeywordBufThisRoundByEtc(KeywordBuf.Smoke, 10, unit);
        }

        public override bool IsTargetableSelf()
        {
            return true;
        }
    }
}