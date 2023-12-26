using TheColorsMod_C21341.Sae.Buff;
using UtilLoader21341.Util;

namespace TheColorsMod_C21341.CustomFloor
{
    public class EmotionCardAbility_StanceType_C21341 : EmotionCardAbilityBase
    {
        public StruggleEmotionType Type;

        public override void OnRoundStart()
        {
            Type = _owner.GetActiveBuff<BattleUnitBuf_DefStance_C21341>() != null
                ? StruggleEmotionType.Def
                : StruggleEmotionType.Atk;
        }

        public void SetType(StruggleEmotionType type)
        {
            Type = type;
        }
    }

    public enum StruggleEmotionType
    {
        Atk,
        Def
    }
}