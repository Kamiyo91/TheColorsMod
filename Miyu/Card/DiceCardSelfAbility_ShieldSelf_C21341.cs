using System;
using TheColorsMod_C21341.Miyu.Buff;
using UtilLoader21341.Util;

namespace TheColorsMod_C21341.Miyu.Card
{
    public class DiceCardSelfAbility_ShieldSelf_C21341 : DiceCardSelfAbility_MiyuCommonCard_C21341
    {
        private readonly Random _random = new Random();

        public override string[] Keywords
        {
            get
            {
                return new[]
                {
                    "Healer_C21341",
                    "MagicShield_C21341"
                };
            }
        }

        public override bool IsValidTarget(BattleUnitModel unit, BattleDiceCardModel self, BattleUnitModel targetUnit)
        {
            return true;
        }

        public override bool IsTargetableSelf()
        {
            return true;
        }

        public override bool IsOnlyAllyUnit()
        {
            return false;
        }

        public override void OnUseCard()
        {
            var randomNumber = _random.Next(1, 10);
            owner.RecoverHP(randomNumber);
            owner.breakDetail.RecoverBreak(randomNumber);
            owner.OnAddBuff<BattleUnitBuf_Shield_C21341>(0);
        }
    }
}