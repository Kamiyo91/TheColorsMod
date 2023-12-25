using TheColorsMod_C21341.CustomFloor;
using TheColorsMod_C21341.Sae.Buff;

namespace TheColorsMod_C21341.Sae.Card
{
    public class DiceCardSelfAbility_DefStance_C21341 : DiceCardSelfAbilityBase
    {
        public override void OnUseInstance(BattleUnitModel unit, BattleDiceCardModel self, BattleUnitModel targetUnit)
        {
            Activate(unit);
            self.exhaust = true;
        }

        public static void Activate(BattleUnitModel unit)
        {
            if (unit.bufListDetail.HasBuf<DiceCardSelfAbility_DefStance_C21341>()) return;
            if (unit.faction == Faction.Enemy)
                ChangeDeckEnemy(unit);
            StanceUtil.RemoveStanceBuffs(unit);
            StanceUtil.RemoveCards(unit);
            unit.ChangeStance<BattleUnitBuf_DefStance_C21341>("Def", 1);
            unit.bufListDetail.AddKeywordBufThisRoundByEtc(KeywordBuf.Endurance, 1, unit);
            StanceUtil.DecreaseStacksBufType(unit, KeywordBuf.Strength, 1);
            StanceUtil.CheckEmotionCard(unit, StruggleEmotionType.Def);
        }

        public override bool IsTargetableSelf()
        {
            return true;
        }

        public override bool OnChooseCard(BattleUnitModel owner)
        {
            return !owner.bufListDetail.HasBuf<BattleUnitBuf_DefStance_C21341>();
        }

        private static void ChangeDeckEnemy(BattleUnitModel unit)
        {
            var cardInHand = unit.allyCardDetail.GetHand().Count;
            unit.allyCardDetail.ExhaustAllCards();
            foreach (var cardId in TheColorsModParameters.SaeDefDeck)
                unit.allyCardDetail.AddNewCardToDeck(cardId);
            unit.allyCardDetail.DrawCards(cardInHand);
            unit.allyCardDetail.DrawCards(5);
        }
    }
}