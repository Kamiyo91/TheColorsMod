namespace TheColorsMod_C21341.CustomFloor.EmotionCard
{
    public class EmotionCardAbility_EmotionStance_C21341 : EmotionCardAbilityBase
    {
        private readonly StageController _stageController = StageController.Instance;

        public override void OnRoundStart()
        {
            if (_stageController.RoundTurn / 2 == 0)
            {
                var stack = _owner.bufListDetail.GetKewordBufAllStack(KeywordBuf.Strength);
                _owner.bufListDetail.AddKeywordBufThisRoundByEtc(KeywordBuf.Endurance, stack + 1);
                _owner.bufListDetail.RemoveBufAll(KeywordBuf.Strength);
            }
            else
            {
                var stack = _owner.bufListDetail.GetKewordBufAllStack(KeywordBuf.Endurance);
                _owner.bufListDetail.AddKeywordBufThisRoundByEtc(KeywordBuf.Strength, stack + 1);
                _owner.bufListDetail.RemoveBufAll(KeywordBuf.Endurance);
            }
        }
    }
}