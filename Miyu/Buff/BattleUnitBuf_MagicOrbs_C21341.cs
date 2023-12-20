using Sound;

namespace TheColorsMod_C21341.Miyu.Buff
{
    public class BattleUnitBuf_MagicOrbs_C21341 : BattleUnitBuf
    {
        public BattleUnitBuf_MagicOrbs_C21341()
        {
            stack = 0;
        }

        public override int paramInBufDesc => 0;
        protected override string keywordId => "MagicOrbs_C21341";
        protected override string keywordIconId => "MagicOrbs_C21341";

        public override void BeforeTakeDamage(BattleUnitModel attacker, int dmg)
        {
            if (attacker == null || (attacker.Book.GetBookClassInfoId().packageId == TheColorsModParameters.PackageId &&
                                     attacker.Book.GetBookClassInfoId().id == 10000007)) return;
            attacker.allyCardDetail.DrawCards(1);
            attacker.cardSlotDetail.RecoverPlayPoint(1);
            _owner.battleCardResultLog.SetTakeDamagedEvent(delegate
            {
                SingletonBehavior<DiceEffectManager>.Instance.CreateBehaviourEffect("MiyuMagic6Self_C21341", 1f,
                    _owner.view, _owner.view);
                SoundEffectPlayer.PlaySound("Creature/Greed_MakeDiamond");
            });
            _owner.bufListDetail.RemoveBuf(this);
        }

        public override void OnRoundEndTheLast()
        {
            _owner.bufListDetail.RemoveBuf(this);
        }
    }
}