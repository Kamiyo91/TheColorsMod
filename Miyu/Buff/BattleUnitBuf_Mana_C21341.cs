using UtilLoader21341.Util;

namespace TheColorsMod_C21341.Miyu.Buff
{
    public class BattleUnitBuf_Mana_C21341 : BattleUnitBuf
    {
        protected override string keywordId => "Mana_C21341";
        protected override string keywordIconId => "MagicOrbs_C21341";

        public override void OnAddBuf(int addedStack)
        {
            this.OnAddBufCustom(addedStack, maxStack: 15);
        }
    }
}