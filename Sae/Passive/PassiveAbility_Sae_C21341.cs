using UtilLoader21341.Util;

namespace TheColorsMod_C21341.Sae.Passive
{
    public class PassiveAbility_Sae_C21341 : PassiveAbilityBase
    {
        public override float GetStartHp(float hp)
        {
            return hp * 0.25f;
        }

        public override void OnWaveStart()
        {
            owner.personalEgoDetail.AddCard(new LorId(TheColorsModParameters.PackageId, 19));
            owner.personalEgoDetail.AddCard(new LorId(TheColorsModParameters.PackageId, 16));
            UnitUtil.CheckSkinProjection(owner);
        }
    }
}