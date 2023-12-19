using TheColorsMod_C21341.Miyu.Buff;
using UtilLoader21341.Util;

namespace TheColorsMod_C21341.Miyu.Passive
{
    public class PassiveAbility_ManaRegeneration_C21341 : PassiveAbilityBase
    {
        public override void OnRoundEndTheLast()
        {
            owner.cardSlotDetail.RecoverPlayPoint(1);
            if (owner.allyCardDetail.IsHighlander() &&
                owner.GetActivePassive<PassiveAbility_ThePinkIdol_C21341>() != null)
                owner.OnAddBuff<BattleUnitBuf_Mana_C21341>(1);
        }
    }
}