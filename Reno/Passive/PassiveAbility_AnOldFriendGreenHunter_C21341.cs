using System.Linq;
using TheColorsMod_C21341.Reno.Buff;
using TheColorsMod_C21341.Zero.Passive;
using UtilLoader21341.Util;

namespace TheColorsMod_C21341.Reno.Passive
{
    public class PassiveAbility_AnOldFriendGreenHunter_C21341 : PassiveAbilityBase
    {
        public bool Active;
        public BattleUnitModel AllyUnit;

        public override void OnRoundStartAfter()
        {
            AllyUnit = BattleObjectManager.instance.GetAliveList(owner.faction)
                .FirstOrDefault(x => x.GetActivePassive<PassiveAbility_AnOldFriendBlueFlame_C21341>() != null);
            Active = AllyUnit != null;
            if (Active) owner.OnAddBuff<BattleUnitBuf_AnOldFriendGreen_C21341>(0);
        }

        public override void OnDieOtherUnit(BattleUnitModel unit)
        {
            if (unit.GetActivePassive<PassiveAbility_AnOldFriendBlueFlame_C21341>() == null) return;
            Active = false;
            var buff = owner.GetActiveBuff<BattleUnitBuf_AnOldFriendGreen_C21341>();
            if (buff != null) owner.bufListDetail.RemoveBuf(buff);
        }
    }
}