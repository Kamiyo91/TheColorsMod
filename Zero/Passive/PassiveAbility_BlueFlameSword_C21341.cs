namespace TheColorsMod_C21341.Zero.Passive
{
    public class PassiveAbility_BlueFlameSword_C21341 : PassiveAbilityBase
    {
        public override void OnSucceedAttack(BattleDiceBehavior behavior)
        {
            owner.bufListDetail.AddKeywordBufByEtc(KeywordBuf.Burn, 1, owner);
        }
    }
}