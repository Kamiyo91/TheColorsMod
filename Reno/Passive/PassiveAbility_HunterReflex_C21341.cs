using UtilLoader21341.Util;

namespace TheColorsMod_C21341.Reno.Passive
{
    public class PassiveAbility_HunterReflex_C21341 : PassiveAbilityBase
    {
        public bool EgoActive;

        public override void OnStartBattle()
        {
            owner.ReadyCounterCard(EgoActive ? 57 : 56, TheColorsModParameters.PackageId);
        }

        public void Active()
        {
            EgoActive = true;
        }
    }
}