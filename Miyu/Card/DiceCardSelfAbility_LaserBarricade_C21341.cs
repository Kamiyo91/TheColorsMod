using TheColorsMod_C21341.Miyu.Buff;
using UtilLoader21341.Util;

namespace TheColorsMod_C21341.Miyu.Card
{
    public class DiceCardSelfAbility_LaserBarricade_C21341 : DiceCardSelfAbilityBase
    {
        private bool _motionChanged;

        public override bool OnChooseCard(BattleUnitModel owner)
        {
            return owner.GetActiveBuff<BattleUnitBuf_Mana_C21341>()?.stack > 49 && !owner.cardSlotDetail.cardAry.Exists(
                x =>
                    x?.card?.GetID() == new LorId(TheColorsModParameters.PackageId, 77));
        }

        public override void OnStartBattle()
        {
            owner.OnAddBuff<BattleUnitBuf_Mana_C21341>(-50);
            if (owner.GetActiveBuff<BattleUnitBuf_Mana_C21341>()?.stack < 1)
                owner.GetActiveBuff<BattleUnitBuf_ManaShield_C21341>()?.RemoveBuff();
        }

        public override void OnUseCard()
        {
            foreach (var unit in BattleObjectManager.instance.GetAliveList(owner.faction.ReturnOtherSideFaction()))
                unit.bufListDetail.AddKeywordBufByEtc(KeywordBuf.Binding, 5);
        }

        public override void OnEndAreaAttack()
        {
            if (!_motionChanged) return;
            _motionChanged = false;
            owner.view.charAppearance.ChangeMotion(ActionDetail.Default);
        }

        public override void OnApplyCard()
        {
            if (!string.IsNullOrEmpty(owner.UnitData.unitData.workshopSkin) ||
                owner.UnitData.unitData.bookItem != owner.UnitData.unitData.CustomBookItem) return;
            _motionChanged = true;
            owner.view.charAppearance.ChangeMotion(ActionDetail.S6);
        }

        public override void OnReleaseCard()
        {
            _motionChanged = false;
            owner.view.charAppearance.ChangeMotion(ActionDetail.Default);
        }
    }
}