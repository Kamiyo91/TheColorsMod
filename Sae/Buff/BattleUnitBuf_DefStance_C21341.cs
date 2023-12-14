namespace TheColorsMod_C21341.Sae.Buff
{
    public class BattleUnitBuf_DefStance_C21341 : BattleUnitBuf
    {
        public BattleUnitBuf_DefStance_C21341()
        {
            stack = 0;
        }

        public override int paramInBufDesc => 0;
        protected override string keywordId => "DefStance_C21341";
        protected override string keywordIconId => "DefStance_C21341";

        public override bool IsImmune(BufPositiveType posType)
        {
            return posType == BufPositiveType.Negative;
        }

        public override void OnRoundEndTheLast()
        {
            if (_owner.hp >= _owner.MaxHp * 0.25f) return;
            _owner.RecoverHP(4);
            if (_owner.hp > _owner.MaxHp * 0.25f) _owner.SetHp((int)(_owner.MaxHp * 0.25f));
        }
    }
}