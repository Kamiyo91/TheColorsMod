using System;
using LOR_DiceSystem;
using UtilLoader21341.Util;

namespace TheColorsMod_C21341.Mio.Buff
{
    public class BattleUnitBuf_MysticEyesOfHeaven_C21341 : BattleUnitBuf
    {
        private readonly Random _random = new Random();
        private bool _activated;
        public AtkResist AtkType = AtkResist.Normal;
        protected override string keywordId => "MysticEyes_C21341";
        protected override string keywordIconId => "MysticEyes_C21341";

        public override void BeforeRollDice(BattleDiceBehavior behavior)
        {
            if (_activated) return;
            if (behavior?.card == null || !behavior.card.CheckTargetSpeedByCard(1) ||
                behavior.Detail == BehaviourDetail.Evasion || behavior.Detail == BehaviourDetail.Guard ||
                !behavior.card.card.IsNotMassAttackOrSpecialAttack(99)) return;
            if (stack > 9 || (stack > 4 && _random.Next(0, 100) <= stack * 10))
            {
                _activated = true;
                OnAddBuf(-99);
                OnAddBuf(1);
                AtkType = AtkResist.Weak;
            }

            base.BeforeRollDice(behavior);
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

        public override void OnAddBuf(int addedStack)
        {
            this.OnAddBufCustom(addedStack, maxStack: 10);
        }
    }
}