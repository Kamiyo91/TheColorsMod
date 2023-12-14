using System;
using UnityEngine;

namespace TheColorsMod_C21341.Mio.Action
{
    public class BehaviourAction_MioAbyssalDiamond_C21341 : BehaviourActionBase
    {
        public override FarAreaEffect SetFarAreaAtkEffect(BattleUnitModel self)
        {
            _self = self;
            var farAreaeffectMio = new GameObject().AddComponent<FarAreaEffect_MioAbyssalDiamond_C21341>();
            farAreaeffectMio.Init(self, Array.Empty<object>());
            return farAreaeffectMio;
        }
    }
}