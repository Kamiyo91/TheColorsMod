using Sound;
using UnityEngine;

namespace TheColorsMod_C21341.Miyu.Action
{
    public class BehaviourAction_MiyuSacrifice_C21341 : BehaviourActionBase
    {
        public override FarAreaEffect SetFarAreaAtkEffect(BattleUnitModel self)
        {
            _self = self;
            var effect = new GameObject().AddComponent<FarAreaEffect_MiyuSacrifice_C21341>();
            effect.Init(self, new[]
            {
                2
            });
            SingletonBehavior<SoundEffectManager>.Instance.PlayClip("Creature/WhiteNight_OneBad_AfterKill");
            return effect;
        }
    }
}