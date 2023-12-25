using System.Linq;
using Sound;
using TheColorsMod_C21341.CustomFloor;
using TheColorsMod_C21341.Sae.Buff;
using UtilLoader21341.Util;

namespace TheColorsMod_C21341.Sae
{
    public static class StanceUtil
    {
        public static void RemoveStanceBuffs(BattleUnitModel owner)
        {
            owner.bufListDetail.RemoveBufAll(typeof(BattleUnitBuf_AtkStance_C21341));
            owner.bufListDetail.RemoveBufAll(typeof(BattleUnitBuf_DefStance_C21341));
        }

        public static void RemoveCards(BattleUnitModel owner)
        {
            owner.personalEgoDetail.RemoveCard(new LorId(TheColorsModParameters.PackageId, 8));
            owner.personalEgoDetail.RemoveCard(new LorId(TheColorsModParameters.PackageId, 9));
        }

        public static void AddCards(BattleUnitModel owner)
        {
            owner.personalEgoDetail.AddCard(new LorId(TheColorsModParameters.PackageId, 8));
            owner.personalEgoDetail.AddCard(new LorId(TheColorsModParameters.PackageId, 9));
        }

        public static void ChangeStance<T>(this BattleUnitModel owner, string stanceType, int deckIndex)
            where T : BattleUnitBuf, new()
        {
            ChangeAnimation(owner);
            owner.OnAddBuff<T>(0);
            if (stanceType.Equals("Def"))
            {
                owner.view.charAppearance.SetAltMotion(ActionDetail.Standing, ActionDetail.Guard);
                owner.view.charAppearance.SetAltMotion(ActionDetail.Default, ActionDetail.Guard);
            }
            else
            {
                owner.view.charAppearance.RemoveAltMotion(ActionDetail.Standing);
                owner.view.charAppearance.RemoveAltMotion(ActionDetail.Default);
            }

            //if (addBuf != KeywordBuf.None && removeBuf != KeywordBuf.None &&
            //    owner.bufListDetail.GetActivatedBufList().Exists(x => x.bufType == removeBuf) &&
            //    UnitUtil.SupportCharCheck(owner) == 1)
            //{
            //    DecreaseStacksBufType(owner, removeBuf, 3);
            //    owner.bufListDetail.AddKeywordBufThisRoundByEtc(addBuf, 3, owner);
            //}

            if (owner.faction != Faction.Player) return;
            owner.view.speedDiceSetterUI.DeselectAll();
            var count = owner.allyCardDetail.GetHand().Count;
            var deckForBattle = owner.UnitData.unitData.GetDeckForBattle(deckIndex);
            owner.ChangeBaseDeck(deckForBattle, count);
        }

        private static void ChangeAnimation(BattleUnitModel owner)
        {
            owner.view.StartEgoSkinChangeEffect("Character");
            SingletonBehavior<SoundEffectManager>.Instance.PlayClip("Battle/Purple_Change");
        }

        public static void DecreaseStacksBufType(BattleUnitModel owner, KeywordBuf bufType, int stacks)
        {
            var buf = owner.bufListDetail.GetActivatedBufList().FirstOrDefault(x => x.bufType == bufType);
            if (buf != null) buf.stack -= stacks;
            if (buf != null && buf.stack < 1) owner.bufListDetail.RemoveBuf(buf);
        }

        public static void CheckEmotionCard(BattleUnitModel unit, StruggleEmotionType type)
        {
            var emotionCard = unit.emotionDetail.PassiveList.FirstOrDefault(x =>
                x.AbilityList.Any(y => y is EmotionCardAbility_StanceType_C21341));
            if (emotionCard == null) return;
            foreach (var ability in emotionCard.AbilityList.OfType<EmotionCardAbility_StanceType_C21341>())
                ability.SetType(type);
        }
    }
}