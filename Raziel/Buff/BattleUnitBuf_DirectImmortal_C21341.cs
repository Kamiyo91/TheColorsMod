namespace TheColorsMod_C21341.Raziel.Buff
{
    public class BattleUnitBuf_DirectImmortal_C21341 : BattleUnitBuf
    {
        public BattleUnitBuf_DirectImmortal_C21341()
        {
            stack = 0;
        }

        public override int paramInBufDesc => 0;
        protected override string keywordId => "DirectImmortal_C21341";
        protected override string keywordIconId => "DirectImmortal_C21341";
        public override bool DirectAttack()
        {
            return true;
        }

        public override bool IsInvincibleHp(BattleUnitModel attacker)
        {
            return true;
        }

        public override bool IsInvincibleBp(BattleUnitModel attacker)
        {
            return true;
        }

        public override bool CanRecoverHp(int amount)
        {
            return false;
        }

        public override bool CanRecoverBreak(int amount)
        {
            return false;
        }

        public override void OnRoundEndTheLast()
        {
            _owner.bufListDetail.RemoveBuf(this);
        }
    }
}