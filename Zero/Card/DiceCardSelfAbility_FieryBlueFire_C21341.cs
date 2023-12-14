using TheColorsMod_C21341.Zero.Buff;
using UtilLoader21341.Util;

namespace TheColorsMod_C21341.Zero.Card
{
    public class DiceCardSelfAbility_FieryBlueFire_C21341 : DiceCardSelfAbilityBase
    {
        public override void OnUseCard()
        {
            owner.cardSlotDetail.RecoverPlayPoint(1);
            var buff = owner.GetActiveBuff<BattleUnitBuf_BlueBurn_C21341>();
            if (buff == null || buff.stack < 5) return;
            buff.OnAddBuf(-5);
            owner.allyCardDetail.DrawCards(1);
            card.ApplyDiceStatBonus(DiceMatch.AllDice, new DiceStatBonus
            {
                power = 1
            });
        }
    }
}