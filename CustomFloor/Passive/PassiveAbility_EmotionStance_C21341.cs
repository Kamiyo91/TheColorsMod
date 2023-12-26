namespace TheColorsMod_C21341.CustomFloor.Passive
{
    public class PassiveAbility_EmotionStance_C21341 : PassiveAbilityBase
    {
        private readonly StageController _stageController = StageController.Instance;
        private StruggleEmotionType _type;

        public override void OnRoundStartAfter()
        {
            _type = _stageController.RoundTurn % 2 == 0 ? StruggleEmotionType.Def : StruggleEmotionType.Atk;
            ConvertBuff();
            owner.bufListDetail.AddKeywordBufThisRoundByEtc(
                _type == StruggleEmotionType.Def ? KeywordBuf.Endurance : KeywordBuf.Strength, 1, owner);
        }

        public void ConvertBuff()
        {
            var keywordBuffRemove = _type == StruggleEmotionType.Def ? KeywordBuf.Strength : KeywordBuf.Endurance;
            var keywordBuffAdd = _type == StruggleEmotionType.Def ? KeywordBuf.Endurance : KeywordBuf.Strength;
            var buffStacks = owner.bufListDetail.GetKewordBufAllStack(keywordBuffRemove);
            if (buffStacks == 0) return;
            owner.bufListDetail.AddKeywordBufThisRoundByEtc(keywordBuffAdd, buffStacks, owner);
            owner.bufListDetail.GetActivatedBufList().RemoveAll(x => x.bufType == keywordBuffRemove);
        }

        public override void OnWaveStart()
        {
            Hide();
        }

        public override bool CanAddBuf(BattleUnitBuf buf)
        {
            if (_stageController.Phase != StageController.StagePhase.ApplyLibrarianCardPhase || buf == null ||
                buf.stack < 1) return true;
            switch (_type)
            {
                case StruggleEmotionType.Def when buf.bufType == KeywordBuf.Strength:
                    owner.bufListDetail.AddKeywordBufThisRoundByEtc(KeywordBuf.Endurance, buf.stack, owner);
                    return false;
                case StruggleEmotionType.Atk when buf.bufType == KeywordBuf.Endurance:
                    owner.bufListDetail.AddKeywordBufThisRoundByEtc(KeywordBuf.Strength, buf.stack, owner);
                    return false;
                default:
                    return true;
            }
        }
    }
}