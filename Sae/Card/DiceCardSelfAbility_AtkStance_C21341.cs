using TheColorsMod_C21341.CustomFloor;
using TheColorsMod_C21341.Sae.Buff;
using TheColorsMod_C21341.Sae.Passive;
using UtilLoader21341.Util;

namespace TheColorsMod_C21341.Sae.Card
{
    public class DiceCardSelfAbility_AtkStance_C21341 : DiceCardSelfAbilityBase
    {
        public override void OnUseInstance(BattleUnitModel unit, BattleDiceCardModel self, BattleUnitModel targetUnit)
        {
            Activate(unit);
            self.exhaust = true;
        }

        public static void Activate(BattleUnitModel unit)
        {
            if (unit.bufListDetail.HasBuf<BattleUnitBuf_AtkStance_C21341>()) return;
            if (unit.faction == Faction.Enemy)
                ChangeDeckEnemy(unit);
            StanceUtil.RemoveStanceBuffs(unit);
            StanceUtil.RemoveCards(unit);
            unit.ChangeStance<BattleUnitBuf_AtkStance_C21341>(0, ActionDetail.Standing);
            unit.bufListDetail.AddKeywordBufThisRoundByEtc(KeywordBuf.Strength, 1, unit);
            StanceUtil.DecreaseStacksBufType(unit, KeywordBuf.Endurance, 1);
            StanceUtil.CheckEmotionCard(unit, StruggleEmotionType.Atk);
        }

        public override bool IsTargetableSelf()
        {
            return true;
        }

        public override bool OnChooseCard(BattleUnitModel owner)
        {
            return !owner.bufListDetail.HasBuf<BattleUnitBuf_AtkStance_C21341>();
        }

        private static void ChangeDeckEnemy(BattleUnitModel unit)
        {
            var cardInHand = unit.allyCardDetail.GetHand().Count;
            unit.allyCardDetail.ExhaustAllCards();
            foreach (var cardId in TheColorsModParameters.SaeAttackDeck)
                unit.allyCardDetail.AddNewCardToDeck(cardId);
            unit.allyCardDetail.DrawCards(cardInHand);
            unit.allyCardDetail.DrawCards(5);
            var passive = unit.GetActivePassive<PassiveAbility_StancePassive_C21341>();
            if (passive != null && !passive.SpecialCardUsed)
                unit.allyCardDetail.AddNewCardToDeck(new LorId(TheColorsModParameters.PackageId, 901));
        }
    }
}