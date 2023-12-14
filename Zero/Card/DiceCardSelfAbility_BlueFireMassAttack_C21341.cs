using System.Linq;
using TheColorsMod_C21341.Zero.Buff;
using UtilLoader21341.Util;

namespace TheColorsMod_C21341.Zero.Card
{
    public class DiceCardSelfAbility_BlueFireMassAttack_C21341 : DiceCardSelfAbilityBase
    {
        private bool _motionChanged;

        public override void OnUseCard()
        {
            var buff = owner.GetActiveBuff<BattleUnitBuf_BlueBurn_C21341>();
            if (buff == null || buff.stack <= 19) return;
            var dice = card.card.CreateDiceCardBehaviorList().FirstOrDefault();
            card.AddDice(dice);
            card.ApplyDiceStatBonus(DiceMatch.AllDice, new DiceStatBonus
            {
                power = 4
            });
            buff.OnAddBuf(-20);
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
            owner.view.charAppearance.ChangeMotion(ActionDetail.Evade);
        }

        public override void OnReleaseCard()
        {
            _motionChanged = false;
            owner.view.charAppearance.ChangeMotion(ActionDetail.Default);
        }
    }
}