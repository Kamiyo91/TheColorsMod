using System.Linq;
using LOR_DiceSystem;
using UtilLoader21341.Util;

namespace TheColorsMod_C21341.Wonderland.Buff
{
    public class BattleUnitBuf_TimeRecession_C21341 : BattleUnitBuf
    {
        protected override string keywordId => "TimeRecession_C21341";
        protected override string keywordIconId => "TimeRecession_C21341";

        public override void OnEndBattle(BattlePlayingCardDataInUnitModel curCard)
        {
            if (stack < 5 || curCard.card.CreateDiceCardBehaviorList().All(x => x.Type == BehaviourType.Standby) ||
                !curCard.card.IsNotMassAttackOrSpecialAttack(99))
            {
                this.AddBufCustom(1, maxStack: 5);
                return;
            }

            var aliveList = BattleObjectManager.instance.GetAliveList(_owner.faction.ReturnOtherSideFaction());
            if (!aliveList.Any()) return;
            _owner.RecoverHP(5);
            this.AddBufCustom(-99);
            var target = RandomUtil.SelectOne(aliveList);
            Singleton<StageController>.Instance.AddAllCardListInBattle(curCard, target);
        }
    }
}