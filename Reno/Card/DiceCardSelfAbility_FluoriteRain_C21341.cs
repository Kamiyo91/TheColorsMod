using System.Linq;
using TheColorsMod_C21341.Reno.Buff;
using UtilLoader21341.Util;

namespace TheColorsMod_C21341.Reno.Card
{
    public class DiceCardSelfAbility_FluoriteRain_C21341 : DiceCardSelfAbilityBase
    {
        public override void OnUseCard()
        {
            owner.cardSlotDetail.RecoverPlayPointByCard(1);
            owner.allyCardDetail.DrawCards(1);
            var buff = owner.GetActiveBuff<BattleUnitBuf_GreenLeaf_C21341>();
            if (buff != null && buff.stack > 9)
                card.AddDice(card.card.CreateDiceCardBehaviorList().FirstOrDefault());
        }
    }
}