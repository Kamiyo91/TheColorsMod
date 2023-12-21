using Sound;
using UtilLoader21341.Util;

namespace TheColorsMod_C21341.Zero.Buff
{
    public class BattleUnitBuf_BlueFlameEgo_C21341 : BattleUnitBuf
    {
        private BattleUnitBuf_BlueBurn_C21341 _buff;

        public BattleUnitBuf_BlueFlameEgo_C21341()
        {
            stack = 0;
        }

        public override bool isAssimilation => true;
        public override int paramInBufDesc => 0;
        protected override string keywordId => "BlueFlameEgo_C21341";
        protected override string keywordIconId => "BlueFlameEgo_C21341";

        public override void Init(BattleUnitModel owner)
        {
            base.Init(owner);
            InitAuraAndPlaySound();
            _buff = owner.AddBuff<BattleUnitBuf_BlueBurn_C21341>(0) as BattleUnitBuf_BlueBurn_C21341;
        }

        public override void OnRoundStart()
        {
            _buff = _owner.GetActiveBuff<BattleUnitBuf_BlueBurn_C21341>();
        }

        public override void BeforeRollDice(BattleDiceBehavior behavior)
        {
            behavior.ApplyDiceStatBonus(new DiceStatBonus
            {
                power = 1
            });
        }

        public override void OnRoundStartAfter()
        {
            _buff?.OnAddBuf(2);
        }

        private void InitAuraAndPlaySound()
        {
            SingletonBehavior<SoundEffectManager>.Instance.PlayClip("Battle/Kali_Change");
            EffectUtil.MakeEffect(_owner, "6/BigBadWolf_Emotion_Aura", 1f, _owner);
        }

        public override int GetDamageReductionRate()
        {
            return _buff?.stack ?? base.GetDamageReductionRate();
        }

        public override int GetBreakDamageReductionRate()
        {
            return _buff?.stack ?? base.GetBreakDamageReductionRate();
        }
    }
}