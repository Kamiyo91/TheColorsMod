using UtilLoader21341.Util;

namespace TheColorsMod_C21341.Sae.Passive
{
    public class PassiveAbility_Sae_C21341 : PassiveAbilityBase
    {
        private readonly LorId _specialCard = new LorId(TheColorsModParameters.PackageId, 19);

        public override float GetStartHp(float hp)
        {
            return hp * 0.25f;
        }

        public override void OnWaveStart()
        {
            owner.personalEgoDetail.AddCard(_specialCard);
            owner.personalEgoDetail.AddCard(new LorId(TheColorsModParameters.PackageId, 16));
            UnitUtil.CheckSkinProjection(owner);
        }

        public override void OnUseCard(BattlePlayingCardDataInUnitModel curCard)
        {
            var cardId = curCard.card.GetID();
            if (cardId.packageId == TheColorsModParameters.PackageId && cardId.id == _specialCard.id)
                owner.personalEgoDetail.RemoveCard(_specialCard);
        }
    }
}