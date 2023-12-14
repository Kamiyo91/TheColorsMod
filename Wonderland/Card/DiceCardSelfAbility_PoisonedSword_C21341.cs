using TheColorsMod_C21341.Wonderland.Passive;
using UtilLoader21341.Util;

namespace TheColorsMod_C21341.Wonderland.Card
{
    public class DiceCardSelfAbility_PoisonedSword_C21341 : DiceCardSelfAbilityBase
    {
        public override bool OnChooseCard(BattleUnitModel owner)
        {
            return owner.emotionDetail.EmotionLevel > 2;
        }

        public override void OnStartBattle()
        {
            owner.allyCardDetail.DrawCards(1);
            owner.cardSlotDetail.RecoverPlayPoint(1);
            owner.bufListDetail.AddKeywordBufThisRoundByEtc(KeywordBuf.Smoke, 3, owner);
            var passive = owner.GetActivePassive<PassiveAbility_PoisonedBlade_C21341>();
            if (passive != null) passive.Multiplier = 2;
        }
    }
}