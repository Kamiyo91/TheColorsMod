using System.Collections.Generic;
using System.Linq;
using LOR_XML;
using TheColorsMod_C21341.Zero.Buff;
using UnityEngine;
using UtilLoader21341;
using UtilLoader21341.Util;

namespace TheColorsMod_C21341.Zero.Passive
{
    public class PassiveAbility_Zero_C21341 : PassiveAbilityBase
    {
        private const string NpcEgoUsedSave = "BlueFlameEgoUsedSaveC21341";
        private readonly LorId _egoAttackCard = new LorId(TheColorsModParameters.PackageId, 45);
        private readonly LorId _egoCard = new LorId(TheColorsModParameters.PackageId, 37);

        private readonly List<AbnormalityCardDialog> _egoDialog = new List<AbnormalityCardDialog>
        {
            new AbnormalityCardDialog
            {
                id = "BlueFlame",
                dialog = ModParameters.LocalizedItems[TheColorsModParameters.PackageId]?.EffectTexts
                    .FirstOrDefault(x => x.Key.Equals("BlueFlameEgoActive1_C21341")).Value?.Desc ?? ""
            }
        };

        private int _npcEgoSceneCount;
        public bool EgoActive;
        public bool EgoActiveQueue;

        public override void OnRoundStartAfter()
        {
            ConvertBurnForAll();
        }

        public void HandleSpecialCard()
        {
            owner.personalEgoDetail.RemoveCard(new LorId(TheColorsModParameters.PackageId, 39));
            owner.personalEgoDetail.AddCard(new LorId(TheColorsModParameters.PackageId, 39));
        }

        public override void OnStartBattle()
        {
            if (EgoActiveQueue) return;
            if (owner.faction != Faction.Enemy) return;
            _npcEgoSceneCount++;
            if (_npcEgoSceneCount > TheColorsModParameters.EgoSceneCount) EgoActiveQueue = true;
        }

        public void ConvertBurnForAll()
        {
            foreach (var unit in BattleObjectManager.instance.GetAliveList().Where(x =>
                         x != owner && !x.passiveDetail.HasPassive<PassiveAbility_BlueBurn_C21341>()))
            {
                var burnBuff = unit.bufListDetail.GetActivatedBufList().FirstOrDefault(x =>
                    x.bufType == KeywordBuf.Burn && !(x is BattleUnitBuf_BlueBurn_C21341));
                var burnNextBuff = unit.bufListDetail.GetReadyBufList().FirstOrDefault(x =>
                    x.bufType == KeywordBuf.Burn && !(x is BattleUnitBuf_BlueBurn_C21341));
                var blueBuffStacks = 0;
                if (burnBuff != null)
                {
                    blueBuffStacks += burnBuff.stack;
                    unit.bufListDetail.RemoveBuf(burnBuff);
                }

                if (burnNextBuff != null)
                {
                    blueBuffStacks += burnNextBuff.stack;
                    unit.bufListDetail.RemoveReadyBuf(burnNextBuff);
                }

                if (blueBuffStacks > 0) unit.OnAddBuff<BattleUnitBuf_BlueBurn_C21341>(blueBuffStacks);
                AddHiddenPassive(unit);
            }
        }

        public override void OnRoundStart()
        {
            HandleSpecialCard();
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
            owner.EgoActive<BattleUnitBuf_BlueFlameEgo_C21341>(ref EgoActive,
                emotionCardsId: new List<LorId> { _egoAttackCard }, dialog: _egoDialog, color: Color.blue);
        }

        public override void OnBattleEnd()
        {
            Singleton<StageController>.Instance.GetStageModel().SetStageStorgeData(NpcEgoUsedSave, true);
        }

        public override void OnWaveStart()
        {
            owner.personalEgoDetail.AddCard(_egoCard);
            AddHiddenPassive(owner);
            if (Singleton<StageController>.Instance.GetStageModel()
                .GetStageStorageData<bool>(NpcEgoUsedSave, out _))
                _npcEgoSceneCount = TheColorsModParameters.EgoSceneCount;
        }

        public void AddHiddenPassive(BattleUnitModel unit)
        {
            var passive = unit.passiveDetail.AddPassive(new LorId(TheColorsModParameters.PackageId, 41));
            passive.Hide();
            unit.passiveDetail.OnCreated();
            passive.OnRoundStartAfter();
        }

        public override bool IsImmune(KeywordBuf buf)
        {
            return buf == KeywordBuf.Burn || base.IsImmune(buf);
        }
    }
}