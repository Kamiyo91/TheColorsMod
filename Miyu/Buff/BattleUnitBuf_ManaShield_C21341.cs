﻿using Sound;
using UnityEngine;
using UtilLoader21341.Util;

namespace TheColorsMod_C21341.Miyu.Buff
{
    public class BattleUnitBuf_ManaShield_C21341 : BattleUnitBuf
    {
        public bool ManaShieldActive = true;

        public BattleUnitBuf_ManaShield_C21341()
        {
            stack = 0;
        }

        public override int paramInBufDesc => 0;
        protected override string keywordId => "ManaShieldBuff_C21341";
        protected override string keywordIconId => "ManaShield_C21341";

        public override void BeforeTakeDamage(BattleUnitModel attacker, int dmg)
        {
            var manaBuff = _owner.GetActiveBuff<BattleUnitBuf_Mana_C21341>();
            if (manaBuff == null || dmg * 2 > manaBuff.stack) RemoveBuff();
            ManaShieldActive = true;
            _owner.battleCardResultLog.SetTakeDamagedEvent(delegate
            {
                SingletonBehavior<AttackEffectManager>.Instance.CreateDamagedTextEffectCustom(dmg * 2,
                    _owner, AtkResist.Normal, Color.blue, "", attacker,
                    ArtUtil.GetSpriteFromArtworks(TheColorsModParameters.PackageId, "ManaShield_C21341"));
                SingletonBehavior<DiceEffectManager>.Instance.CreateBehaviourEffect("MiyuMagic13Self_C21341", 1f,
                    _owner.view, _owner.view);
                SoundEffectPlayer.PlaySound("Creature/Greed_MakeDiamond");
            });
            manaBuff?.OnAddBuf(-dmg * 2);
        }

        public override void OnRoundStartAfter()
        {
            if (_owner.IsBreakLifeZero()) RemoveBuff();
        }

        public override void OnBreakState()
        {
            RemoveBuff();
        }

        public override bool IsInvincibleHp(BattleUnitModel attacker)
        {
            return ManaShieldActive;
        }

        public void RemoveBuff()
        {
            ManaShieldActive = false;
            _owner.bufListDetail.RemoveBuf(this);
        }
    }
}