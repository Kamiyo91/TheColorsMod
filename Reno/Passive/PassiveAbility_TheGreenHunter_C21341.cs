using System.Collections.Generic;
using System.Linq;
using LOR_XML;
using TheColorsMod_C21341.Reno.Buff;
using UnityEngine;
using UtilLoader21341;
using UtilLoader21341.Util;

namespace TheColorsMod_C21341.Reno.Passive
{
    public class PassiveAbility_TheGreenHunter_C21341 : PassiveAbilityBase
    {
        private const string NpcEgoUsedSave = "GreenHunterEgoUsedSaveC21341";
        private const string OriginalSkinName = "GreenHunter_C21341";
        private const string EgoSkinName = "GreenHunterEgo_C21341";
        private readonly LorId _egoAttackCard = new LorId(TheColorsModParameters.PackageId, 52);
        private readonly LorId _egoAttackCardNpc = new LorId(TheColorsModParameters.PackageId, 906);
        private readonly LorId _egoCard = new LorId(TheColorsModParameters.PackageId, 58);

        private readonly List<AbnormalityCardDialog> _egoDialog = new List<AbnormalityCardDialog>
        {
            new AbnormalityCardDialog
            {
                id = "GreenHunter",
                dialog = ModParameters.LocalizedItems[TheColorsModParameters.PackageId]?.EffectTexts
                    .FirstOrDefault(x => x.Key.Equals("GreenHunterEgoActive1_C21341")).Value?.Desc ?? ""
            }
        };

        private int _npcEgoSceneCount;
        public bool CustomSkin;
        public bool EgoActive;
        public bool EgoActiveQueue;

        public override void OnWaveStart()
        {
            var passive = owner.passiveDetail.AddPassive(new PassiveAbility_251201());
            passive.Hide();
            if (Singleton<StageController>.Instance.GetStageModel()
                .GetStageStorageData<bool>(NpcEgoUsedSave, out _))
                _npcEgoSceneCount = TheColorsModParameters.EgoSceneCount;
            if (UnitUtil.CheckSkinProjection(owner) ||
                !UnitUtil.CheckOriginalPage(new LorId(TheColorsModParameters.PackageId, 10000005),
                    owner.Book.GetBookClassInfoId()))
                CustomSkin = true;
            owner.personalEgoDetail.AddCard(_egoCard);
        }

        public override void OnStartBattle()
        {
            if (EgoActiveQueue) return;
            if (owner.faction != Faction.Enemy) return;
            _npcEgoSceneCount++;
            if (_npcEgoSceneCount > TheColorsModParameters.EgoSceneCount) EgoActiveQueue = true;
        }

        public override void OnRoundStart()
        {
            if (EgoActive) owner.AddBuffCustom<BattleUnitBuf_GreenLeaf_C21341>(0);
            if (!EgoActiveQueue) return;
            EgoActiveQueue = false;
            ForcedEgo();
        }

        public override void OnUseCard(BattlePlayingCardDataInUnitModel curCard)
        {
            var cardId = curCard.card.GetID();
            if (cardId.packageId == TheColorsModParameters.PackageId && cardId.id == _egoCard.id)
                EgoActiveQueue = true;
        }

        public void ForcedEgo()
        {
            owner.personalEgoDetail.RemoveCard(_egoCard);
            owner.EgoActive<BattleUnitBuf_GreenLeaf_C21341>(ref EgoActive, CustomSkin ? "" : EgoSkinName, true,
                false, new List<LorId> { owner.faction == Faction.Player ? _egoAttackCard : _egoAttackCardNpc },
                _egoDialog, Color.green);
            UpgradeDeck();
        }

        public override void OnBattleEnd()
        {
            Singleton<StageController>.Instance.GetStageModel().SetStageStorgeData(NpcEgoUsedSave, true);
            if (!CustomSkin)
                owner.UnitData.unitData.bookItem.ClassInfo.CharacterSkin = new List<string> { OriginalSkinName };
        }

        public override void OnRoundEndTheLast()
        {
            if (!EgoActiveQueue) return;
            owner.GetActivePassive<PassiveAbility_Corrosion_C21341>()?.Active();
            owner.GetActivePassive<PassiveAbility_HunterReflex_C21341>()?.Active();
        }

        public void UpgradeDeck()
        {
            foreach (var item in TheColorsModParameters.GreenHunterUpgradeDeck)
            {
                var oldCards = owner.allyCardDetail.GetAllDeck().Where(x =>
                    x.GetID().packageId == item.OldPageId.packageId && x.GetID().id == item.OldPageId.id).ToList();
                owner.allyCardDetail.ExhaustCard(item.OldPageId);
                for (var i = 0; i < oldCards.Count; i++)
                    owner.allyCardDetail.AddNewCardToDeck(item.NewPageId);
            }

            owner.DrawUntilX(4);
        }
    }
}