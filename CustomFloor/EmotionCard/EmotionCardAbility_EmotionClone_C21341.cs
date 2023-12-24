using System.Linq;

namespace TheColorsMod_C21341.CustomFloor.EmotionCard
{
    public class EmotionCardAbility_EmotionClone_C21341 : EmotionCardAbilityBase
    {
        public override void OnSelectEmotion()
        {
            foreach (var unit in BattleObjectManager.instance.GetAliveList().Where(x => x != _owner))
                unit.TakeDamage(50);
        }
    }
}