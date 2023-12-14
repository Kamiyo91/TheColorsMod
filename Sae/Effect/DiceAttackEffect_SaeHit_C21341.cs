using Battle.DiceAttackEffect;
using UnityEngine;
using UtilLoader21341.Util;

namespace TheColorsMod_C21341.Sae.Effect
{
    public class DiceAttackEffect_SaeHit_C21341 : DiceAttackEffect
    {
        private const float Scale = 2.15f;
        private float _duration;

        public override void Initialize(BattleUnitView self, BattleUnitView target, float destroyTime)
        {
            base.Initialize(self, target, destroyTime);
            _duration = _destroyTime;
            DiceEffectUtil.InitializeEffect(TheColorsModParameters.Path, 0.54f, 0.35f, true, this, self, target);
        }

        public override void SetScale(float scaleFactor)
        {
            base.SetScale(DiceEffectUtil.CalculateScale(true, scaleFactor, Scale));
        }

        protected override void Update()
        {
            base.Update();
            _duration -= Time.deltaTime;
            spr.color = new Color(1f, 1f, 1f, _duration * 2f);
        }
    }
}