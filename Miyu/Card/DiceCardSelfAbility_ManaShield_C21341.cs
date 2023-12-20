using TheColorsMod_C21341.Miyu.Buff;
using UtilLoader21341.Util;

namespace TheColorsMod_C21341.Miyu.Card
{
    public class DiceCardSelfAbility_ManaShield_C21341 : DiceCardSelfAbilityBase
    {
        public override string[] Keywords
        {
            get
            {
                return new[]
                {
                    "ManaShieldCard_C21341"
                };
            }
        }

        public override void OnUseInstance(BattleUnitModel unit, BattleDiceCardModel self, BattleUnitModel targetUnit)
        {
            Activate(unit);
        }

        private static void Activate(BattleUnitModel unit)
        {
            unit.personalEgoDetail.AddCard(new LorId(TheColorsModParameters.PackageId, 84));
            var buff = unit.GetActiveBuff<BattleUnitBuf_ManaShield_C21341>();
            if (buff != null) buff.RemoveBuff();
            else unit.OnAddBuff<BattleUnitBuf_ManaShield_C21341>(0);
        }

        public override bool IsTargetableSelf()
        {
            return true;
        }
    }
}