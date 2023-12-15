using TheColorsMod_C21341.Wonderland.Buff;
using TheColorsMod_C21341.Wonderland.Card;
using UtilLoader21341.Util;

namespace TheColorsMod_C21341.Wonderland.Passive
{
    public class PassiveAbility_Wonderland_C21341 : PassiveAbilityBase
    {
        private int _npcCount;

        public override void OnWaveStart()
        {
            owner.personalEgoDetail.AddCard(new LorId(TheColorsModParameters.PackageId, 27));
            if (owner.faction == Faction.Enemy)
                owner.allyCardDetail.AddNewCardToDeck(new LorId(TheColorsModParameters.PackageId, 904));
            else owner.personalEgoDetail.AddCard(new LorId(TheColorsModParameters.PackageId, 36));
            owner.OnAddBuff<BattleUnitBuf_SmokeBomb_C21341>(1);
        }

        public override void OnRoundStart()
        {
            owner.OnAddBuff<BattleUnitBuf_SmokeBomb_C21341>(0);
            HandleSpecialCards();
            if (owner.faction == Faction.Player) return;
            _npcCount++;
            if (_npcCount < TheColorsModParameters.WonderlandCloneCount) return;
            _npcCount = 0;
            DiceCardSelfAbility_SummonClone_C21341.Activate(owner);
        }

        public override void OnRoundStartAfter()
        {
            if (owner.faction == Faction.Player) return;
            var buff = owner.GetActiveBuff<BattleUnitBuf_SmokeBomb_C21341>();
            if (buff == null || buff.stack < 10) return;
            buff.OnAddBuf(-99);
            owner.OnAddBuff<BattleUnitBuf_SmokeScreen_C21341>(0);
        }

        public void HandleSpecialCards()
        {
            owner.personalEgoDetail.RemoveCard(new LorId(TheColorsModParameters.PackageId, 28));
            owner.personalEgoDetail.RemoveCard(new LorId(TheColorsModParameters.PackageId, 29));
            owner.personalEgoDetail.AddCard(new LorId(TheColorsModParameters.PackageId, 28));
            owner.personalEgoDetail.AddCard(new LorId(TheColorsModParameters.PackageId, 29));
        }
    }
}