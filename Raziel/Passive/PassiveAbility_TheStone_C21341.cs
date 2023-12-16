using UtilLoader21341.Util;

namespace TheColorsMod_C21341.Raziel.Passive
{
    public class PassiveAbility_TheStone_C21341 : PassiveAbilityBase
    {
        public override void OnStartBattle()
        {
            owner.ReadyCounterCard(66, TheColorsModParameters.PackageId);
        }
    }
}