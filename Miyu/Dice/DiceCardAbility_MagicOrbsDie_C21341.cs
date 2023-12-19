using TheColorsMod_C21341.Miyu.Buff;
using UtilLoader21341.Util;

namespace TheColorsMod_C21341.Miyu.Dice
{
    public class DiceCardAbility_MagicOrbsDie_C21341 : DiceCardAbilityBase
    {
        public override string[] Keywords
        {
            get
            {
                return new[]
                {
                    "MagicOrbsDesc_C21341"
                };
            }
        }

        public override void OnSucceedAttack(BattleUnitModel target)
        {
            target.OnAddBuffCustom<BattleUnitBuf_MagicOrbs_C21341>(0, maxStack: 0);
        }
    }
}