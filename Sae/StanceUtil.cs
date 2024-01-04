using System.Collections.Generic;
using System.Linq;
using Sound;
using TheColorsMod_C21341.CustomFloor;
using TheColorsMod_C21341.Sae.Buff;
using UtilLoader21341.Extensions;
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

        public static void ChangeStance<T>(this BattleUnitModel owner, int deckIndex,
            ActionDetail altMotion = ActionDetail.NONE, bool resetStance = false)
            where T : BattleUnitBuf, new()
        {
            ChangeAnimation(owner);
            owner.AddBuffCustom<T>(0);
            if (resetStance)
            {
                owner.view.charAppearance.RemoveAltMotion(ActionDetail.Standing);
                owner.view.charAppearance.RemoveAltMotion(ActionDetail.Default);
            }
            else
            {
                owner.view.charAppearance.SetAltMotion(ActionDetail.Standing, altMotion);
                owner.view.charAppearance.SetAltMotion(ActionDetail.Default, altMotion);
            }

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

        public static void AddSwitchBuffEmotionPassive(BattleUnitModel owner)
        {
            var passive = owner.GetActivePassive<PassiveAbility_SwitchBuffsOddAndEven_DLL21341>() ??
                          new PassiveAbility_SwitchBuffsOddAndEven_DLL21341();
            owner.passiveDetail.PassiveList.Add(passive);
            passive.Init(owner);
            passive.SetKeywords(new List<KeywordBuf> { KeywordBuf.Strength, KeywordBuf.Endurance });
            passive.SetAddOneExtra(true);
            passive.SetActive(true);
        }
    }
}