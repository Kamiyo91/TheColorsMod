using System.Linq;
using TheColorsMod_C21341.Reno.Buff;
using UtilLoader21341;
using UtilLoader21341.Util;

namespace TheColorsMod_C21341.Reno.Passive
{
    public class PassiveAbility_Corrosion_C21341 : PassiveAbilityBase
    {
        public bool Activated;
        public int Stack = 1;

        public override void OnRoundStartAfter()
        {
            if (!Activated) return;
            foreach (var unit in BattleObjectManager.instance.GetAliveList(owner.faction.ReturnOtherSideFaction()))
                unit.AddBuffCustom<BattleUnitBuf_Corrosion_C21341>(Stack);
        }

        public override void OnSucceedAttack(BattleDiceBehavior behavior)
        {
            if (Activated) behavior.card.target?.AddBuffCustom<BattleUnitBuf_Corrosion_C21341>(Stack);
        }

        public override void OnRoundEndTheLast()
        {
            Stack = 1;
        }

        public override void OnWaveStart()
        {
            if (!UnitUtil.CheckOriginalPage(new LorId(TheColorsModParameters.PackageId, 10000005),
                    owner.Book.GetBookClassInfoId())) Active();
        }

        public void Active()
        {
            Activated = true;
            name = ModParameters.LocalizedItems[TheColorsModParameters.PackageId].EffectTexts
                .FirstOrDefault(x => x.Key.Equals("CorrosionPassive_C21341")).Value.Name;
            desc = ModParameters.LocalizedItems[TheColorsModParameters.PackageId].EffectTexts
                .FirstOrDefault(x => x.Key.Equals("CorrosionPassive_C21341")).Value.Desc;
        }
    }
}