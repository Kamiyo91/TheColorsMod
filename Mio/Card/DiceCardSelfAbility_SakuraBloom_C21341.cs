using UtilLoader21341.Util;

namespace TheColorsMod_C21341.Mio.Card
{
    public class DiceCardSelfAbility_SakuraBloom_C21341 : DiceCardSelfAbilityBase
    {
        private const int Check = 3;

        public override void OnUseCard()
        {
            owner.allyCardDetail.DrawCards(1);
            if (!card.CheckTargetSpeedByCard(Check)) return;
            owner.TakeDamage(9, DamageType.Card_Ability, owner);
            card.ApplyDiceStatBonus(DiceMatch.AllDice, new DiceStatBonus
            {
                power = 1
            });
        }
    }
}