using TheColorsMod_C21341.Reno.Passive;
using UtilLoader21341.Util;

namespace TheColorsMod_C21341.Reno.Card
{
    public class DiceCardSelfAbility_CorrosionWeapons_C21341 : DiceCardSelfAbilityBase
    {
        public override void OnUseCard()
        {
            owner.allyCardDetail.DrawCards(1);
        }

        public override void OnStartBattle()
        {
            var passive = owner.GetActivePassive<PassiveAbility_Corrosion_C21341>();
            if (passive != null) passive.Stack = 3;
        }
    }
}