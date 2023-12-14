using UtilLoader21341.Extensions;

namespace TheColorsMod_C21341.Mio.Card
{
    public class DiceCardSelfAbility_EnergyRelease_C21341 : DiceCardSelfAbilityBase
    {
        public override void OnUseCard()
        {
            owner.bufListDetail.AddKeywordBufByCard(KeywordBuf.Strength, 1, owner);
        }

        public override void OnStartBattle()
        {
            owner.bufListDetail.RemoveBufAll(KeywordBuf.Binding);
            owner.bufListDetail.AddBuf(
                new BattleUnitBuf_ImmunityToOneStatus_DLL21341(immunityType: KeywordBuf.Binding));
        }
    }
}