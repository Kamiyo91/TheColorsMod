using UtilLoader21341.Util;

namespace TheColorsMod_C21341.CustomFloor.SpecialCard
{
    public class DiceCardSelfAbility_LastMagicCallEmotion_C21341 : DiceCardSelfAbility_EgoOneScene_C21341
    {
        public override string SkinName => "Miyu_C21341";

        public override void OnUseCard()
        {
            base.OnUseCard();
            foreach (var unit in BattleObjectManager.instance.GetAliveList(owner.faction.ReturnOtherSideFaction()))
            {
                unit.bufListDetail.AddKeywordBufThisRoundByCard(KeywordBuf.Binding, 5, owner);
                unit.bufListDetail.AddKeywordBufThisRoundByCard(KeywordBuf.Weak, 5, owner);
                unit.bufListDetail.AddKeywordBufThisRoundByCard(KeywordBuf.Disarm, 5, owner);
                unit.bufListDetail.AddKeywordBufThisRoundByCard(KeywordBuf.Vulnerable, 5, owner);
            }

            owner.personalEgoDetail.RemoveCard(card.card.GetID());
        }
    }
}