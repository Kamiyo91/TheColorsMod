using System.Linq;
using TheColorsMod_C21341.Zero.Passive;
using UtilLoader21341.Util;

namespace TheColorsMod_C21341.CustomFloor.EgoCard
{
    public class DiceCardSelfAbility_ZeroFloorEgo_C21341 : DiceCardSelfAbility_EgoOneScene_C21341
    {
        public override string SkinName => "Zero_C21341";

        public override void OnUseCard()
        {
            base.OnUseCard();
            var stacks = owner.bufListDetail.GetKewordBufAllStack(KeywordBuf.Burn);
            if (stacks <= 19) return;
            var dice = card.card.CreateDiceCardBehaviorList().FirstOrDefault();
            card.AddDice(dice);
            card.ApplyDiceStatBonus(DiceMatch.AllDice, new DiceStatBonus
            {
                power = 4
            });
            var buff = owner.bufListDetail.GetActivatedBufList().FirstOrDefault(x => x.bufType == KeywordBuf.Burn);
            buff.AddBufCustom(-20, owner.GetActivePassive<PassiveAbility_Zero_C21341>() == null);
        }
    }
}