using UtilLoader21341.Util;

namespace TheColorsMod_C21341.Raziel.Card
{
    public class DiceCardSelfAbility_Execution_C21341 : DiceCardSelfAbilityBase
    {
        private const int Check = 1;
        private int _atkLand;

        public override void OnUseCard()
        {
            owner.allyCardDetail.DrawCards(1);
            _atkLand = 0;
        }

        public override void AfterGiveDamage(int damage, BattleUnitModel target)
        {
            _atkLand += damage;
        }

        public override void OnEndBattle()
        {
            if (_atkLand < Check) return;
            owner.bufListDetail.AddKeywordBufByCard(KeywordBuf.Protection, 1, owner);
            owner.ReadyCounterCard(63, TheColorsModParameters.PackageId);
        }
    }
}