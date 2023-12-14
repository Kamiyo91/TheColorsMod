using Sound;
using UnityEngine;

namespace TheColorsMod_C21341.Kamiyo.Buff
{
    public class BattleUnitBuf_ShadowBuff_C21341 : BattleUnitBuf
    {
        public BattleUnitBuf_ShadowBuff_C21341()
        {
            stack = 0;
        }

        public override int paramInBufDesc => 0;
        public override bool isAssimilation => true;
        protected override string keywordId => "ForgottenAura_C21341";
        protected override string keywordIconId => "Shadow_C21341";

        public override void Init(BattleUnitModel owner)
        {
            base.Init(owner);
            owner.cardSlotDetail.RecoverPlayPoint(owner.MaxPlayPoint);
            PlayChangingEffect();
        }

        private void PlayChangingEffect()
        {
            var aura = SingletonBehavior<DiceEffectManager>.Instance.CreateNewFXCreatureEffect(
                "2_Y/FX_IllusionCard_2_Y_Charge", 1f, _owner.view, _owner.view);
            foreach (var particle in aura.gameObject.GetComponentsInChildren<ParticleSystem>())
            {
                if (particle.gameObject.name.Contains("Burn"))
                    particle.gameObject.AddComponent<AuraColor>();
                if (!particle.gameObject.name.Equals("Main") && !particle.gameObject.name.Contains("Charge") &&
                    !particle.gameObject.name.Contains("Scaner_holo_distortion")) continue;
                particle.gameObject.SetActive(false);
            }

            SingletonBehavior<SoundEffectManager>.Instance.PlayClip("Battle/Kali_Change");
        }

        public override void BeforeRollDice(BattleDiceBehavior behavior)
        {
            behavior.ApplyDiceStatBonus(new DiceStatBonus { power = 1 });
        }
    }
}