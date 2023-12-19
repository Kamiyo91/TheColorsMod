using Battle.DiceAttackEffect;
using UnityEngine;
using UtilLoader21341.Util;

namespace TheColorsMod_C21341.Miyu.Effect
{
    public class DiceAttackEffect_MiyuMagic9_C21341 : DiceAttackEffect
    {
        private float _duration;

        public override void Initialize(BattleUnitView self, BattleUnitView target, float destroyTime)
        {
            base.Initialize(self, target, destroyTime);
            _duration = destroyTime;
            DiceEffectUtil.InitializeEffect(TheColorsModParameters.Path, 0.50f, 0.30f, false, this, self, target);
        }


        protected override void Update()
        {
            base.Update();
            _duration -= Time.deltaTime;
            spr.color = new Color(1f, 1f, 1f, _duration * 2f);
        }


        public override void SetScale(float scaleFactor)
        {
            base.SetScale(DiceEffectUtil.CalculateScale(false, scaleFactor, 1f));
        }
    }
}