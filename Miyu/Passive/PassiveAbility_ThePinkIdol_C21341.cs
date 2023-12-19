namespace TheColorsMod_C21341.Miyu.Passive
{
    public class PassiveAbility_ThePinkIdol_C21341 : PassiveAbilityBase
    {
        public override void OnWaveStart()
        {
            owner.personalEgoDetail.AddCard(new LorId(TheColorsModParameters.PackageId, 69));
            owner.personalEgoDetail.AddCard(new LorId(TheColorsModParameters.PackageId, 70));
            owner.personalEgoDetail.AddCard(new LorId(TheColorsModParameters.PackageId, 77));
        }
    }
}