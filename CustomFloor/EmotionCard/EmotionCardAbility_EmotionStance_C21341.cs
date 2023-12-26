using TheColorsMod_C21341.CustomFloor.Passive;

namespace TheColorsMod_C21341.CustomFloor.EmotionCard
{
    public class EmotionCardAbility_EmotionStance_C21341 : EmotionCardAbilityBase
    {
        public override void OnSelectEmotion()
        {
            var passive = new PassiveAbility_EmotionStance_C21341();
            _owner.passiveDetail.PassiveList.Add(passive);
            passive.Init(_owner);
            passive.OnWaveStart();
        }

        public override void OnWaveStart()
        {
            var passive = new PassiveAbility_EmotionStance_C21341();
            _owner.passiveDetail.PassiveList.Add(passive);
            passive.Init(_owner);
            passive.OnWaveStart();
        }
    }
}