using UtilLoader21341.Util;

namespace TheColorsMod_C21341.Mio.Card
{
    public class DiceCardSelfAbility_WaterBlade_C21341 : DiceCardSelfAbilityBase
    {
        private const int Check = 2;

        public override void OnUseCard()
        {
            owner.cardSlotDetail.RecoverPlayPointByCard(1);
            if (!card.CheckTargetSpeedByCard(Check)) return;
            owner.ChangeSameCardsCost(card, -1);
            owner.allyCardDetail.DrawCards(1);
        }
    }
}