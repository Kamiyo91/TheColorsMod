using TheColorsMod_C21341.Zero.Passive;
using UtilLoader21341.Util;

namespace TheColorsMod_C21341.CustomFloor.EmotionCard.Zero
{
    public class EmotionCardAbility_EmotionFire_C21341 : EmotionCardAbilityBase
    {
        public override void OnSelectEmotion()
        {
            ActiveEgo();
        }

        public override void OnWaveStart()
        {
            ActiveEgo();
        }

        public void ActiveEgo()
        {
            _owner.GetActivePassive<PassiveAbility_Zero_C21341>()?.ForcedEgo();
        }

        public override void OnRoundStart()
        {
            _owner.bufListDetail.AddKeywordBufByEtc(KeywordBuf.Burn, 3, _owner);
        }
    }
}