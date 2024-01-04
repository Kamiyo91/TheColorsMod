using LOR_DiceSystem;
using UtilLoader21341.Util;

namespace TheColorsMod_C21341.Wonderland.Buff
{
    public class BattleUnitBuf_SmokeBomb_C21341 : BattleUnitBuf
    {
        public int HitCount;
        protected override string keywordId => "SmokeBomb_C21341";
        protected override string keywordIconId => "SmokeBomb_C21341";

        public override void OnRoundStartAfter()
        {
            this.AddBufCustom(1, maxStack: 10);
            HitCount = 0;
        }

        public override void BeforeTakeDamage(BattleUnitModel attacker, int dmg)
        {
            if (dmg == 0) return;
            HitCount++;
            if (HitCount < 3) return;
            HitCount = 0;
            this.AddBufCustom(-1);
        }

        public override void OnWinParrying(BattleDiceBehavior behavior)
        {
            if (behavior.Detail == BehaviourDetail.Evasion) this.AddBufCustom(1, maxStack: 10);
        }

        public override int GetCardCostAdder(BattleDiceCardModel card)
        {
            return stack > 9 ? -1 : base.GetCardCostAdder(card);
        }
    }
}