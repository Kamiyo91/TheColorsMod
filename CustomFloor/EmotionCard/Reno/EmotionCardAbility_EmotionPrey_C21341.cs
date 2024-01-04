using TheColorsMod_C21341.CustomFloor.Buff;
using UtilLoader21341.Util;

namespace TheColorsMod_C21341.CustomFloor.EmotionCard.Reno
{
    public class EmotionCardAbility_EmotionPrey_C21341 : EmotionCardAbilityBase
    {
        public override void OnRoundStart()
        {
            _owner.AddBuffCustom<BattleUnitBuf_EmotionPreyOwner_C21341>(0);
            var enemyUnits = BattleObjectManager.instance.GetAliveList(_owner.faction.ReturnOtherSideFaction());
            var unit = RandomUtil.SelectOne(enemyUnits);
            unit.AddBuffCustom<BattleUnitBuf_EmotionPrey_C21341>(0);
        }

        public override void OnSucceedAttack(BattleDiceBehavior behavior)
        {
            if (behavior.card?.target?.GetActiveBuff<BattleUnitBuf_EmotionPrey_C21341>() == null) return;
            behavior.card?.target?.TakeDamage(2);
            behavior.card?.target?.TakeBreakDamage(2);
        }
    }
}