using TheColorsMod_C21341.CustomFloor.Buff;
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
            if (target.GetActiveBuff<BattleUnitBuf_EmotionShield_C21341>() == null)
                target.OnAddBuffCustom<BattleUnitBuf_Shield_C21341>(0, maxStack: 0);
        }
    }
}