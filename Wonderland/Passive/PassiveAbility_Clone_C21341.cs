using TheColorsMod_C21341.Wonderland.Buff;
using UtilLoader21341.Util;

namespace TheColorsMod_C21341.Wonderland.Passive
{
    public class PassiveAbility_Clone_C21341 : PassiveAbilityBase
    {
        public override void OnRoundEndTheLast()
        {
            owner.Die();
        }

        public override void OnWaveStart()
        {
            var passive = owner.passiveDetail.AddPassive(new PassiveAbility_CloneHidedPassive_C21341());
            passive.OnWaveStart();
            owner.OnAddBuff<BattleUnitBuf_Clone_C21341>(0);
            base.OnWaveStart();
        }

        public override int SpeedDiceNumAdder()
        {
            return owner.faction == Faction.Enemy ? 1 : base.SpeedDiceNumAdder();
        }
    }
}