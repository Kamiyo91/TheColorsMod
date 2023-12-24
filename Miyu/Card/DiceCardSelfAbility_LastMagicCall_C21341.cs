using UtilLoader21341.Util;

namespace TheColorsMod_C21341.Miyu.Card
{
    public class DiceCardSelfAbility_LastMagicCall_C21341 : DiceCardSelfAbilityBase
    {
        private bool _motionChanged;

        public override void OnUseCard()
        {
            foreach (var unit in BattleObjectManager.instance.GetAliveList(owner.faction.ReturnOtherSideFaction()))
            {
                unit.bufListDetail.AddKeywordBufThisRoundByCard(KeywordBuf.Binding, 5, owner);
                unit.bufListDetail.AddKeywordBufThisRoundByCard(KeywordBuf.Weak, 5, owner);
                unit.bufListDetail.AddKeywordBufThisRoundByCard(KeywordBuf.Disarm, 5, owner);
                unit.bufListDetail.AddKeywordBufThisRoundByCard(KeywordBuf.Vulnerable, 5, owner);
            }
        }

        public override void OnEndAreaAttack()
        {
            if (!_motionChanged) return;
            _motionChanged = false;
            owner.view.charAppearance.ChangeMotion(ActionDetail.Default);
            owner.Die();
        }

        public override void OnApplyCard()
        {
            if (!string.IsNullOrEmpty(owner.UnitData.unitData.workshopSkin) ||
                owner.UnitData.unitData.bookItem != owner.UnitData.unitData.CustomBookItem) return;
            _motionChanged = true;
            owner.view.charAppearance.ChangeMotion(ActionDetail.S3);
        }

        public override void OnReleaseCard()
        {
            _motionChanged = false;
            owner.view.charAppearance.ChangeMotion(ActionDetail.Default);
        }
    }
}