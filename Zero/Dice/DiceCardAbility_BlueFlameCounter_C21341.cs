using TheColorsMod_C21341.Zero.Buff;
using UtilLoader21341.Util;

namespace TheColorsMod_C21341.Zero.Dice
{
    public class DiceCardAbility_BlueFlameCounter_C21341 : DiceCardAbilityBase
    {
        public override void BeforeRollDice()
        {
            var buff = owner.GetActiveBuff<BattleUnitBuf_BlueBurn_C21341>();
            if (buff != null && buff.stack > 24)
                behavior.ApplyDiceStatBonus(new DiceStatBonus
                {
                    power = 1
                });
        }
    }
}