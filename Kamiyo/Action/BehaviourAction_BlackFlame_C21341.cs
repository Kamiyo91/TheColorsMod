using System.Collections.Generic;
using UnityEngine;

namespace TheColorsMod_C21341.Kamiyo.Action
{
    public class BehaviourAction_BlackFlame_C21341 : BehaviourActionBase
    {
        private bool _moved;
        private BattleUnitModel _target;

        public override bool IsMovable()
        {
            return false;
        }

        public override bool IsOpponentMovable()
        {
            return false;
        }

        public override List<RencounterManager.MovingAction> GetMovingAction(
            ref RencounterManager.ActionAfterBehaviour self, ref RencounterManager.ActionAfterBehaviour opponent)
        {
            if (self.result != Result.Win || opponent.behaviourResultData.IsFarAtk())
                return base.GetMovingAction(ref self, ref opponent);
            _self = self.view.model;
            _target = opponent.view.model;
            if (opponent.infoList.Count > 0)
                opponent.infoList.Clear();
            opponent.infoList = SetDamageEnemy();
            return SetAttacksPlayer();
        }

        private List<RencounterManager.MovingAction> SetAttacksPlayer()
        {
            return new List<RencounterManager.MovingAction>
            {
                CreateAttackAction(ActionDetail.Move, 0.1f, "", EffectTiming.NOT_PRINT, EffectTiming.NOT_PRINT,
                    EffectTiming.NOT_PRINT, CharMoveState.Custom, true),
                CreateAttackAction(ActionDetail.Hit, 0.2f,
                    "KamiyoHitForgotten_C21341", EffectTiming.PRE,
                    EffectTiming.NONE,
                    EffectTiming.WITHOUT_DMGTEXT),
                CreateAttackAction(ActionDetail.Slash, 0.3f,
                    "KamiyoSlashForgotten_C21341", EffectTiming.PRE,
                    EffectTiming.NONE, EffectTiming.WITHOUT_DMGTEXT),
                CreateAttackAction(ActionDetail.Penetrate, 0.65f,
                    "KamiyoPierceForgotten_C21341", EffectTiming.PRE,
                    EffectTiming.NONE, EffectTiming.WITHOUT_DMGTEXT),
                CreateAttackAction(ActionDetail.Hit, 0.5f,
                    "KamiyoHitForgotten_C21341", EffectTiming.PRE,
                    EffectTiming.PRE,
                    EffectTiming.PRE)
            };
            ;
        }

        private static List<RencounterManager.MovingAction> SetDamageEnemy()
        {
            return new List<RencounterManager.MovingAction>
            {
                new RencounterManager.MovingAction(ActionDetail.Default, CharMoveState.Stop, 1f, true, 0.1f),
                new RencounterManager.MovingAction(ActionDetail.Damaged, CharMoveState.Stop, 1f, true, 0.2f),
                new RencounterManager.MovingAction(ActionDetail.Damaged, CharMoveState.Stop, 1f, true, 0.3f),
                new RencounterManager.MovingAction(ActionDetail.Damaged, CharMoveState.Stop, 1f, true, 0.65f),
                new RencounterManager.MovingAction(ActionDetail.Damaged, CharMoveState.Knockback, 1f, true, 0.5f)
                    { knockbackPower = 10f }
            };
        }

        private RencounterManager.MovingAction CreateAttackAction(ActionDetail action, float delay,
            string effectRes, EffectTiming attackTiming, EffectTiming recoverTiming, EffectTiming damageDisplayTiming,
            CharMoveState moveType = CharMoveState.Stop, bool move = false)
        {
            var movingAction = new RencounterManager.MovingAction(action, moveType, 0f, true, delay);
            if (move) movingAction.SetCustomMoving(MoveFirst);
            movingAction.customEffectRes = effectRes;
            movingAction.SetEffectTiming(attackTiming, recoverTiming, damageDisplayTiming);
            return movingAction;
        }

        private bool MoveFirst(float deltaTime)
        {
            if (_target == null) return true;
            if (!_moved)
            {
                var num =
                    SingletonBehavior<HexagonalMapManager>.Instance.tileSize * _target.view.transform.localScale.x + 6f;
                var num2 = 1;
                if (_self.view.WorldPosition.x < _target.view.WorldPosition.x)
                    num2 = -1;
                var pos = _target.view.WorldPosition + new Vector3(num2 * num, 0f, 0f);
                _self.moveDetail.Move(pos, 150f);
                _moved = true;
            }
            else if (_self.moveDetail.isArrived)
            {
                return true;
            }

            return false;
        }
    }
}