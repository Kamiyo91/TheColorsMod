using Sound;
using UtilLoader21341.Util;

namespace TheColorsMod_C21341.Zero.Buff
{
    public class BattleUnitBuf_BlueBurn_C21341 : BattleUnitBuf
    {
        public override KeywordBuf bufType => KeywordBuf.Burn;
        public override BufPositiveType positiveType => BufPositiveType.Negative;
        protected override string keywordId => "Burn";
        protected override string keywordIconId => "BlueFlame_C21341";

        public override void OnRoundEnd()
        {
            if (!_owner.IsImmune(bufType))
            {
                _owner.TakeDamage(stack * 2, DamageType.Buf, null, bufType);
                PrintEffect();
                if (_owner.bufListDetail.GetActivatedBuf(KeywordBuf.BurnBreak) != null)
                    _owner.TakeBreakDamage(stack * 2, DamageType.Buf, null, AtkResist.Normal, bufType);
                if (_owner.faction == Faction.Enemy && _owner.IsDead())
                    Singleton<StageController>.Instance.GetStageModel().AddBurnKillCount();
            }

            if (_owner.GetActiveBuff<BattleUnitBuf_BlueFlameEgo_C21341>() != null) return;
            stack = stack * 2 / 3;
            if (stack <= 0)
                _owner.bufListDetail.RemoveBuf(this);
        }

        public void AddBuffCustom(int addedStack)
        {
            this.OnAddBufCustom(addedStack, true, 0, 999);
        }

        private void PrintEffect()
        {
            SingletonBehavior<DiceEffectManager>.Instance.CreateCreatureEffect("6/BigBadWolf_Emotion_Aura", 1f,
                _owner.view, _owner.view, 2);
            SoundEffectPlayer.PlaySound("Buf/Effect_Burn");
        }
    }
}