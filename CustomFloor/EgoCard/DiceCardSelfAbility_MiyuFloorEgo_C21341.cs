using UtilLoader21341.Util;

namespace TheColorsMod_C21341.CustomFloor.EgoCard
{
    public class DiceCardSelfAbility_MiyuFloorEgo_C21341 : DiceCardSelfAbility_EgoOneScene_C21341
    {
        public override string SkinName => "Miyu_C21341";

        public override void OnUseCard()
        {
            base.OnUseCard();
            foreach (var unit in BattleObjectManager.instance.GetAliveList(owner.faction.ReturnOtherSideFaction()))
                unit.bufListDetail.AddKeywordBufByEtc(KeywordBuf.Binding, 5);
        }
    }
}