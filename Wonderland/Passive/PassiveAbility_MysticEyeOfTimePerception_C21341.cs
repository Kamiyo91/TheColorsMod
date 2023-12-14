using UtilLoader21341.Util;

namespace TheColorsMod_C21341.Wonderland.Passive
{
    public class PassiveAbility_MysticEyeOfTimePerception_C21341 : PassiveAbilityBase
    {
        public override void OnWaveStart()
        {
            owner.bufListDetail.AddKeywordBufThisRoundByEtc(KeywordBuf.Quickness, 2, owner);
        }

        public override void OnRoundEnd()
        {
            owner.bufListDetail.AddKeywordBufByEtc(KeywordBuf.Quickness, 2, owner);
        }

        public override void BeforeRollDice(BattleDiceBehavior behavior)
        {
            if (owner.passiveDetail.HasPassive<PassiveAbility_Clone_C21341>())
                behavior.ApplyDiceStatBonus(
                    new DiceStatBonus
                    {
                        min = 2,
                        max = 2
                    });
        }

        public override void OnStartTargetedOneSide(BattlePlayingCardDataInUnitModel attackerCard)
        {
            owner.SetPassiveCombatLog(this);
            if (attackerCard == null) return;
            var playerSpeed = attackerCard.target.currentDiceAction.speedDiceResultValue;
            var enemySpeed = attackerCard.speedDiceResultValue;
            if (playerSpeed <= enemySpeed) return;
            attackerCard.ApplyDiceStatBonus(DiceMatch.AllDice, new DiceStatBonus
            {
                min = -2
            });
        }

        public override void OnStartParrying(BattlePlayingCardDataInUnitModel card)
        {
            var battlePlayingCardDataInUnitModel = card?.target.currentDiceAction;
            var playerSpeed = card?.speedDiceResultValue;
            var targetSpeed = card?.target.currentDiceAction.speedDiceResultValue;
            if (playerSpeed <= targetSpeed) return;
            owner.SetPassiveCombatLog(this);
            battlePlayingCardDataInUnitModel?.ApplyDiceStatBonus(DiceMatch.AllDice, new DiceStatBonus
            {
                min = -2
            });
        }
    }
}