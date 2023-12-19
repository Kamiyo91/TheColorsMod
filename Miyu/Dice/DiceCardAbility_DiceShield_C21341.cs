using TheColorsMod_C21341.Miyu.Buff;
using UtilLoader21341.Util;

namespace TheColorsMod_C21341.Miyu.Dice
{
    public class DiceCardAbility_DiceShield_C21341 : DiceCardAbilityBase
    {
        public override void OnSucceedAttack(BattleUnitModel target)
        {
            target.breakDetail.RecoverBreak(behavior.DiceResultValue);
            target.RecoverHP(behavior.DiceResultValue);
            target.OnAddBuffCustom<BattleUnitBuf_Shield_C21341>(0, maxStack: 0);
        }
    }
}