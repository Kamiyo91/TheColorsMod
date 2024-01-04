using System.Linq;
using LOR_DiceSystem;
using TheColorsMod_C21341.Zero.Passive;
using UtilLoader21341.Util;

namespace TheColorsMod_C21341.Zero.Buff
{
    public class BattleUnitBuf_AnOldFriendBlue_C21341 : BattleUnitBuf
    {
        public PassiveAbility_AnOldFriendBlueFlame_C21341 Passive;
        protected override string keywordId => "OldFriend_C21341";
        protected override string keywordIconId => "OldFriendBlue_C21341";

        public override void Init(BattleUnitModel owner)
        {
            base.Init(owner);
            Passive = owner.GetActivePassive<PassiveAbility_AnOldFriendBlueFlame_C21341>();
            if (Passive == null) owner.bufListDetail.RemoveBuf(this);
        }

        public override void OnEndBattle(BattlePlayingCardDataInUnitModel curCard)
        {
            if (stack < 5)
            {
                this.AddBufCustom(1);
                return;
            }

            var target = curCard.target;
            if (target == null || Passive?.AllyUnit == null) return;
            var cards = Passive.AllyUnit.allyCardDetail.GetAllDeck().Where(x =>
                x.XmlData.Spec.Ranged != CardRange.FarArea && x.XmlData.Spec.Ranged != CardRange.FarAreaEach &&
                x.XmlData.Spec.Ranged != CardRange.Special).ToList();
            if (!cards.Any()) return;
            this.AddBufCustom(-99);
            var cardInfo = RandomUtil.SelectOne(cards);
            var card = new BattlePlayingCardDataInUnitModel
            {
                owner = Passive.AllyUnit,
                card = cardInfo,
                target = target
            };
            Singleton<StageController>.Instance.AddAllCardListInBattle(card, target);
        }
    }
}