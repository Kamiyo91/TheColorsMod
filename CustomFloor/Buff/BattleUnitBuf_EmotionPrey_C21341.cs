namespace TheColorsMod_C21341.CustomFloor.Buff
{
    public class BattleUnitBuf_EmotionPrey_C21341 : BattleUnitBuf
    {
        public BattleUnitBuf_EmotionPrey_C21341()
        {
            stack = 0;
        }

        public override int paramInBufDesc => 0;
        protected override string keywordId => "EmotionPrey_C21341";
        protected override string keywordIconId => "EmotionPrey_C21341";

        public override void OnRoundEndTheLast()
        {
            _owner.bufListDetail.RemoveBuf(this);
        }
    }
}