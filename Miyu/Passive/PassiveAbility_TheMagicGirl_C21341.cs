using UtilLoader21341.Util;

namespace TheColorsMod_C21341.Miyu.Passive
{
    public class PassiveAbility_TheMagicGirl_C21341 : PassiveAbilityBase
    {
        public bool NotChangeDice;

        public override void OnWaveStart()
        {
            if (UnitUtil.CheckSkinProjection(owner)) NotChangeDice = true;
        }

        public override void OnRoundStart()
        {
            EffectUtil.PrepareDeckMiyu(owner, NotChangeDice);
        }
    }
}