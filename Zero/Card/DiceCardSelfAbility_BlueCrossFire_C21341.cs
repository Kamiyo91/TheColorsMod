using System.Linq;
using TheColorsMod_C21341.Zero.Buff;
using UtilLoader21341.Util;

namespace TheColorsMod_C21341.Zero.Card
{
    public class DiceCardSelfAbility_BlueCrossFire_C21341 : DiceCardSelfAbilityBase
    {
        public override void OnUseCard()
        {
            var buff = owner.GetActiveBuff<BattleUnitBuf_BlueBurn_C21341>();
            if (buff == null || buff.stack < 10) return;
            var dice = card.card.CreateDiceCardBehaviorList().FirstOrDefault();
            var limit = 0;
            for (var i = 0; i <= buff.stack + 10 && limit < 3; i += 10)
            {
                card.AddDice(dice);
                limit++;
                buff.OnAddBuf(-10);
            }
        }
    }
}