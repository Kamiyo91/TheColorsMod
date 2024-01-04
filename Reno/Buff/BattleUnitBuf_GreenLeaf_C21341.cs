using Sound;
using UnityEngine;

namespace TheColorsMod_C21341.Reno.Buff
{
    public class BattleUnitBuf_GreenLeaf_C21341 : BattleUnitBuf
    {
        private GameObject _aura;

        public BattleUnitBuf_GreenLeaf_C21341()
        {
            stack = 0;
        }

        protected override string keywordId => "GreenLeaf_C21341";
        protected override string keywordIconId => "GreenLeaf_C21341";
        public override int paramInBufDesc => 0;
        public override bool isAssimilation => true;

        public override void Init(BattleUnitModel owner)
        {
            base.Init(owner);
            CreateAura();
        }

        public override int GetCardCostAdder(BattleDiceCardModel card)
        {
            return card.GetOriginCost() < 3 ? -1 : base.GetCardCostAdder(card);
        }

        public override void BeforeRollDice(BattleDiceBehavior behavior)
        {
            behavior.ApplyDiceStatBonus(new DiceStatBonus { power = 1 });
        }

        private void CreateAura()
        {
            if (_aura != null) return;
            var @object = Resources.Load("Prefabs/Battle/SpecialEffect/IndexRelease_Aura");
            if (@object != null)
            {
                var gameObject = Object.Instantiate(@object) as GameObject;
                if (gameObject != null)
                {
                    gameObject.transform.parent = _owner.view.charAppearance.transform;
                    gameObject.transform.localPosition = Vector3.zero;
                    gameObject.transform.localRotation = Quaternion.identity;
                    gameObject.transform.localScale = Vector3.one;
                    var component = gameObject.GetComponent<IndexReleaseAura>();
                    component?.Init(_owner.view);
                    _aura = gameObject;
                }

                if (_aura != null)
                    foreach (var particle in _aura.GetComponentsInChildren<ParticleSystem>())
                    {
                        var main = particle.main;
                        main.startColor = new Color(0, 1, 0, 1);
                    }
            }

            SingletonBehavior<SoundEffectManager>.Instance.PlayClip("Buf/Effect_Index_Unlock");
        }
    }
}