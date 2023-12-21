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
        private readonly LorId _egoAttackCardNpc = new LorId(TheColorsModParameters.PackageId, 905);
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
                         x != owner && x.GetActivePassive<PassiveAbility_BlueBurn_C21341>() == null))
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

                if (blueBuffStacks > 0) unit.AddBuff<BattleUnitBuf_BlueBurn_C21341>(blueBuffStacks, maxStack: 999);
                AddHiddenPassive(unit);
            }
        }

        public override void OnRoundStart()
        {
            HandleSpecialCard();
            HandleBlueBurn();
            if (!EgoActiveQueue) return;
            EgoActiveQueue = false;
            ForcedEgo();
        }

        public void HandleBlueBurn()
        {
            if (owner.GetActiveBuff<BattleUnitBuf_BlueBurn_C21341>() == null)
                owner.AddBuff<BattleUnitBuf_BlueBurn_C21341>(0);
        }

        public override void OnRoundEndTheLast()
        {
            ConvertBurnForAll();
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
                emotionCardsId: new List<LorId>
                    { owner.faction == Faction.Player ? _egoAttackCard : _egoAttackCardNpc }, dialog: _egoDialog,
                color: Color.blue);
        }

        public override void OnBattleEnd()
        {
            Singleton<StageController>.Instance.GetStageModel().SetStageStorgeData(NpcEgoUsedSave, true);
        }

        public override void OnWaveStart()
        {
            ConvertBurnForAll();
            owner.personalEgoDetail.AddCard(_egoCard);
            if (Singleton<StageController>.Instance.GetStageModel()
                .GetStageStorageData<bool>(NpcEgoUsedSave, out _))
                _npcEgoSceneCount = TheColorsModParameters.EgoSceneCount;
        }

        public void AddHiddenPassive(BattleUnitModel unit)
        {
            var passive = unit.passiveDetail.AddPassive(new LorId(TheColorsModParameters.PackageId, 22));
            passive.Hide();
            unit.passiveDetail.OnCreated();
            passive.OnRoundStartAfter();
        }

        public override bool IsImmune(KeywordBuf buf)
        {
            return buf == KeywordBuf.Burn || base.IsImmune(buf);
        }

        public override void OnDie()
        {
            foreach (var unit in BattleObjectManager.instance.GetAliveList().Where(x =>
                         x != owner && x.GetActivePassive<PassiveAbility_BlueBurn_C21341>() == null))
            {
                var passive = unit.GetActivePassive<PassiveAbility_BlueBurn_C21341>();
                passive?.OnRoundStartAfter();
                var buff = unit.GetActiveBuff<BattleUnitBuf_BlueBurn_C21341>();
                if (buff != null) unit.bufListDetail.RemoveBuf(buff);
            }
        }

        public override bool CanAddBuf(BattleUnitBuf buf)
        {
            if (buf.bufType != KeywordBuf.Burn || buf is BattleUnitBuf_BlueBurn_C21341) return true;
            owner.AddBuff<BattleUnitBuf_BlueBurn_C21341>(buf.stack, maxStack: 999);
            return false;
        }
    }
}