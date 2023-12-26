namespace TheColorsMod_C21341.CustomFloor.EmotionCard.Sae
{
    public class EmotionCardAbility_EmotionStruggle_C21341 : EmotionCardAbility_StanceType_C21341
    {
        public override void OnSucceedAttack(BattleDiceBehavior behavior)
        {
            if (Type != StruggleEmotionType.Atk) return;
            if (_owner.hp <= _owner.MaxHp * 0.45f)
            {
                behavior.card.target?.TakeDamage(2);
                behavior.card.target?.TakeBreakDamage(2);
            }

            if (_owner.hp <= _owner.MaxHp * 0.20f)
            {
                behavior.card.target?.TakeDamage(2);
                behavior.card.target?.TakeBreakDamage(2);
            }

            if (_owner.hp > _owner.MaxHp * 0.10f) return;
            behavior.card.target?.TakeDamage(1);
            behavior.card.target?.TakeBreakDamage(1);
        }

        public override int GetDamageReduction(BattleDiceBehavior behavior)
        {
            if (Type != StruggleEmotionType.Def) return base.GetBreakDamageReduction(behavior);
            if (_owner.hp <= _owner.MaxHp * 0.45f) return 1;
            if (_owner.hp <= _owner.MaxHp * 0.20f) return 3;
            return _owner.hp <= _owner.MaxHp * 0.10f ? 5 : base.GetBreakDamageReduction(behavior);
        }

        public override int GetBreakDamageReduction(BattleDiceBehavior behavior)
        {
            if (Type != StruggleEmotionType.Def) return base.GetBreakDamageReduction(behavior);
            if (_owner.hp <= _owner.MaxHp * 0.45f) return 1;
            if (_owner.hp <= _owner.MaxHp * 0.20f) return 3;
            return _owner.hp <= _owner.MaxHp * 0.10f ? 5 : base.GetBreakDamageReduction(behavior);
        }
    }
}