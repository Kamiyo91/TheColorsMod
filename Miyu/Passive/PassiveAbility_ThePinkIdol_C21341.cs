﻿using System.Linq;
using LOR_DiceSystem;
using TheColorsMod_C21341.Miyu.Buff;
using UtilLoader21341.Util;

namespace TheColorsMod_C21341.Miyu.Passive
{
    public class PassiveAbility_ThePinkIdol_C21341 : PassiveAbilityBase
    {
        private readonly LorId _manaShieldCard = new LorId(TheColorsModParameters.PackageId, 84);

        //private readonly LorId _sacraficeCard = new LorId(TheColorsModParameters.PackageId, 70);
        private readonly LorId _specialCard = new LorId(TheColorsModParameters.PackageId, 77);

        public override void OnWaveStart()
        {
            if (owner.faction == Faction.Enemy)
                owner.allyCardDetail.AddNewCardToDeck(new LorId(TheColorsModParameters.PackageId, 908));
            owner.personalEgoDetail.AddCard(new LorId(TheColorsModParameters.PackageId, 69));
            //owner.personalEgoDetail.AddCard(_sacraficeCard);
            owner.personalEgoDetail.AddCard(_specialCard);
            owner.AddBuffCustom<BattleUnitBuf_Mana_C21341>(10, maxStack: 100);
        }

        public override void OnUseCard(BattlePlayingCardDataInUnitModel curCard)
        {
            if (curCard.GetDiceBehaviorList().Any(x => x.Type != BehaviourType.Standby))
                owner.AddBuffCustom<BattleUnitBuf_Mana_C21341>(10, maxStack: 100);
            //var cardId = curCard.card.GetID();
            //if (cardId.packageId == TheColorsModParameters.PackageId && cardId.id == _sacraficeCard.id)
            //    owner.personalEgoDetail.RemoveCard(_sacraficeCard);
        }

        public override void OnRoundStart()
        {
            HandleCards();
            owner.AddBuffCustom<BattleUnitBuf_Mana_C21341>(0, maxStack: 100);
        }

        public void HandleCards()
        {
            owner.personalEgoDetail.RemoveCard(new LorId(TheColorsModParameters.PackageId, 82));
            owner.personalEgoDetail.RemoveCard(new LorId(TheColorsModParameters.PackageId, 83));
            owner.personalEgoDetail.RemoveCard(_manaShieldCard);
            owner.personalEgoDetail.AddCard(new LorId(TheColorsModParameters.PackageId, 82));
            owner.personalEgoDetail.AddCard(new LorId(TheColorsModParameters.PackageId, 83));
            owner.personalEgoDetail.AddCard(_manaShieldCard);
        }
    }
}