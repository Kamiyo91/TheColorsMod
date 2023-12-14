using UtilLoader21341.Util;

namespace TheColorsMod_C21341.Kamiyo.Passive
{
    public class PassiveAbility_ForgottenMask_C21341 : PassiveAbilityBase
    {
        public override bool CanAddBuf(BattleUnitBuf buf)
        {
            return buf.bufType != KeywordBuf.Paralysis && base.CanAddBuf(buf);
        }

        public override void OnStartTargetedOneSide(BattlePlayingCardDataInUnitModel attackerCard)
        {
            if (attackerCard == null || owner.speedDiceResult.Count - 1 != attackerCard.targetSlotOrder) return;
            owner.SetPassiveCombatLog(this);
            attackerCard.ApplyDiceStatBonus(DiceMatch.AllDice, new DiceStatBonus
            {
                min = -1,
                max = -1
            });
        }

        public override void OnStartParrying(BattlePlayingCardDataInUnitModel card)
        {
            if (card == null || owner.speedDiceResult.Count - 1 != card.slotOrder) return;
            var target = card.target;
            var attackerCard = target?.currentDiceAction;
            owner.SetPassiveCombatLog(this);
            attackerCard?.ApplyDiceStatBonus(DiceMatch.AllDice, new DiceStatBonus
            {
                min = -1,
                max = -1
            });
        }
    }
}