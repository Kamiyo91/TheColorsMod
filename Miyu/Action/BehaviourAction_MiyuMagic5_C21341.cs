using UtilLoader21341;
using UtilLoader21341.Util;

namespace TheColorsMod_C21341.Miyu.Action
{
    public class BehaviourAction_MiyuMagic5_C21341 : BehaviourActionBase
    {
        public override FarAreaEffect SetFarAreaAtkEffect(BattleUnitModel self)
        {
            var massAttackEffect = this.SetFarAreaAtkEffect(new FarAreaMassAttackEffectParameters(
                TheColorsModParameters.PackageId, ActionDetail.S6, "Rudolph_Special_Atk",
                "MiyuMagic5_C21341", isBaseGameAudio: true, zoom: false,
                characterMove: false, followUnits: false), self);
            return massAttackEffect;
        }
    }
}