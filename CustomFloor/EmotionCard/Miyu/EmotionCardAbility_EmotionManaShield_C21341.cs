using TheColorsMod_C21341.CustomFloor.Buff;
using TheColorsMod_C21341.Miyu.Buff;
using TheColorsMod_C21341.Miyu.Passive;
using UtilLoader21341.Util;

namespace TheColorsMod_C21341.CustomFloor.EmotionCard.Miyu
{
    public class EmotionCardAbility_EmotionManaShield_C21341 : EmotionCardAbilityBase
    {
        public override void OnSelectEmotion()
        {
            _owner.AddBuffCustom<BattleUnitBuf_Mana_C21341>(100, maxStack: 100);
            if (_owner.GetActivePassive<PassiveAbility_ThePinkIdol_C21341>() != null)
                _owner.AddBuffCustom<BattleUnitBuf_ManaShield_C21341>(0);
            else _owner.AddBuffCustom<BattleUnitBuf_ManaShieldEmotion_C21341>(0);
        }

        public override void OnWaveStart()
        {
            _owner.AddBuffCustom<BattleUnitBuf_Mana_C21341>(100, maxStack: 100);
            if (_owner.GetActivePassive<PassiveAbility_ThePinkIdol_C21341>() != null)
                _owner.AddBuffCustom<BattleUnitBuf_ManaShield_C21341>(0);
            else _owner.AddBuffCustom<BattleUnitBuf_ManaShieldEmotion_C21341>(0);
        }
    }
}