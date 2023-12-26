using UtilLoader21341.Util;

namespace TheColorsMod_C21341.CustomFloor.EmotionCard.Wonderland
{
    public class EmotionCardAbility_EmotionEmergencyStocks_C21341 : EmotionCardAbilityBase
    {
        public override void OnSelectEmotion()
        {
            _owner.cardSlotDetail.RecoverPlayPoint(_owner.MaxPlayPoint);
            _owner.DrawUntilX(4);
        }

        public override void OnRoundStart()
        {
            _owner.DrawUntilX(4);
        }
    }
}