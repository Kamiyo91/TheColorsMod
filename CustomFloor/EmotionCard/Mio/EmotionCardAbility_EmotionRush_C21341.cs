using LOR_DiceSystem;
using UtilLoader21341.Util;

namespace TheColorsMod_C21341.CustomFloor.EmotionCard.Mio
{
    public class EmotionCardAbility_EmotionRush_C21341 : EmotionCardAbilityBase
    {
        private bool _active;

        public override void BeforeRollDice(BattleDiceBehavior behavior)
        {
            if (!_active || behavior.Detail != BehaviourDetail.Slash) return;
            behavior.ApplyDiceStatBonus(new DiceStatBonus { power = 1 });
            _owner.SetEmotionCombatLog(_emotionCard);
        }

        public override void OnLoseParrying(BattleDiceBehavior behavior)
        {
            if (behavior.Detail == BehaviourDetail.Slash) _active = false;
        }

        public override void OnRoundStart()
        {
            _active = true;
        }
    }
}