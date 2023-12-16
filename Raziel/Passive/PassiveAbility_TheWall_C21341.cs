using LOR_DiceSystem;

namespace TheColorsMod_C21341.Raziel.Passive
{
    public class PassiveAbility_TheWall_C21341 : PassiveAbilityBase
    {
        public override void BeforeRollDice(BattleDiceBehavior behavior)
        {
            if (behavior.Detail == BehaviourDetail.Guard) behavior.ApplyDiceStatBonus(new DiceStatBonus { power = 1 });
        }
    }
}