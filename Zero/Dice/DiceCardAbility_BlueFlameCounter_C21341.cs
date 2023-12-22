namespace TheColorsMod_C21341.Zero.Dice
{
    public class DiceCardAbility_BlueFlameCounter_C21341 : DiceCardAbilityBase
    {
        public override void BeforeRollDice()
        {
            if (owner.bufListDetail.GetKewordBufAllStack(KeywordBuf.Burn) > 19)
                behavior.ApplyDiceStatBonus(new DiceStatBonus
                {
                    power = 1
                });
        }
    }
}