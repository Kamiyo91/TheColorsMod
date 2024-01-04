using System.Collections.Generic;
using System.Linq;
using LOR_XML;
using Sound;
using TheColorsMod_C21341.Sae.Buff;
using UnityEngine;
using UtilLoader21341;
using UtilLoader21341.Util;

namespace TheColorsMod_C21341.Sae.Passive
{
    public class PassiveAbility_RedRage_C21341 : PassiveAbilityBase
    {
        private const string OriginalSkinName = "Sae_C21341";
        private const string EgoSkinName = "SaeRage_C21341";

        private readonly List<AbnormalityCardDialog> _egoDialog = new List<AbnormalityCardDialog>
        {
            new AbnormalityCardDialog
            {
                id = "Sae",
                dialog = ModParameters.LocalizedItems[TheColorsModParameters.PackageId]?.EffectTexts
                    .FirstOrDefault(x => x.Key.Equals("SaeRedRageActive1_C21341")).Value?.Desc ?? ""
            }
        };

        private bool _activeRedRage;
        private BattleUnitBuf_RedRage_C21341 _buff;
        private bool _redRage;
        public bool CustomSkin;
        public bool EgoActive;
        public override bool isImmortal => true;

        public override void OnWaveStart()
        {
            if (UnitUtil.CheckSkinProjection(owner) ||
                !UnitUtil.CheckOriginalPage(new LorId(TheColorsModParameters.PackageId, 10000003),
                    owner.Book.GetBookClassInfoId()))
                CustomSkin = true;
        }

        public override void Init(BattleUnitModel self)
        {
            base.Init(self);
            _buff = self.AddBuffCustom<BattleUnitBuf_RedRage_C21341>(1) as BattleUnitBuf_RedRage_C21341;
        }

        public override void OnRoundStart()
        {
            _buff = owner.AddBuffCustom<BattleUnitBuf_RedRage_C21341>(0) as BattleUnitBuf_RedRage_C21341;
        }

        public override bool BeforeTakeDamage(BattleUnitModel attacker, int dmg)
        {
            if (_activeRedRage) return base.BeforeTakeDamage(attacker, dmg);
            if (owner.hp - dmg < 1) _activeRedRage = true;
            return base.BeforeTakeDamage(attacker, dmg);
        }

        public override void OnRoundStartAfter()
        {
            if (!_activeRedRage || _redRage) return;
            _buff.Changed = true;
            _buff.AddBufCustom(-99);
            _redRage = true;
            owner.EgoActive(ref EgoActive, CustomSkin ? "" : EgoSkinName, true, dialog: _egoDialog, color: Color.red);
            SoundEffectPlayer.PlaySound("Creature/Angry_Meet");
        }

        public override void OnRoundEndTheLast()
        {
            if (!_redRage) return;
            _buff.Changed = false;
            _activeRedRage = false;
            _redRage = false;
            owner.Die();
        }

        public override void OnBattleEnd()
        {
            if (!CustomSkin)
                owner.UnitData.unitData.bookItem.ClassInfo.CharacterSkin = new List<string> { OriginalSkinName };
        }

        public override void BeforeRollDice(BattleDiceBehavior behavior)
        {
            if (_redRage) behavior.ApplyDiceStatBonus(new DiceStatBonus { power = 10 });
        }
    }
}