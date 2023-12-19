using Battle.DiceAttackEffect;
using UnityEngine;
using UtilLoader21341.Util;

namespace TheColorsMod_C21341.Miyu.Effect
{
    public class DiceAttackEffect_MiyuMagic5_C21341 : DiceAttackEffect
    {
        private float _duration;

        public override void Initialize(BattleUnitView self, BattleUnitView target, float destroyTime)
        {
            _duration = 2f;
            this.InitializeMassEffect(TheColorsModParameters.Path, 0.3f, 0.3f, -55, 0.5f, _destroyTime, self,
                _duration);
        }

        public override void SetScale(float scaleFactor)
        {
            base.SetScale(DiceEffectUtil.CalculateScale(false, scaleFactor, 10f));
        }

        protected override void Update()
        {
            base.Update();
            _duration -= Time.deltaTime;
            spr.color = new Color(1f, 1f, 1f, _duration * 2f);
        }
    }
}