namespace TheColorsMod_C21341.Sae.Buff
{
    public class BattleUnitBuf_RagingDeath_C21341 : BattleUnitBuf
    {
        public override void OnRoundStartAfter()
        {
            _owner.bufListDetail.AddKeywordBufThisRoundByEtc(KeywordBuf.Strength, 1, _owner);
            _owner.bufListDetail.AddKeywordBufThisRoundByEtc(KeywordBuf.Endurance, 1, _owner);
        }
    }
}