using LOR_DiceSystem;

namespace TheColorsMod_C21341.CustomFloor.EmotionCard
{
    public class EmotionCardAbility_EmotionRush_C21341 : EmotionCardAbilityBase
    {
        private bool _active;

        public override DiceStatBonus GetDiceStatBonus(BehaviourDetail behaviour)
        {
            return _active && behaviour == BehaviourDetail.Slash
                ? new DiceStatBonus { power = 1 }
                : base.GetDiceStatBonus(behaviour);
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