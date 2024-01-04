using System;
using TheColorsMod_C21341.Wonderland.Buff;
using UtilLoader21341.Util;

namespace TheColorsMod_C21341.Wonderland.Passive
{
    public class PassiveAbility_PoisonedBlade_C21341 : PassiveAbilityBase
    {
        private Random _random;
        public int Multiplier;

        public override void Init(BattleUnitModel self)
        {
            base.Init(self);
            _random = new Random();
        }

        public override void OnRoundEndTheLast_ignoreDead()
        {
            Multiplier = 1;
        }

        public override void OnSucceedAttack(BattleDiceBehavior behavior)
        {
            var target = behavior.card.target;
            if (target == null) return;
            if (_random.Next(0, 100) <= 30 * Multiplier)
                target.bufListDetail.AddKeywordBufByEtc(KeywordBuf.Binding, 1, owner);
            if (_random.Next(0, 100) > 20 * Multiplier) return;
            owner.AddBuffCustom<BattleUnitBuf_PurplePoison_C21341>(1, maxStack: 99);
        }
    }
}