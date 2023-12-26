using LOR_DiceSystem;

namespace TheColorsMod_C21341.CustomFloor.EmotionCard
{
    public class EmotionCardAbility_EmotionHollow_C21341 : EmotionCardAbilityBase
    {
        private bool _active;
        private int _count;

        public override void OnSucceedAttack(BattleDiceBehavior behavior)
        {
            if (_count >= 3) return;
            _count++;
            behavior.card.target?.bufListDetail.AddKeywordBufByEtc(KeywordBuf.Binding, 1, _owner);
        }

        public override void BeforeRollDice(BattleDiceBehavior behavior)
        {
            if (_active && behavior.card.card.XmlData.Spec.Ranged == CardRange.Far)
                behavior.ApplyDiceStatBonus(new DiceStatBonus { power = 1 });
        }

        public override void OnLoseParrying(BattleDiceBehavior behavior)
        {
            if (behavior.Type == BehaviourType.Atk) _active = false;
        }

        public override void OnRoundStart()
        {
            _count = 0;
            _active = true;
        }
    }
}