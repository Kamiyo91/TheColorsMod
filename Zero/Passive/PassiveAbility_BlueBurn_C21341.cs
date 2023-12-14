using System.Linq;
using TheColorsMod_C21341.Zero.Buff;
using UtilLoader21341.Util;

namespace TheColorsMod_C21341.Zero.Passive
{
    public class PassiveAbility_BlueBurn_C21341 : PassiveAbilityBase
    {
        private bool _check;

        public override void OnRoundStartAfter()
        {
            var unit = BattleObjectManager.instance.GetAliveList()
                .FirstOrDefault(x => x.GetActivePassive<PassiveAbility_Zero_C21341>() != null);
            if (unit == null || unit.IsDead()) _check = true;
            else _check = false;
        }

        public override bool CanAddBuf(BattleUnitBuf buf)
        {
            if (_check || buf.bufType != KeywordBuf.Burn || buf is BattleUnitBuf_BlueBurn_C21341) return true;
            owner.AddBuff<BattleUnitBuf_BlueBurn_C21341>(buf.stack);
            return false;
        }
    }
}