using System.Linq;
using TheColorsMod_C21341.Mio.Buff;
using UtilLoader21341;
using UtilLoader21341.Util;

namespace TheColorsMod_C21341.Mio.Passive
{
    public class PassiveAbility_MysticEyesOfHeaven_C21341 : PassiveAbilityBase
    {
        public bool Activated;

        public override void OnWaveStart()
        {
            if (!UnitUtil.CheckOriginalPage(new LorId(TheColorsModParameters.PackageId, 10000001),
                    owner.Book.GetBookClassInfoId())) Active();
        }

        public void Active()
        {
            Activated = true;
            name = ModParameters.LocalizedItems[TheColorsModParameters.PackageId].EffectTexts
                .FirstOrDefault(x => x.Key.Equals("MysticEyesPassive_C21341")).Value.Name;
            desc = ModParameters.LocalizedItems[TheColorsModParameters.PackageId].EffectTexts
                .FirstOrDefault(x => x.Key.Equals("MysticEyesPassive_C21341")).Value.Desc;
            owner.AddBuffCustom<BattleUnitBuf_MysticEyesOfHeaven_C21341>(1, maxStack: 10);
        }

        public override void OnRoundStart()
        {
            if (!Activated) return;
            owner.AddBuffCustom<BattleUnitBuf_MysticEyesOfHeaven_C21341>(0, maxStack: 10);
        }
    }
}