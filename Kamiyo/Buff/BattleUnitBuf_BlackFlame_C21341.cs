using UnityEngine;

namespace TheColorsMod_C21341.Kamiyo.Buff
{
    public class BattleUnitBuf_BlackFlame_C21341 : BattleUnitBuf
    {
        protected override string keywordId => "BlackFlameBuff_C21341";
        protected override string keywordIconId => "BlackFlameBuff_C21341";

        public override void OnRoundStartAfter()
        {
            _owner.TakeDamage(stack * _owner.MaxHp / 100);
            EffectUtil.BurnEffect(_owner);
            AddStacks(-1);
            if (stack == 0) _owner.bufListDetail.RemoveBuf(this);
        }

        public void AddStacks(int stacks)
        {
            stack += stacks;
            stack = Mathf.Clamp(stack, 0, 25);
        }
    }
}