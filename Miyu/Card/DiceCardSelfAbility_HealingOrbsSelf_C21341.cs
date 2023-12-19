using System;

namespace TheColorsMod_C21341.Miyu.Card
{
    public class DiceCardSelfAbility_HealingOrbsSelf_C21341 : DiceCardSelfAbility_MiyuCommonCard_C21341
    {
        private readonly Random _random = new Random();

        public override string[] Keywords
        {
            get
            {
                return new[]
                {
                    "Healer_C21341"
                };
            }
        }

        public override bool IsValidTarget(BattleUnitModel unit, BattleDiceCardModel self, BattleUnitModel targetUnit)
        {
            return targetUnit == owner;
        }

        public override bool IsTargetableSelf()
        {
            return true;
        }

        public override void OnUseCard()
        {
            var randomNumber = _random.Next(2, 20);
            owner.RecoverHP(randomNumber);
            owner.breakDetail.RecoverBreak(randomNumber);
            owner.cardSlotDetail.RecoverPlayPointByCard(1);
            owner.allyCardDetail.DrawCards(1);
        }
    }
}