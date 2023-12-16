namespace TheColorsMod_C21341.Raziel.Card
{
    public class DiceCardSelfAbility_Meeting_C21341 : DiceCardSelfAbilityBase
    {
        private const int Check = 1;
        private int _atkLand;

        public override void OnUseCard()
        {
            owner.allyCardDetail.DrawCards(1);
        }

        public override void AfterGiveDamage(int damage, BattleUnitModel target)
        {
            _atkLand += damage;
        }

        public override void OnEndBattle()
        {
            if (_atkLand < Check) return;
            owner.bufListDetail.AddKeywordBufByCard(KeywordBuf.Protection, 1, owner);
            owner.cardSlotDetail.RecoverPlayPoint(1);
        }
    }
}