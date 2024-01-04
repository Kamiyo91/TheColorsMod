using UtilLoader21341.Util;

namespace TheColorsMod_C21341.Wonderland.Buff
{
    public class BattleUnitBuf_PurplePoison_C21341 : BattleUnitBuf
    {
        protected override string keywordId => "WonderlandPosion_C21341";
        protected override string keywordIconId => "WonderlandPosion_C21341";
        public override BufPositiveType positiveType => BufPositiveType.Negative;

        public override void OnRoundStartAfter()
        {
            _owner.TakeDamage(stack * _owner.MaxHp / 100);
            this.AddBufCustom(-99);
        }
    }
}