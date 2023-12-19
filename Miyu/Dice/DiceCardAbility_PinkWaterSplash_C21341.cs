namespace TheColorsMod_C21341.Miyu.Dice
{
    public class DiceCardAbility_PinkWaterSplashDie_C21341 : DiceCardAbilityBase
    {
        public override void OnSucceedAttack(BattleUnitModel target)
        {
            var stack = target.bufListDetail.GetKewordBufAllStack(KeywordBuf.Burn);
            target.TakeDamage(stack);
            target.TakeBreakDamage(stack);
            target.bufListDetail.RemoveBufAll(KeywordBuf.Burn);
        }
    }
}