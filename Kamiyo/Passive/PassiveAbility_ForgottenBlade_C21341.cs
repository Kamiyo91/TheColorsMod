using UtilLoader21341.Util;

namespace TheColorsMod_C21341.Kamiyo.Passive
{
    public class PassiveAbility_ForgottenBlade_C21341 : PassiveAbilityBase
    {
        public override void OnSucceedAttack(BattleDiceBehavior behavior)
        {
            owner.SetPassiveCombatLog(this);
            owner.RecoverHP(1);
            owner.breakDetail.RecoverBreak(1);
        }
    }
}