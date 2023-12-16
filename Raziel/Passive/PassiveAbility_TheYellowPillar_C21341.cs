using System.Collections.Generic;
using System.Linq;
using LOR_XML;
using UnityEngine;
using UtilLoader21341;
using UtilLoader21341.Util;

namespace TheColorsMod_C21341.Raziel.Passive
{
    public class PassiveAbility_TheYellowPillar_C21341 : PassiveAbilityBase
    {
        private readonly LorId _specialCard = new LorId(TheColorsModParameters.PackageId, 65);
        private readonly LorId _massAttackCard = new LorId(TheColorsModParameters.PackageId, 64);
        private readonly LorId _massAttackCardNpc = new LorId(TheColorsModParameters.PackageId, 907);
        private readonly List<AbnormalityCardDialog> _surviveDialog = new List<AbnormalityCardDialog>
        {
            new AbnormalityCardDialog
            {
                id = "Raziel",
                dialog = ModParameters.LocalizedItems[TheColorsModParameters.PackageId]?.EffectTexts
                    .FirstOrDefault(x => x.Key.Equals("RazielImmortal_Re21341")).Value?.Desc ?? ""
            }
        };

        public bool Survived;
        public override bool isInvincibleBp => true;

        public override void OnWaveStart()
        {
            UnitUtil.CheckSkinProjection(owner);
            owner.forceRetreat = true;
            owner.personalEgoDetail.AddCard(_specialCard);
            if (owner.faction == Faction.Player) owner.personalEgoDetail.AddCard(_massAttackCard);
            else owner.allyCardDetail.AddNewCardToDeck(_massAttackCardNpc);
        }

        public override bool BeforeTakeDamage(BattleUnitModel attacker, int dmg)
        {
            owner.SurviveCheck<BattleUnitBuf>(dmg, 0, ref Survived, 32, dialog: _surviveDialog, color: Color.yellow);
            return base.BeforeTakeDamage(attacker, dmg);
        }

        public override void OnRoundStartAfter()
        {
            owner.RecoverHP(3);
        }
        public override void OnBattleEnd()
        {
            owner.Revive(owner.MaxHp / 2);
        }
    }
}