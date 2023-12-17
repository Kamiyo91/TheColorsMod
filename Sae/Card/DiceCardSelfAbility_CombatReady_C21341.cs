using LOR_DiceSystem;
using TheColorsMod_C21341.Sae.Buff;

namespace TheColorsMod_C21341.Sae.Card
{
    public class DiceCardSelfAbility_CombatReady_C21341 : DiceCardSelfAbilityBase
    {
        public override void OnUseCard()
        {
            owner.allyCardDetail.DrawCards(1);
            if (!owner.bufListDetail.HasBuf<BattleUnitBuf_DefStance_C21341>()) return;
            foreach (var battleDice in card.GetDiceBehaviorList())
            {
                battleDice.behaviourInCard = battleDice.behaviourInCard.Copy();
                battleDice.behaviourInCard.Detail = BehaviourDetail.Guard;
                battleDice.behaviourInCard.MotionDetail = MotionDetail.G;
                battleDice.behaviourInCard.Type = BehaviourType.Def;
                battleDice.behaviourInCard.EffectRes = "Hana_G";
            }
        }
    }
}