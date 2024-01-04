using TheColorsMod_C21341.Wonderland.Buff;
using TheColorsMod_C21341.Wonderland.Dice;
using UtilLoader21341.Util;

namespace TheColorsMod_C21341.Wonderland.Card
{
    public class DiceCardSelfAbility_WonderlandMassAttack_C21341 : DiceCardSelfAbilityBase
    {
        private bool _motionChanged;

        public override bool OnChooseCard(BattleUnitModel owner)
        {
            return owner.GetActiveBuff<BattleUnitBuf_SmokeBomb_C21341>()?.stack > 4;
        }

        public override void OnUseCard()
        {
            var buff = owner.GetActiveBuff<BattleUnitBuf_SmokeBomb_C21341>();
            if (buff?.stack > 9)
                card.ApplyDiceAbility(DiceMatch.AllDice, new DiceCardAbility_Inflict2PurplePoison_C21341());
            else card.ApplyDiceAbility(DiceMatch.AllDice, new DiceCardAbility_Inflict1PurplePoison_C21341());
            buff?.AddBufCustom(-10);
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
            owner.view.charAppearance.ChangeMotion(ActionDetail.Hit);
        }

        public override void OnReleaseCard()
        {
            _motionChanged = false;
            owner.view.charAppearance.ChangeMotion(ActionDetail.Default);
        }
    }
}