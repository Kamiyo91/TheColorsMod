using System;
using TheColorsMod_C21341.Zero.Effect;
using UnityEngine;

namespace TheColorsMod_C21341.Zero.Action
{
    public class BehaviourAction_TheBlueFlame_C21341 : BehaviourActionBase
    {
        public override FarAreaEffect SetFarAreaAtkEffect(BattleUnitModel self)
        {
            _self = self;
            var effect = new GameObject().AddComponent<FarAreaEffect_TheBlueFlame_C21341>();
            effect.Init(self, Array.Empty<object>());
            return effect;
        }
    }
}