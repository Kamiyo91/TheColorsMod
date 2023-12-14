using System.Collections.Generic;
using System.Linq;
using LOR_XML;
using TheColorsMod_C21341.Kamiyo.Buff;
using UnityEngine;
using UtilLoader21341;
using UtilLoader21341.Util;

namespace TheColorsMod_C21341.Kamiyo.Passive
{
    public class PassiveAbility_TheBlackShadow_C21341 : PassiveAbilityBase
    {
        private const string NpcEgoUsedSave = "ShadowEgoUsedSaveC21341";
        private readonly LorId _egoAttackCard = new LorId(TheColorsModParameters.PackageId, 24);
        private readonly LorId _egoCard = new LorId(TheColorsModParameters.PackageId, 25);

        private readonly List<AbnormalityCardDialog> _egoDialog = new List<AbnormalityCardDialog>
        {
            new AbnormalityCardDialog
            {
                id = "Shadow",
                dialog = ModParameters.LocalizedItems[TheColorsModParameters.PackageId]?.EffectTexts
                    .FirstOrDefault(x => x.Key.Equals("ShadowEgoActive1_C21341")).Value?.Desc ?? ""
            }
        };

        private int _npcEgoSceneCount;

        public bool EgoActive;
        public bool EgoActiveQueue;

        public override void OnWaveStart()
        {
            owner.personalEgoDetail.AddCard(_egoCard);
            if (Singleton<StageController>.Instance.GetStageModel()
                .GetStageStorageData<bool>(NpcEgoUsedSave, out _))
                _npcEgoSceneCount = TheColorsModParameters.EgoSceneCount;
        }

        public override void OnBattleEnd()
        {
            Singleton<StageController>.Instance.GetStageModel().SetStageStorgeData(NpcEgoUsedSave, true);
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
            owner.EgoActive<BattleUnitBuf_ShadowBuff_C21341>(ref EgoActive,
                emotionCardsId: new List<LorId> { _egoAttackCard }, dialog: _egoDialog, color: Color.red);
        }

        public override void OnRoundEndTheLast()
        {
            if (!EgoActiveQueue) return;
            owner.GetActivePassive<PassiveAbility_BattleHeat_C21341>()?.Active();
        }
    }
}