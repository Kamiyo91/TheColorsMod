using UtilLoader21341.Util;

namespace TheColorsMod_C21341.Zero.Passive
{
    public class PassiveAbility_InnerFlame_C21341 : PassiveAbilityBase
    {
        public override void OnStartBattle()
        {
            owner.ReadyCounterCard(46, TheColorsModParameters.PackageId);
        }
    }
}