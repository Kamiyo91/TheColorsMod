using TheColorsMod_C21341.Wonderland.Buff;
using UtilLoader21341.Util;

namespace TheColorsMod_C21341.Wonderland.Dice
{
    public class DiceCardAbility_Inflict1PurplePoison_C21341 : DiceCardAbilityBase
    {
        public override void OnSucceedAttack(BattleUnitModel target)
        {
            target?.OnAddBuff<BattleUnitBuf_PurplePoison_C21341>(1);
        }
    }
}