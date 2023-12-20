using TheColorsMod_C21341.Miyu.Buff;
using UtilLoader21341.Util;

namespace TheColorsMod_C21341.Miyu.Card
{
    public class DiceCardSelfAbility_ThunderBlade_C21341 : DiceCardSelfAbilityBase
    {
        public override bool OnChooseCard(BattleUnitModel owner)
        {
            return owner.GetActiveBuff<BattleUnitBuf_Mana_C21341>()?.stack > 99 && !owner.cardSlotDetail.cardAry.Exists(
                x =>
                    x?.card?.GetID() == new LorId(TheColorsModParameters.PackageId, 69));
            ;
        }


        public override void OnUseCard()
        {
            owner.OnAddBuff<BattleUnitBuf_Mana_C21341>(-100);
            if (owner.GetActiveBuff<BattleUnitBuf_Mana_C21341>()?.stack < 1)
                owner.GetActiveBuff<BattleUnitBuf_ManaShield_C21341>()?.RemoveBuff();
            if (card?.target?.currentDiceAction?.cardBehaviorQueue.Count > 0)
                card?.target?.currentDiceAction?.DestroyDice(DiceMatch.AllDice);
        }
    }
}