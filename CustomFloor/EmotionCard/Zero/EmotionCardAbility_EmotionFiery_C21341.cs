using System.Linq;

namespace TheColorsMod_C21341.CustomFloor.EmotionCard.Zero
{
    public class EmotionCardAbility_EmotionFiery_C21341 : EmotionCardAbilityBase
    {
        public override void OnSucceedAttack(BattleDiceBehavior behavior)
        {
            foreach (var unit in BattleObjectManager.instance.GetAliveList().Where(x => x != _owner))
                unit.bufListDetail.AddKeywordBufByEtc(KeywordBuf.Burn, 1, _owner);
        }
    }
}