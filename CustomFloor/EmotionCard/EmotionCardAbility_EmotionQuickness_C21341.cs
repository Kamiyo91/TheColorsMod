using System.Linq;
using LOR_DiceSystem;

namespace TheColorsMod_C21341.CustomFloor.EmotionCard
{
    public class EmotionCardAbility_EmotionQuickness_C21341 : EmotionCardAbilityBase
    {
        private bool _active;

        public override void OnStartTargetedOneSide(BattlePlayingCardDataInUnitModel curCard)
        {
            if (!_active) return;
            var cards = _owner.allyCardDetail.GetAllDeck().Where(x =>
                x.XmlData.Spec.Ranged != CardRange.FarArea && x.XmlData.Spec.Ranged != CardRange.FarAreaEach &&
                x.XmlData.Spec.Ranged != CardRange.Special).ToList();
            if (!cards.Any()) return;
            var cardInfo = RandomUtil.SelectOne(cards);
            var card = new BattlePlayingCardDataInUnitModel
            {
                owner = _owner,
                card = cardInfo,
                target = curCard.owner
            };
            Singleton<StageController>.Instance.AddAllCardListInBattle(card, curCard.owner);
            _active = false;
        }

        public override void OnSelectEmotion()
        {
            _active = true;
        }

        public override void OnRoundStart()
        {
            _active = true;
        }
    }
}