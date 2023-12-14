using TheColorsMod_C21341.Sae.Buff;
using UtilLoader21341.Util;

namespace TheColorsMod_C21341.Sae.Passive
{
    public class PassiveAbility_LoneWarrior_C21341 : PassiveAbilityBase
    {
        public override void OnWaveStart()
        {
            if (owner.passiveDetail.PassiveList.Find(x => x is PassiveAbility_230008) is PassiveAbility_230008
                passiveLone)
                owner.passiveDetail.DestroyPassive(passiveLone);
        }

        public override void OnRoundEnd()
        {
            if (UnitUtil.SupportCharCheck(owner) > 1) return;
            if (owner.bufListDetail.HasBuf<BattleUnitBuf_AtkStance_C21341>())
                owner.bufListDetail.AddKeywordBufByEtc(KeywordBuf.Strength, 3);
            else if (owner.bufListDetail.HasBuf<BattleUnitBuf_DefStance_C21341>())
                owner.bufListDetail.AddKeywordBufByEtc(KeywordBuf.Endurance, 3);
        }
    }
}