using System.Collections.Generic;
using System.Linq;
using LOR_XML;
using TheColorsMod_C21341.Mio.Buff;
using UnityEngine;
using UtilLoader21341;
using UtilLoader21341.Util;

namespace TheColorsMod_C21341.Mio.Passive
{
    public class PassiveAbility_GodFragment_C21341 : PassiveAbilityBase
    {
        private const string NpcEgoUsedSave = "MioEgoUsedSaveC21341";
        private const string OriginalSkinName = "MioNormalEye_C21341";
        private const string EgoSkinName = "MioRedEye_C21341";
        private readonly LorId _egoAttackCard = new LorId(TheColorsModParameters.PackageId, 2);
        private readonly LorId _egoCard = new LorId(TheColorsModParameters.PackageId, 1);

        private readonly List<AbnormalityCardDialog> _egoDialog = new List<AbnormalityCardDialog>
        {
            new AbnormalityCardDialog
            {
                id = "Mio",
                dialog = ModParameters.LocalizedItems[TheColorsModParameters.PackageId]?.EffectTexts
                    .FirstOrDefault(x => x.Key.Equals("MioEgoActive1_C21341")).Value?.Desc ?? ""
            },
            new AbnormalityCardDialog
            {
                id = "Mio",
                dialog = ModParameters.LocalizedItems[TheColorsModParameters.PackageId]?.EffectTexts
                    .FirstOrDefault(x => x.Key.Equals("MioEgoActive2_C21341")).Value?.Desc ?? ""
            }
        };

        private int _npcEgoSceneCount;
        public bool CustomSkin;
        public bool EgoActive;
        public bool EgoActiveQueue;

        public override void OnWaveStart()
        {
            if (Singleton<StageController>.Instance.GetStageModel()
                .GetStageStorageData<bool>(NpcEgoUsedSave, out _))
                _npcEgoSceneCount = TheColorsModParameters.EgoSceneCount;
            if (UnitUtil.CheckSkinProjection(owner) ||
                !UnitUtil.CheckOriginalPage(new LorId(TheColorsModParameters.PackageId, 10000001),
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
            owner.EgoActive<BattleUnitBuf_GodAuraRelease_C21341>(ref EgoActive, CustomSkin ? "" : EgoSkinName, true,
                false, new List<LorId> { _egoAttackCard }, _egoDialog, Color.white);
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
            owner.GetActivePassive<PassiveAbility_MysticEyesOfHeaven_C21341>()?.Active();
        }
    }
}