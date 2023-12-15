using UtilLoader21341.Util;

namespace TheColorsMod_C21341.Reno.Buff
{
    public class BattleUnitBuf_Corrosion_C21341 : BattleUnitBuf
    {
        public override BufPositiveType positiveType => BufPositiveType.Negative;
        protected override string keywordId => "Corrosion_C21341";
        protected override string keywordIconId => "Corrosion_C21341";

        public override int GetDamageIncreaseRate()
        {
            return stack;
        }

        public override int GetBreakDamageIncreaseRate()
        {
            return stack;
        }

        public override void OnAddBuf(int addedStack)
        {
            this.OnAddBufCustom(addedStack, maxStack: 50);
        }

        public override void OnRoundEndTheLast()
        {
            OnAddBuf(-3);
        }
    }
}