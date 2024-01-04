using TheColorsMod_C21341.Mio.Buff;
using TheColorsMod_C21341.Mio.Passive;
using UtilLoader21341.Util;

namespace TheColorsMod_C21341.CustomFloor.EmotionCard.Mio
{
    public class EmotionCardAbility_EmotionMio_C21341 : EmotionCardAbilityBase
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
            _owner.GetActivePassive<PassiveAbility_GodFragment_C21341>()?.ForcedEgo();
            if (_owner.GetActivePassive<PassiveAbility_MysticEyesOfHeaven_C21341>() != null)
            {
                var buff =
                    _owner.AddBuffCustom<BattleUnitBuf_MysticEyesOfHeaven_C21341>(0) as
                        BattleUnitBuf_MysticEyesOfHeaven_C21341;
                buff?.SetResistType(AtkResist.Vulnerable);
                return;
            }

            var passive = new PassiveAbility_MysticEyesOfHeaven_C21341();
            _owner.passiveDetail.PassiveList.Add(passive);
            passive.Init(_owner);
            passive.Active();
        }
    }
}