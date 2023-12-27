using System.Collections.Generic;
using UtilLoader21341.Extensions;

namespace TheColorsMod_C21341.CustomFloor.EmotionCard.Sae
{
    public class EmotionCardAbility_EmotionStance_C21341 : EmotionCardAbilityBase
    {
        public override void OnSelectEmotion()
        {
            var passive = new PassiveAbility_SwitchBuffsOddAndEven_DLL21341();
            _owner.passiveDetail.PassiveList.Add(passive);
            passive.Init(_owner);
            passive.SetKeywords(new List<KeywordBuf> { KeywordBuf.Strength, KeywordBuf.Endurance });
            passive.SetAddOneExtra(true);
            passive.SetActive(true);
        }

        public override void OnWaveStart()
        {
            var passive = new PassiveAbility_SwitchBuffs_DLL21341();
            _owner.passiveDetail.PassiveList.Add(passive);
            passive.Init(_owner);
            passive.SetAddOneExtra(true);
            passive.SetActive(true);
        }
    }
}