﻿using System.Collections.Generic;
using System.Linq;
using UtilLoader21341.Models;
using UtilLoader21341.Util;

namespace TheColorsMod_C21341.CustomFloor.SpecialCard
{
    public class DiceCardSelfAbility_SummonCloneEmotion_C21341 : DiceCardSelfAbilityBase
    {
        public override void OnUseInstance(BattleUnitModel unit, BattleDiceCardModel self, BattleUnitModel targetUnit)
        {
            Activate(unit);
            self.exhaust = true;
        }

        public static void Activate(BattleUnitModel unit)
        {
            var clone = SummonSpecialUnit(unit, unit.emotionDetail.EmotionLevel, unit.faction);
            UnitUtil.RefreshCombatUI();
            EffectUtil.HandleEgo(clone);
            var customBook = Singleton<BookInventoryModel>.Instance.GetBookListAll()
                .FirstOrDefault(x => x.BookId.Equals(new LorId(clone.Book.BookId.packageId, clone.Book.BookId.id)));
            if (customBook == null) return;
            customBook.owner = null;
            unit.UnitData.unitData.EquipBook(customBook);
        }

        public override bool IsTargetableSelf()
        {
            return true;
        }

        public static BattleUnitModel SummonSpecialUnit(BattleUnitModel unit, int emotionLevel, Faction faction)
        {
            return UnitUtil.AddNewUnitPlayerSideCustomData(
                new UnitModelRoot
                {
                    Id = unit.Book.BookId.id, PackageId = unit.Book.BookId.packageId, AutoPlay = true,
                    SummonedOnPlay = true, UnitNameId = 91, AdditionalPassiveIds = new List<LorIdRoot>
                    {
                        new LorIdRoot
                        {
                            PackageId = TheColorsModParameters.PackageId,
                            Id = 38
                        }
                    }
                },
                BattleObjectManager.instance.GetList(faction).Count, emotionLevel);
        }
    }
}