using TheColorsMod_C21341.Kamiyo.Buff;
using UtilLoader21341.Util;

namespace TheColorsMod_C21341.Kamiyo.Dice
{
    public class DiceCardAbility_BattleHeatClashWin_C21341 : DiceCardAbilityBase
    {
        public override void OnWinParrying()
        {
            if (owner.GetActiveBuff<BattleUnitBuf_BattleHeat_C21341>() == null) return;
            behavior.card.ApplyDiceStatBonus(DiceMatch.NextDice, new DiceStatBonus
            {
                power = 1
            });
        }
    }
}