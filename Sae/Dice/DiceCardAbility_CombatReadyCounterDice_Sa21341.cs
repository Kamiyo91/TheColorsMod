using LOR_DiceSystem;
using TheColorsMod_C21341.Sae.Buff;

namespace TheColorsMod_C21341.Sae.Dice
{
    public class DiceCardAbility_CombatReadyCounterDice_C21341 : DiceCardAbilityBase
    {
        public override void BeforeRollDice()
        {
            if (!owner.bufListDetail.HasBuf<BattleUnitBuf_DefStance_C21341>()) return;
            behavior.behaviourInCard = behavior.behaviourInCard.Copy();
            behavior.behaviourInCard.Detail = BehaviourDetail.Guard;
            behavior.behaviourInCard.MotionDetail = MotionDetail.G;
            behavior.behaviourInCard.Type = BehaviourType.Standby;
            behavior.behaviourInCard.EffectRes = "Shi_G";
        }
    }
}