using System;
using LOR_DiceSystem;
using UtilLoader21341.Extensions;
using UtilLoader21341.Util;

namespace TheColorsMod_C21341.Mio.Buff
{
    public class BattleUnitBuf_MysticEyesOfHeaven_C21341 : BattleUnitBuf
    {
        private readonly Random _random = new Random();
        private bool _activated;
        private AtkResist _resistType = AtkResist.Normal;
        protected override string keywordId => "MysticEyes_C21341";
        protected override string keywordIconId => "MysticEyes_C21341";

        public override void BeforeRollDice(BattleDiceBehavior behavior)
        {
            if (_activated || behavior?.card?.target == null) return;
            if (!behavior.card.CheckTargetSpeedByCard(1) ||
                behavior.Detail == BehaviourDetail.Evasion || behavior.Detail == BehaviourDetail.Guard) return;
            SetDebuff(behavior.card.target, behavior.Detail, _resistType);
            if (stack <= 9 && (stack <= 4 || _random.Next(0, 100) > stack * 10)) return;
            _activated = true;
            OnAddBuf(-99);
            OnAddBuf(1);
            SetDebuff(behavior.card.target, behavior.Detail, AtkResist.Weak);
        }

        public void SetResistType(AtkResist resistType)
        {
            _resistType = resistType;
        }

        public override void BeforeGiveDamage(BattleDiceBehavior behavior)
        {
            if (behavior?.card == null || !behavior.card.CheckTargetSpeedByCard(1) || _activated) return;
            OnAddBuf(1);
        }

        public override void OnRoundEndTheLast()
        {
            _activated = false;
        }

        public void SetDebuff(BattleUnitModel target, BehaviourDetail detail, AtkResist atkType)
        {
            if (target == null) return;
            var oldBuff = target.GetActiveBuff<BattleUnitBuf_ResistChangeOneHitOnly_DLL21341>();
            if (oldBuff != null) target.bufListDetail.RemoveBuf(oldBuff);
            var buff =
                target.OnAddBuff<BattleUnitBuf_ResistChangeOneHitOnly_DLL21341>(0) as
                    BattleUnitBuf_ResistChangeOneHitOnly_DLL21341;
            buff?.SetResists(atkType, detail);
        }

        public override void OnAddBuf(int addedStack)
        {
            this.OnAddBufCustom(addedStack, maxStack: 10);
        }
    }
}