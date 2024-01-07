using TheColorsMod_C21341.Wonderland.Buff;
using UtilLoader21341.Util;

namespace TheColorsMod_C21341.Wonderland.Passive
{
    public class PassiveAbility_TimeRecession_C21341 : PassiveAbilityBase
    {
        public override void Init(BattleUnitModel self)
        {
            base.Init(self);
            self.AddBuffCustom<BattleUnitBuf_TimeRecession_C21341>(1, maxStack: 5);
        }

        public override void OnRoundStart()
        {
            owner.AddBuffCustom<BattleUnitBuf_TimeRecession_C21341>(0, maxStack: 5);
        }

        public override void OnStartBattle()
        {
            owner.ReadyCounterCard(35, TheColorsModParameters.PackageId);
        }
    }
}