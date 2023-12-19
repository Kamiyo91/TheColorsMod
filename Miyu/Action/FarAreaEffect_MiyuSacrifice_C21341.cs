using UnityEngine;

namespace TheColorsMod_C21341.Miyu.Action
{
    public class FarAreaEffect_MiyuSacrifice_C21341 : FarAreaEffect
    {
        private float _time;

        public override void Init(BattleUnitModel self, params object[] args)
        {
            base.Init(self, args);
            var gameObject = Util.LoadPrefab("Battle/SpecialEffect/OneBadManyGoodEffect", transform);
            if (gameObject != null)
                gameObject.AddComponent<AutoDestruct>().time = 4f;
        }

        protected override void Update()
        {
            if (!isRunning) return;
            _time += Time.deltaTime;
            if (!(_time > 3f)) return;
            Destroy(gameObject);
        }
    }
}