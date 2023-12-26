namespace TheColorsMod_C21341.CustomFloor.EmotionCard.Mio
{
    public class EmotionCardAbility_EmotionTurbulence_C21341 : EmotionCardAbilityBase
    {
        private int _count;

        public override void OnSucceedAttack(BattleDiceBehavior behavior)
        {
            if (_count < 3)
            {
                _count++;
                _owner.bufListDetail.AddKeywordBufByEtc(KeywordBuf.Quickness, 1, _owner);
            }

            behavior.card?.target?.TakeDamage(2);
            behavior.card?.target?.TakeBreakDamage(2);
        }

        public override void OnRoundStart()
        {
            _count = 0;
        }
    }
}