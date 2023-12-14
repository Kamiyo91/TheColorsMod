using TheColorsMod_C21341.Kamiyo.Buff;
using UtilLoader21341.Util;

namespace TheColorsMod_C21341.Kamiyo.Card
{
    public class DiceCardSelfAbility_BlackFlameSlash_C21341 : DiceCardSelfAbilityBase
    {
        public bool Active;
        public override string[] Keywords => new[] { "Endurance", "Strength" };

        public override bool OnChooseCard(BattleUnitModel owner)
        {
            return owner.bufListDetail.HasBuf<BattleUnitBuf_ShadowBuff_C21341>();
        }

        public override void OnStartBattle()
        {
            var buff = owner.GetActiveBuff<BattleUnitBuf_BattleHeat_C21341>();
            if (buff == null) return;
            Active = buff.stack > 4;
            if (!Active) return;
            owner.TakeDamage(5);
            owner.bufListDetail.AddKeywordBufThisRoundByEtc(KeywordBuf.Strength, 2, owner);
            owner.bufListDetail.AddKeywordBufThisRoundByEtc(KeywordBuf.Endurance, 2, owner);
        }
    }
}