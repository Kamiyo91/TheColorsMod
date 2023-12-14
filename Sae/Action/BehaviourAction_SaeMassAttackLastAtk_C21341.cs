using System;
using UnityEngine;

namespace TheColorsMod_C21341.Sae.Action
{
    public class BehaviourAction_SaeMassAttackLastAtk_C21341 : BehaviourActionBase
    {
        public override FarAreaEffect SetFarAreaAtkEffect(BattleUnitModel self)
        {
            _self = self;
            var farAreaeffectSae = new GameObject().AddComponent<FarAreaEffect_SaeMassAttack_C21341>();
            farAreaeffectSae.Init(self, Array.Empty<object>());
            farAreaeffectSae.SetLastAttack(true);
            return farAreaeffectSae;
        }
    }
}