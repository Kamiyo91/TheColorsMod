using TheColorsMod_C21341.Sae;

namespace TheColorsMod_C21341.CustomFloor.EmotionCard.Sae
{
    public class EmotionCardAbility_EmotionStance_C21341 : EmotionCardAbilityBase
    {
        public override void OnSelectEmotion()
        {
            StanceUtil.AddSwitchBuffEmotionPassive(_owner);
        }

        public override void OnWaveStart()
        {
            StanceUtil.AddSwitchBuffEmotionPassive(_owner);
        }
    }
}