using System.Linq;
using LOR_DiceSystem;
using TheColorsMod_C21341.Kamiyo.Buff;
using TheColorsMod_C21341.Mio.Buff;
using UtilLoader21341;
using UtilLoader21341.Util;

namespace TheColorsMod_C21341.Kamiyo.Passive
{
    public class PassiveAbility_BattleHeat_C21341 : PassiveAbilityBase
    {
        public bool Activated;

        public override void OnRoundStart()
        {
            if (Activated) owner.OnAddBuff<BattleUnitBuf_BattleHeat_C21341>(0);
        }

        public override void OnWaveStart()
        {
            if (!UnitUtil.CheckOriginalPage(new LorId(TheColorsModParameters.PackageId, 10000002),
                    owner.Book.GetBookClassInfoId())) Active();
        }

        public override void BeforeRollDice(BattleDiceBehavior behavior)
        {
            if (!Activated) return;
            behavior.ApplyDiceStatBonus(new DiceStatBonus { min = 2 });
            if (behavior.Detail != BehaviourDetail.Evasion) return;
            behavior.ApplyDiceStatBonus(new DiceStatBonus { power = 1 });
        }

        public void Active()
        {
            Activated = true;
            name = ModParameters.LocalizedItems[TheColorsModParameters.PackageId].EffectTexts
                .FirstOrDefault(x => x.Key.Equals("BattleHeatPassive_C21341")).Value.Name;
            desc = ModParameters.LocalizedItems[TheColorsModParameters.PackageId].EffectTexts
                .FirstOrDefault(x => x.Key.Equals("BattleHeatPassive_C21341")).Value.Desc;
            owner.OnAddBuff<BattleUnitBuf_BattleHeat_C21341>(1);
        }
    }
}