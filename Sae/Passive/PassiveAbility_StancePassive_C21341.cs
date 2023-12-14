using TheColorsMod_C21341.Sae.Buff;
using TheColorsMod_C21341.Sae.Card;
using TheColorsMod_C21341.Sae.Dice;
using UtilLoader21341.Util;

namespace TheColorsMod_C21341.Sae.Passive
{
    public class PassiveAbility_StancePassive_C21341 : PassiveAbilityBase
    {
        private bool _counterReload;
        private bool _start;
        public bool SpecialCardUsed;

        public override int GetSpeedDiceAdder(int speedDiceResult)
        {
            if (owner.bufListDetail.HasBuf<BattleUnitBuf_DefStance_C21341>())
                return -100;
            return base.GetSpeedDiceAdder(speedDiceResult);
        }

        public override void OnRoundStartAfter()
        {
            if (owner.faction == Faction.Player) return;
            if (_start)
            {
                _start = false;
                return;
            }

            var randomStance = RandomUtil.Range(0, 1);
            switch (randomStance)
            {
                case 0:
                    DiceCardSelfAbility_AtkStance_C21341.Activate(owner);
                    break;
                case 1:
                    DiceCardSelfAbility_DefStance_C21341.Activate(owner);
                    break;
            }
        }

        public override void OnWaveStart()
        {
            _start = true;
            UnitUtil.CheckSkinProjection(owner);
            DiceCardSelfAbility_AtkStance_C21341.Activate(owner);
        }

        public override void OnStartBattle()
        {
            if (owner.bufListDetail.HasBuf<BattleUnitBuf_DefStance_C21341>())
                owner.ReadyCounterCard(15, TheColorsModParameters.PackageId);
            else if (owner.bufListDetail.HasBuf<BattleUnitBuf_AtkStance_C21341>())
                owner.ReadyCounterCard(14, TheColorsModParameters.PackageId);
        }

        public override void OnRoundStart()
        {
            StanceUtil.AddCards(owner);
        }

        public override void OnLoseParrying(BattleDiceBehavior behavior)
        {
            if (!_counterReload)
                _counterReload = behavior.abilityList.Exists(x => x is DiceCardAbility_SaeBlock_C21341);
        }

        public override void OnDrawParrying(BattleDiceBehavior behavior)
        {
            if (!_counterReload)
                _counterReload = behavior.abilityList.Exists(x => x is DiceCardAbility_SaeBlock_C21341);
        }

        public override void OnWinParrying(BattleDiceBehavior behavior)
        {
            if (!_counterReload)
                _counterReload = behavior.abilityList.Exists(x => x is DiceCardAbility_SaeBlock_C21341);
        }

        public override void OnEndBattle(BattlePlayingCardDataInUnitModel curCard)
        {
            if (!_counterReload) return;
            _counterReload = false;
            owner.SetPassiveCombatLog(this);
            owner.ReadyCounterCard(15, TheColorsModParameters.PackageId);
        }

        public override void OnUseCard(BattlePlayingCardDataInUnitModel curCard)
        {
            if (curCard.card.GetID() == new LorId(TheColorsModParameters.PackageId, 19))
                owner.personalEgoDetail.RemoveCard(curCard.card.GetID());
            if (curCard.card.GetID() != new LorId(TheColorsModParameters.PackageId, 901)) return;
            SpecialCardUsed = true;
            owner.allyCardDetail.ExhaustACardAnywhere(curCard.card);
        }
    }
}