using UtilLoader21341.Util;

namespace TheColorsMod_C21341.Mio.Passive
{
    public class PassiveAbility_KurosawaBlade_C21341 : PassiveAbilityBase
    {
        public override void OnSucceedAttack(BattleDiceBehavior behavior)
        {
            owner.SetPassiveCombatLog(this);
            owner.RecoverHP(2);
            owner.breakDetail.RecoverBreak(2);
        }
    }
}