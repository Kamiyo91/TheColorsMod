using UtilLoader21341.Util;

namespace TheColorsMod_C21341.Kamiyo.Passive
{
    public class PassiveAbility_ForgottenSense_C21341 : PassiveAbilityBase
    {
        public override void OnStartBattle()
        {
            owner.ReadyCounterCard(20, TheColorsModParameters.PackageId);
        }
    }
}