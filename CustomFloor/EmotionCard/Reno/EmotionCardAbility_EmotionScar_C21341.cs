using UtilLoader21341.Util;

namespace TheColorsMod_C21341.CustomFloor.EmotionCard.Reno
{
    public class EmotionCardAbility_EmotionScar_C21341 : EmotionCardAbilityBase
    {
        private int _count;

        public override void OnTakeDamageByAttack(BattleDiceBehavior atkDice, int dmg)
        {
            if (_count < 3) _count++;
        }

        public override void OnLoseParrying(BattleDiceBehavior behavior)
        {
            if (_count < 3) _count++;
        }

        public override void BeforeRollDice(BattleDiceBehavior behavior)
        {
            if (_count <= 0) return;
            _count = 0;
            behavior.ApplyDiceStatBonus(new DiceStatBonus { power = _count });
            _owner.SetEmotionCombatLog(_emotionCard);
        }
    }
}