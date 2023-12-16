using UtilLoader21341.Util;

namespace TheColorsMod_C21341.Raziel.Buff
{
    public class BattleUnitBuf_RedirectOnSelf_C21341 : BattleUnitBuf
    {
        private BattleUnitModel _target;

        public override BattleUnitModel ChangeAttackTarget(BattleDiceCardModel card, int currentSlot)
        {
            if (_target != null && !_target.IsDead() && _target.IsTargetable(_owner))
                return _target;
            return base.ChangeAttackTarget(card, currentSlot);
        }

        public override void OnRoundEndTheLast()
        {
            _owner.bufListDetail.RemoveBuf(this);
        }

        public void SetTarget(BattleUnitModel target)
        {
            _target = target;
        }

        public override void OnAddBuf(int addedStack)
        {
            this.OnAddBufCustom(addedStack, maxStack: 0);
        }
    }
}