using TheColorsMod_C21341.Kamiyo.Buff;
using UtilLoader21341.Util;

namespace TheColorsMod_C21341.Kamiyo.Card
{
    public class DiceCardSelfAbility_ShadowMassAttack_C21341 : DiceCardSelfAbilityBase
    {
        private bool _motionChanged;
        public bool Active;

        public override void OnStartBattle()
        {
            var buff = owner.GetActiveBuff<BattleUnitBuf_BattleHeat_C21341>();
            if (buff == null) return;
            Active = buff.stack > 4;
        }

        public override bool OnChooseCard(BattleUnitModel owner)
        {
            return owner.GetActiveBuff<BattleUnitBuf_ShadowBuff_C21341>() != null;
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
            owner.view.charAppearance.ChangeMotion(ActionDetail.Penetrate);
        }

        public override void OnReleaseCard()
        {
            _motionChanged = false;
            owner.view.charAppearance.ChangeMotion(ActionDetail.Default);
        }
    }
}