namespace TheColorsMod_C21341.Sae.Buff
{
    public class BattleUnitBuf_AtkStance_C21341 : BattleUnitBuf
    {
        public BattleUnitBuf_AtkStance_C21341()
        {
            stack = 0;
        }

        public override int paramInBufDesc => 0;
        protected override string keywordId => "AtkStance_C21341";
        protected override string keywordIconId => "AtkStance_C21341";

        public override void BeforeGiveDamage(BattleDiceBehavior behavior)
        {
            behavior.ApplyDiceStatBonus(new DiceStatBonus
            {
                dmgRate = 10,
                breakRate = 10
            });
            if (_owner.hp > _owner.MaxHp * 0.25f) return;
            behavior.ApplyDiceStatBonus(new DiceStatBonus
            {
                dmg = 2,
                breakDmg = 2
            });
        }
    }
}