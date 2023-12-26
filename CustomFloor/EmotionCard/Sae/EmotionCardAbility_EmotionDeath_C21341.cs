namespace TheColorsMod_C21341.CustomFloor.EmotionCard.Sae
{
    public class EmotionCardAbility_EmotionDeath_C21341 : EmotionCardAbility_StanceType_C21341
    {
        public override void OnKill(BattleUnitModel target)
        {
            if (Type != StruggleEmotionType.Atk) return;
            _owner.cardSlotDetail.RecoverPlayPoint(_owner.MaxPlayPoint);
            _owner.bufListDetail.AddKeywordBufByEtc(KeywordBuf.Strength, 3, _owner);
        }

        public override void OnMakeBreakState(BattleUnitModel target)
        {
            if (Type != StruggleEmotionType.Def || target == null) return;
            target.TakeDamage(5);
            target.bufListDetail.AddKeywordBufByEtc(KeywordBuf.Vulnerable, 5, _owner);
            _owner.bufListDetail.AddKeywordBufByEtc(KeywordBuf.Endurance, 3, _owner);
        }
    }
}