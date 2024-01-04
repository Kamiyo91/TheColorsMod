using UtilLoader21341.Util;

namespace TheColorsMod_C21341.Kamiyo.Buff
{
    public class BattleUnitBuf_BattleHeat_C21341 : BattleUnitBuf
    {
        protected override string keywordId => "BattleHeat_C21341";
        protected override string keywordIconId => "BattleHeat_C21341";

        public override void OnEndParrying()
        {
            this.AddBufCustom(1);
        }

        public override void BeforeRollDice(BattleDiceBehavior behavior)
        {
            if (stack < 5 || !behavior.card.card.IsNotMassAttackOrSpecialAttack(99)) return;
            this.AddBufCustom(-99);
            behavior.ApplyDiceStatBonus(new DiceStatBonus { min = behavior.GetDiceMax() - behavior.GetDiceMin() });
        }
    }
}