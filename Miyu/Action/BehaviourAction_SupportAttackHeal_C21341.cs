using System.Collections.Generic;

namespace TheColorsMod_C21341.Miyu.Action
{
    public class BehaviourAction_SupportAttackHeal_C21341 : BehaviourActionBase
    {
        public override bool IsMovable(BattleCardBehaviourResult self, BattleCardBehaviourResult opponent)
        {
            return true;
        }

        public override bool IsOpponentMovable(BattleCardBehaviourResult self, BattleCardBehaviourResult opponent)
        {
            return false;
        }

        public override List<RencounterManager.MovingAction> GetMovingAction(
            ref RencounterManager.ActionAfterBehaviour self, ref RencounterManager.ActionAfterBehaviour opponent)
        {
            opponent.infoList = new List<RencounterManager.MovingAction>();
            var item = new RencounterManager.MovingAction(ActionDetail.Default, CharMoveState.Stop, 0f, true, 0.3f);
            opponent.infoList.Add(item);
            return SetAttacksPlayer();
        }

        private List<RencounterManager.MovingAction> SetAttacksPlayer()
        {
            return new List<RencounterManager.MovingAction>
            {
                CreateAttackAction(ActionDetail.S1, 0.5f, "MiyuMagic8_C21341", EffectTiming.NOT_PRINT, EffectTiming.PRE,
                    EffectTiming.NOT_PRINT, CharMoveState.Custom)
            };
        }

        private RencounterManager.MovingAction CreateAttackAction(ActionDetail action, float delay,
            string effectRes, EffectTiming attackTiming, EffectTiming recoverTiming, EffectTiming damageDisplayTiming,
            CharMoveState moveType = CharMoveState.Stop)
        {
            var movingAction = new RencounterManager.MovingAction(action, moveType, 0f, true, delay)
            {
                customEffectRes = effectRes
            };
            movingAction.SetEffectTiming(attackTiming, recoverTiming, damageDisplayTiming);
            return movingAction;
        }
    }
}