using TheColorsMod_C21341.Wonderland.Buff;
using UtilLoader21341.Util;

namespace TheColorsMod_C21341.CustomFloor.Passive
{
    public class PassiveAbility_CloneEmotion_C21341 : PassiveAbilityBase
    {
        public override void OnRoundEndTheLast()
        {
            owner.Die();
        }

        public override void OnWaveStart()
        {
            owner.OnAddBuff<BattleUnitBuf_Clone_C21341>(0);
        }
    }
}