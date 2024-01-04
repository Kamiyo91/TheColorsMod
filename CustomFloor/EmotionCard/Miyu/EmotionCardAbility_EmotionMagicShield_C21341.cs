using TheColorsMod_C21341.CustomFloor.Buff;
using UtilLoader21341.Util;

namespace TheColorsMod_C21341.CustomFloor.EmotionCard.Miyu
{
    public class EmotionCardAbility_EmotionMagicShield_C21341 : EmotionCardAbilityBase
    {
        public override void OnSelectEmotion()
        {
            _owner.AddBuffCustom<BattleUnitBuf_EmotionShield_C21341>(0);
        }

        public override void OnWaveStart()
        {
            _owner.AddBuffCustom<BattleUnitBuf_EmotionShield_C21341>(0);
        }

        public override void OnRoundStart()
        {
            _owner.AddBuffCustom<BattleUnitBuf_EmotionShield_C21341>(0);
        }
    }
}