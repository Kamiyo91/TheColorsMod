using System.Linq;
using TheColorsMod_C21341.Wonderland.Buff;
using TheColorsMod_C21341.Wonderland.Passive;
using UtilLoader21341;
using UtilLoader21341.Util;

namespace TheColorsMod_C21341.CustomFloor.Passive
{
    public class PassiveAbility_CloneEmotion_C21341 : PassiveAbilityBase
    {
        public override void OnRoundEndTheLast()
        {
            owner.Die();
        }

        public override void OnWaveStart()
        {
            var passive = owner.passiveDetail.AddPassive(new PassiveAbility_CloneHidedPassive_C21341());
            passive.OnWaveStart();
            owner.OnAddBuff<BattleUnitBuf_Clone_C21341>(0);
        }

        public void SetNameAndDesc()
        {
            rare = Rarity.Rare;
            name = ModParameters.LocalizedItems[TheColorsModParameters.PackageId].EffectTexts
                .FirstOrDefault(x => x.Key.Equals("CloneEmotionPassive_C21341")).Value.Name;
            desc = ModParameters.LocalizedItems[TheColorsModParameters.PackageId].EffectTexts
                .FirstOrDefault(x => x.Key.Equals("CloneEmotionPassive_C21341")).Value.Desc;
        }
    }
}