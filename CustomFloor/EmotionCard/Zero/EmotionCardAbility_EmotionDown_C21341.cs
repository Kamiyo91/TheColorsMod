namespace TheColorsMod_C21341.CustomFloor.EmotionCard.Zero
{
    public class EmotionCardAbility_EmotionDown_C21341 : EmotionCardAbilityBase
    {
        private bool _active;

        public override void OnRoundStart()
        {
            _active = true;
        }

        public override void OnRollDice(BattleDiceBehavior behavior)
        {
            if (!_active || behavior.TargetDice == null || !IsDefenseDice(behavior.TargetDice.Detail) ||
                IsDefenseDice(behavior.Detail)) return;
            _active = false;
            behavior.card.AddDice(behavior);
        }
    }
}