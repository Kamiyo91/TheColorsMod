namespace TheColorsMod_C21341.Miyu.Card
{
    public class DiceCardSelfAbility_StrengthenFire_C21341 : DiceCardSelfAbility_MiyuCommonCard_C21341
    {
        public override void OnUseCard()
        {
            owner.bufListDetail.AddKeywordBufThisRoundByCard(KeywordBuf.Strength, 2);
            owner.bufListDetail.AddKeywordBufThisRoundByCard(KeywordBuf.Endurance, 2);
            var target = card.target;
            if (owner == target) return;
            target.bufListDetail.AddKeywordBufThisRoundByCard(KeywordBuf.Strength, 2);
            target.bufListDetail.AddKeywordBufThisRoundByCard(KeywordBuf.Endurance, 2);
        }
    }
}