namespace TheColorsMod_C21341.Miyu.Dice
{
    public class DiceCardAbility_HealDice_C21341 : DiceCardAbilityBase
    {
        public override void OnSucceedAttack(BattleUnitModel target)
        {
            target.breakDetail.RecoverBreak(behavior.DiceResultValue);
            target.RecoverHP(behavior.DiceResultValue);
        }
    }
}