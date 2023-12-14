using Battle.CreatureEffect;
using Sound;
using UnityEngine;
using UtilLoader21341.Util;

namespace TheColorsMod_C21341.Sae.Buff
{
    public class BattleUnitBuf_RedRage_C21341 : BattleUnitBuf
    {
        private const string Path = "6/RedHood_Emotion_Aura";
        private CreatureEffect _aura;
        public bool Changed = false;
        public override bool isAssimilation => Changed;
        protected override string keywordId => Changed ? "RedAura_C21341" : "RedRage_C21341";
        protected override string keywordIconId => "RedHood_Rage";

        public override void OnRoundStartAfter()
        {
            if (Changed && _aura == null) PlayChangingEffect(_owner);
        }

        private void PlayChangingEffect(BattleUnitModel owner)
        {
            if (_aura == null)
                _aura = SingletonBehavior<DiceEffectManager>.Instance.CreateCreatureEffect(Path, 1f, owner.view,
                    owner.view);
            var original = Resources.Load("Prefabs/Battle/SpecialEffect/RedMistRelease_ActivateParticle");
            if (original != null)
            {
                var gameObject = Object.Instantiate(original) as GameObject;
                gameObject.transform.parent = owner.view.charAppearance.transform;
                gameObject.transform.localPosition = Vector3.zero;
                gameObject.transform.localRotation = Quaternion.identity;
                gameObject.transform.localScale = Vector3.one;
            }

            SingletonBehavior<SoundEffectManager>.Instance.PlayClip("Battle/Kali_Change");
        }

        public override void BeforeTakeDamage(BattleUnitModel attacker, int dmg)
        {
            if (Changed) return;
            if (attacker == null || dmg <= 0) return;
            OnAddBuf(1);
        }

        public override void BeforeRollDice(BattleDiceBehavior behavior)
        {
            if (stack < 5 || Changed) return;
            OnAddBuf(-99);
            behavior.ApplyDiceStatBonus(new DiceStatBonus { power = 5 });
        }

        public override void OnAddBuf(int addedStack)
        {
            this.OnAddBufCustom(addedStack, maxStack: 5);
        }

        public override int GetCardCostAdder(BattleDiceCardModel card)
        {
            if (Changed) return -99;
            return base.GetCardCostAdder(card);
        }
    }
}