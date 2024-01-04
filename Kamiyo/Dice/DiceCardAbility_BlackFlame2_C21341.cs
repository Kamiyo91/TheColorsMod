using TheColorsMod_C21341.Kamiyo.Buff;
using UtilLoader21341.Util;

namespace TheColorsMod_C21341.Kamiyo.Dice
{
    public class DiceCardAbility_BlackFlame2_C21341 : DiceCardAbilityBase
    {
        public override string[] Keywords => new[] { "BlackFlame_C21341" };

        public override void OnSucceedAttack(BattleUnitModel target)
        {
            target?.AddBuffCustom<BattleUnitBuf_BlackFlame_C21341>(2);
        }
    }
}