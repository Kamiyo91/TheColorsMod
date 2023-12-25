using UtilLoader21341.Util;

namespace TheColorsMod_C21341.CustomFloor.Buff
{
    public class BattleUnitBuf_EmotionPreyOwner_C21341 : BattleUnitBuf
    {
        protected override string keywordId => "EmotionPreyOwner_C21341";

        public override void OnAddBuf(int addedStack)
        {
            this.OnAddBufCustom(0, maxStack: 0);
        }
    }
}