using LOR_DiceSystem;
using Sound;

namespace TheColorsMod_C21341.Miyu.Buff
{
    public class BattleUnitBuf_Shield_C21341 : BattleUnitBuf
    {
        public AtkResist ResistBpValue;
        public AtkResist ResistHpValue;

        public BattleUnitBuf_Shield_C21341()
        {
            stack = 0;
        }

        public override int paramInBufDesc => 0;
        protected override string keywordId => "Shield_C21341";
        protected override string keywordIconId => "Shield_C21341";

        public override void Init(BattleUnitModel owner)
        {
            base.Init(owner);
            ResistHpValue = AtkResist.Endure;
            ResistBpValue = AtkResist.Endure;
        }

        public override AtkResist GetResistBP(AtkResist origin, BehaviourDetail detail)
        {
            return origin > ResistBpValue ? base.GetResistBP(origin, detail) : ResistBpValue;
        }

        public override AtkResist GetResistHP(AtkResist origin, BehaviourDetail detail)
        {
            return origin > ResistHpValue ? base.GetResistBP(origin, detail) : ResistHpValue;
        }

        public override int GetDamageReduction(BattleDiceBehavior behavior)
        {
            _owner.battleCardResultLog.SetTakeDamagedEvent(delegate
            {
                SingletonBehavior<DiceEffectManager>.Instance.CreateBehaviourEffect("MiyuMagic2Self_C21341", 1f,
                    _owner.view, _owner.view);
                SoundEffectPlayer.PlaySound("Creature/Greed_MakeDiamond");
            });
            return base.GetDamageReduction(behavior);
        }

        public override void OnRoundEndTheLast()
        {
            _owner.bufListDetail.RemoveBuf(this);
        }
    }
}