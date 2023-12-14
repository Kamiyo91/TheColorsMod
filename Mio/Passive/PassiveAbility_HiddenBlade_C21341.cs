using UtilLoader21341.Util;

namespace TheColorsMod_C21341.Mio.Passive
{
    public class PassiveAbility_HiddenBlade_C21341 : PassiveAbilityBase
    {
        public override void OnStartBattle()
        {
            owner.ReadyCounterCard(3, TheColorsModParameters.PackageId);
        }
    }
}