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
            owner.OnAddBuff<BattleUnitBuf_Clone_C21341>(0);
        }

        public override int SpeedDiceNumAdder()
        {
            return owner.faction == Faction.Enemy ? 1 : base.SpeedDiceNumAdder();
        }
    }
}