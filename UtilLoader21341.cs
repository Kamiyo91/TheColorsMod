﻿using System.Collections.Generic;
using LOR_DiceSystem;
using UtilLoader21341.Models;

namespace TheColorsMod_C21341
{
    public static class UtilLoader21341
    {
        public static DefaultKeywordOption DefaultKeywordOption()
        {
            return new DefaultKeywordOption
                { PackageId = TheColorsModParameters.PackageId, Keyword = "LoRModPage_C21341" };
        }

        public static List<CardOptionRoot> CardOptionRoot()
        {
            return new List<CardOptionRoot>
            {
                new CardOptionRoot
                {
                    PackageId = TheColorsModParameters.PackageId, Ids = new List<int> { 4, 5, 6, 7 },
                    Option = CardOption.OnlyPage, Keywords = new List<string> { "MioPage_C21341" },
                    BookId = new List<LorIdRoot>
                        { new LorIdRoot { PackageId = TheColorsModParameters.PackageId, Id = 10000001 } }
                },
                new CardOptionRoot
                {
                    PackageId = TheColorsModParameters.PackageId, Ids = new List<int> { 26 },
                    Option = CardOption.OnlyPage, Keywords = new List<string> { "KamiyoPage_C21341" },
                    BookId = new List<LorIdRoot>
                        { new LorIdRoot { PackageId = TheColorsModParameters.PackageId, Id = 10000002 } }
                },
                new CardOptionRoot
                {
                    PackageId = TheColorsModParameters.PackageId, Ids = new List<int> { 39, 40, 41, 42, 43, 44 },
                    Option = CardOption.OnlyPage, Keywords = new List<string> { "ZeroPage_C21341" },
                    BookId = new List<LorIdRoot>
                        { new LorIdRoot { PackageId = TheColorsModParameters.PackageId, Id = 10000004 } }
                },
                new CardOptionRoot
                {
                    PackageId = TheColorsModParameters.PackageId, Ids = new List<int> { 47, 48, 49, 50 },
                    Option = CardOption.OnlyPage,
                    Keywords = new List<string> { "RenoPage_C21341", "EvolvePage_C21341" },
                    BookId = new List<LorIdRoot>
                        { new LorIdRoot { PackageId = TheColorsModParameters.PackageId, Id = 10000005 } }
                },
                new CardOptionRoot
                {
                    PackageId = TheColorsModParameters.PackageId,
                    Ids = new List<int> { 67, 71, 72, 73, 74, 75, 78 },
                    Option = CardOption.OnlyPage,
                    Keywords = new List<string> { "MiyuPage_C21341" },
                    BookId = new List<LorIdRoot>
                        { new LorIdRoot { PackageId = TheColorsModParameters.PackageId, Id = 10000007 } }
                },
                new CardOptionRoot
                {
                    PackageId = TheColorsModParameters.PackageId,
                    Ids = new List<int> { 68, 76, 79 },
                    Option = CardOption.OnlyPage,
                    Keywords = new List<string> { "MiyuPage_C21341" },
                    OnlyAllyTargetCard = true,
                    OneSideOnlyCard = true,
                    BookId = new List<LorIdRoot>
                        { new LorIdRoot { PackageId = TheColorsModParameters.PackageId, Id = 10000007 } }
                },
                new CardOptionRoot
                {
                    PackageId = TheColorsModParameters.PackageId,
                    Ids = new List<int> { 77 },
                    Option = CardOption.Personal,
                    ForceAggro = true
                },
                new CardOptionRoot
                {
                    PackageId = TheColorsModParameters.PackageId, Ids = new List<int> { 2, 16, 24, 36, 45, 52, 64, 69 },
                    Option = CardOption.EgoPersonal
                },
                new CardOptionRoot
                {
                    PackageId = TheColorsModParameters.PackageId,
                    Ids = new List<int> { 1, 8, 9, 19, 25, 27, 28, 29, 37, 58, 65, 70, 82, 83, 84, 2021, 2022 },
                    Option = CardOption.Personal
                },
                new CardOptionRoot
                {
                    PackageId = TheColorsModParameters.PackageId,
                    Ids = new List<int> { 2016, 2017, 2018, 2019, 2020, 2026 },
                    Option = CardOption.EGO
                }
            };
        }

        public static List<CategoryOptionRoot> CategoryOptionRoot()
        {
            return new List<CategoryOptionRoot>
            {
                new CategoryOptionRoot
                {
                    PackageId = TheColorsModParameters.PackageId, AdditionalValue = "1",
                    CustomIconSpriteId = "TheColorFloor_C21341", CategoryNameId = "TheColorsC21341.Mod",
                    CredenzaBooksId = new List<int>
                        { 10000001, 10000002, 10000003, 10000004, 10000005, 10000006, 10000007, 10000900 },
                    CategoryBooksId = new List<int>
                    {
                        10000001, 10000002, 10000003, 10000004, 10000005, 10000006, 10000007, 10000900, 10000901,
                        10000902
                    }
                }
            };
        }

        public static List<RewardOptionRoot> RewardOptionRoot()
        {
            return new List<RewardOptionRoot>
            {
                new RewardOptionRoot
                {
                    Keypages = new List<ItemQuantityRoot>
                    {
                        new ItemQuantityRoot
                            { LorId = new LorIdRoot { PackageId = TheColorsModParameters.PackageId, Id = 10000001 } },
                        new ItemQuantityRoot
                            { LorId = new LorIdRoot { PackageId = TheColorsModParameters.PackageId, Id = 10000002 } },
                        new ItemQuantityRoot
                            { LorId = new LorIdRoot { PackageId = TheColorsModParameters.PackageId, Id = 10000003 } },
                        new ItemQuantityRoot
                            { LorId = new LorIdRoot { PackageId = TheColorsModParameters.PackageId, Id = 10000004 } },
                        new ItemQuantityRoot
                            { LorId = new LorIdRoot { PackageId = TheColorsModParameters.PackageId, Id = 10000005 } },
                        new ItemQuantityRoot
                            { LorId = new LorIdRoot { PackageId = TheColorsModParameters.PackageId, Id = 10000006 } },
                        new ItemQuantityRoot
                            { LorId = new LorIdRoot { PackageId = TheColorsModParameters.PackageId, Id = 10000007 } },
                        new ItemQuantityRoot
                            { LorId = new LorIdRoot { PackageId = TheColorsModParameters.PackageId, Id = 10000900 } },
                        new ItemQuantityRoot
                            { LorId = new LorIdRoot { PackageId = TheColorsModParameters.PackageId, Id = 10000901 } },
                        new ItemQuantityRoot
                            { LorId = new LorIdRoot { PackageId = TheColorsModParameters.PackageId, Id = 10000902 } }
                    },
                    Cards = new List<ItemQuantityRoot>
                    {
                        new ItemQuantityRoot
                        {
                            LorId = new LorIdRoot { PackageId = TheColorsModParameters.PackageId, Id = 4 }, Quantity = 1
                        },
                        new ItemQuantityRoot
                        {
                            LorId = new LorIdRoot { PackageId = TheColorsModParameters.PackageId, Id = 5 }, Quantity = 6
                        },
                        new ItemQuantityRoot
                        {
                            LorId = new LorIdRoot { PackageId = TheColorsModParameters.PackageId, Id = 6 }, Quantity = 3
                        },
                        new ItemQuantityRoot
                        {
                            LorId = new LorIdRoot { PackageId = TheColorsModParameters.PackageId, Id = 7 }, Quantity = 6
                        },
                        new ItemQuantityRoot
                        {
                            LorId = new LorIdRoot { PackageId = TheColorsModParameters.PackageId, Id = 10 },
                            Quantity = 6
                        },
                        new ItemQuantityRoot
                        {
                            LorId = new LorIdRoot { PackageId = TheColorsModParameters.PackageId, Id = 11 },
                            Quantity = 6
                        },
                        new ItemQuantityRoot
                        {
                            LorId = new LorIdRoot { PackageId = TheColorsModParameters.PackageId, Id = 12 },
                            Quantity = 6
                        },
                        new ItemQuantityRoot
                        {
                            LorId = new LorIdRoot { PackageId = TheColorsModParameters.PackageId, Id = 13 },
                            Quantity = 6
                        },
                        new ItemQuantityRoot
                        {
                            LorId = new LorIdRoot { PackageId = TheColorsModParameters.PackageId, Id = 17 },
                            Quantity = 6
                        },
                        new ItemQuantityRoot
                        {
                            LorId = new LorIdRoot { PackageId = TheColorsModParameters.PackageId, Id = 18 },
                            Quantity = 6
                        },
                        new ItemQuantityRoot
                        {
                            LorId = new LorIdRoot { PackageId = TheColorsModParameters.PackageId, Id = 21 },
                            Quantity = 6
                        },
                        new ItemQuantityRoot
                        {
                            LorId = new LorIdRoot { PackageId = TheColorsModParameters.PackageId, Id = 22 },
                            Quantity = 6
                        },
                        new ItemQuantityRoot
                        {
                            LorId = new LorIdRoot { PackageId = TheColorsModParameters.PackageId, Id = 23 },
                            Quantity = 3
                        },
                        new ItemQuantityRoot
                        {
                            LorId = new LorIdRoot { PackageId = TheColorsModParameters.PackageId, Id = 26 },
                            Quantity = 1
                        },
                        new ItemQuantityRoot
                        {
                            LorId = new LorIdRoot { PackageId = TheColorsModParameters.PackageId, Id = 30 },
                            Quantity = 6
                        },
                        new ItemQuantityRoot
                        {
                            LorId = new LorIdRoot { PackageId = TheColorsModParameters.PackageId, Id = 31 },
                            Quantity = 6
                        },
                        new ItemQuantityRoot
                        {
                            LorId = new LorIdRoot { PackageId = TheColorsModParameters.PackageId, Id = 32 },
                            Quantity = 6
                        },
                        new ItemQuantityRoot
                        {
                            LorId = new LorIdRoot { PackageId = TheColorsModParameters.PackageId, Id = 33 },
                            Quantity = 6
                        },
                        new ItemQuantityRoot
                        {
                            LorId = new LorIdRoot { PackageId = TheColorsModParameters.PackageId, Id = 34 },
                            Quantity = 2
                        },
                        new ItemQuantityRoot
                        {
                            LorId = new LorIdRoot { PackageId = TheColorsModParameters.PackageId, Id = 39 },
                            Quantity = 2
                        },
                        new ItemQuantityRoot
                        {
                            LorId = new LorIdRoot { PackageId = TheColorsModParameters.PackageId, Id = 40 },
                            Quantity = 1
                        },
                        new ItemQuantityRoot
                        {
                            LorId = new LorIdRoot { PackageId = TheColorsModParameters.PackageId, Id = 41 },
                            Quantity = 3
                        },
                        new ItemQuantityRoot
                        {
                            LorId = new LorIdRoot { PackageId = TheColorsModParameters.PackageId, Id = 42 },
                            Quantity = 3
                        },
                        new ItemQuantityRoot
                        {
                            LorId = new LorIdRoot { PackageId = TheColorsModParameters.PackageId, Id = 43 },
                            Quantity = 3
                        },
                        new ItemQuantityRoot
                        {
                            LorId = new LorIdRoot { PackageId = TheColorsModParameters.PackageId, Id = 44 },
                            Quantity = 3
                        },
                        new ItemQuantityRoot
                        {
                            LorId = new LorIdRoot { PackageId = TheColorsModParameters.PackageId, Id = 47 },
                            Quantity = 6
                        },
                        new ItemQuantityRoot
                        {
                            LorId = new LorIdRoot { PackageId = TheColorsModParameters.PackageId, Id = 48 },
                            Quantity = 3
                        },
                        new ItemQuantityRoot
                        {
                            LorId = new LorIdRoot { PackageId = TheColorsModParameters.PackageId, Id = 49 },
                            Quantity = 6
                        },
                        new ItemQuantityRoot
                        {
                            LorId = new LorIdRoot { PackageId = TheColorsModParameters.PackageId, Id = 50 },
                            Quantity = 1
                        },
                        new ItemQuantityRoot
                        {
                            LorId = new LorIdRoot { PackageId = TheColorsModParameters.PackageId, Id = 59 },
                            Quantity = 6
                        },
                        new ItemQuantityRoot
                        {
                            LorId = new LorIdRoot { PackageId = TheColorsModParameters.PackageId, Id = 60 },
                            Quantity = 3
                        },
                        new ItemQuantityRoot
                        {
                            LorId = new LorIdRoot { PackageId = TheColorsModParameters.PackageId, Id = 61 },
                            Quantity = 1
                        },
                        new ItemQuantityRoot
                        {
                            LorId = new LorIdRoot { PackageId = TheColorsModParameters.PackageId, Id = 62 },
                            Quantity = 6
                        },
                        new ItemQuantityRoot
                        {
                            LorId = new LorIdRoot { PackageId = TheColorsModParameters.PackageId, Id = 67 },
                            Quantity = 1
                        },
                        new ItemQuantityRoot
                        {
                            LorId = new LorIdRoot { PackageId = TheColorsModParameters.PackageId, Id = 68 },
                            Quantity = 1
                        },
                        new ItemQuantityRoot
                        {
                            LorId = new LorIdRoot { PackageId = TheColorsModParameters.PackageId, Id = 71 },
                            Quantity = 1
                        },
                        new ItemQuantityRoot
                        {
                            LorId = new LorIdRoot { PackageId = TheColorsModParameters.PackageId, Id = 72 },
                            Quantity = 1
                        },
                        new ItemQuantityRoot
                        {
                            LorId = new LorIdRoot { PackageId = TheColorsModParameters.PackageId, Id = 73 },
                            Quantity = 1
                        },
                        new ItemQuantityRoot
                        {
                            LorId = new LorIdRoot { PackageId = TheColorsModParameters.PackageId, Id = 74 },
                            Quantity = 1
                        },
                        new ItemQuantityRoot
                        {
                            LorId = new LorIdRoot { PackageId = TheColorsModParameters.PackageId, Id = 75 },
                            Quantity = 1
                        },
                        new ItemQuantityRoot
                        {
                            LorId = new LorIdRoot { PackageId = TheColorsModParameters.PackageId, Id = 76 },
                            Quantity = 1
                        },
                        new ItemQuantityRoot
                        {
                            LorId = new LorIdRoot { PackageId = TheColorsModParameters.PackageId, Id = 78 },
                            Quantity = 1
                        },
                        new ItemQuantityRoot
                        {
                            LorId = new LorIdRoot { PackageId = TheColorsModParameters.PackageId, Id = 79 },
                            Quantity = 1
                        }
                    }
                }
            };
        }

        public static List<KeypageOptionRoot> KeypageOptionRoot()
        {
            return new List<KeypageOptionRoot>
            {
                new KeypageOptionRoot
                {
                    PackageId = TheColorsModParameters.PackageId, KeypageId = 10000001, EveryoneCanEquip = true,
                    BookCustomOptions = new BookCustomOptionRoot
                    {
                        OriginalSkin = "MioNormalEye_C21341", EgoSkin = new List<string> { "MioRedEye_C21341" },
                        NameTextId = 1
                    }
                },
                new KeypageOptionRoot
                {
                    PackageId = TheColorsModParameters.PackageId, KeypageId = 10000002, EveryoneCanEquip = true,
                    BookCustomOptions = new BookCustomOptionRoot { NameTextId = 2 }
                },
                new KeypageOptionRoot
                {
                    PackageId = TheColorsModParameters.PackageId, KeypageId = 10000003, EveryoneCanEquip = true,
                    BookCustomOptions = new BookCustomOptionRoot
                        { OriginalSkin = "Sae_C21341", EgoSkin = new List<string> { "SaeRage_C21341" }, NameTextId = 3 }
                },
                new KeypageOptionRoot
                {
                    PackageId = TheColorsModParameters.PackageId, KeypageId = 10000004, EveryoneCanEquip = true,
                    BookCustomOptions = new BookCustomOptionRoot { NameTextId = 4 }
                },
                new KeypageOptionRoot
                {
                    PackageId = TheColorsModParameters.PackageId, KeypageId = 10000005, EveryoneCanEquip = true,
                    BookCustomOptions = new BookCustomOptionRoot
                    {
                        OriginalSkin = "GreenHunter_C21341", EgoSkin = new List<string> { "GreenHunterEgo_C21341" },
                        NameTextId = 5
                    }
                },
                new KeypageOptionRoot
                {
                    PackageId = TheColorsModParameters.PackageId, KeypageId = 10000006, EveryoneCanEquip = true,
                    BookCustomOptions = new BookCustomOptionRoot { NameTextId = 6 }
                },
                new KeypageOptionRoot
                {
                    PackageId = TheColorsModParameters.PackageId, KeypageId = 10000007, EveryoneCanEquip = true,
                    BookCustomOptions = new BookCustomOptionRoot { NameTextId = 7 }
                },
                new KeypageOptionRoot
                {
                    PackageId = TheColorsModParameters.PackageId, KeypageId = 10000900, EveryoneCanEquip = true,
                    BookCustomOptions = new BookCustomOptionRoot { NameTextId = 90 }
                },
                new KeypageOptionRoot
                {
                    PackageId = TheColorsModParameters.PackageId, KeypageId = 10000901,
                    BookCustomOptions = new BookCustomOptionRoot { NameTextId = 91 }
                }
            };
        }

        public static List<PassiveOptionRoot> PassiveOptionRoot()
        {
            return new List<PassiveOptionRoot>
            {
                new PassiveOptionRoot
                {
                    PackageId = TheColorsModParameters.PackageId, PassiveId = 13,
                    CanBeUsedWithPassivesOne = new List<LorIdRoot>
                        { new LorIdRoot { PackageId = TheColorsModParameters.PackageId, Id = 12 } },
                    CannotBeUsedWithPassives = new List<LorIdRoot>
                    {
                        new LorIdRoot { PackageId = "MaryIb21341.Mod", Id = 3 },
                        new LorIdRoot { PackageId = "LorModPackRe21341.Mod", Id = 22 }, new LorIdRoot { Id = 230008 }
                    }
                },
                new PassiveOptionRoot
                {
                    PackageId = TheColorsModParameters.PackageId, PassiveId = 12, IsMultiDeck = true,
                    MultiDeckLabelIds = new List<string> { "AttackStance_C21341", "DefendStance_C21341" }
                },
                new PassiveOptionRoot
                {
                    PackageId = TheColorsModParameters.PackageId, PassiveId = 14, IsSupportPassive = true,
                    BannedEgoFloorCards = true, BannedEmotionCardSelection = true, GainCoins = false
                },
                new PassiveOptionRoot
                {
                    PackageId = TheColorsModParameters.PackageId, PassiveId = 38, IsSupportPassive = true,
                    BannedEgoFloorCards = true, BannedEmotionCardSelection = true, GainCoins = false
                },
                new PassiveOptionRoot
                {
                    PackageId = TheColorsModParameters.PackageId, PassiveId = 29,
                    ForceAggroOptions = new ForceAggroOptionsRoot { ForceAggro = true }
                },
                new PassiveOptionRoot
                {
                    PackageId = TheColorsModParameters.PackageId, PassiveId = 37,
                    CustomFloorOptions = new CustomFloorOptionRoot
                    {
                        PackageId = TheColorsModParameters.PackageId,
                        IconId = "TheColorFloor_C21341",
                        FloorNameId = "TheColorFloor_C21341",
                        CustomFloorMap = new MapModelRoot
                        {
                            Component = "ColorsFloor_C21341MapManager",
                            Stage = "ColorsFloor_C21341",
                            Bgy = 0.25f,
                            Fy = 0.8f
                        },
                        EgoCardsId = new List<LorIdRoot>
                        {
                            new LorIdRoot { Id = 2016, PackageId = TheColorsModParameters.PackageId },
                            new LorIdRoot { Id = 2017, PackageId = TheColorsModParameters.PackageId },
                            new LorIdRoot { Id = 2018, PackageId = TheColorsModParameters.PackageId },
                            new LorIdRoot { Id = 2019, PackageId = TheColorsModParameters.PackageId },
                            new LorIdRoot { Id = 2020, PackageId = TheColorsModParameters.PackageId }
                        },
                        EmotionCardsId = new List<LorIdRoot>
                        {
                            new LorIdRoot { Id = 2001, PackageId = TheColorsModParameters.PackageId },
                            new LorIdRoot { Id = 2002, PackageId = TheColorsModParameters.PackageId },
                            new LorIdRoot { Id = 2003, PackageId = TheColorsModParameters.PackageId },
                            new LorIdRoot { Id = 2004, PackageId = TheColorsModParameters.PackageId },
                            new LorIdRoot { Id = 2005, PackageId = TheColorsModParameters.PackageId },
                            new LorIdRoot { Id = 2006, PackageId = TheColorsModParameters.PackageId },
                            new LorIdRoot { Id = 2007, PackageId = TheColorsModParameters.PackageId },
                            new LorIdRoot { Id = 2008, PackageId = TheColorsModParameters.PackageId },
                            new LorIdRoot { Id = 2009, PackageId = TheColorsModParameters.PackageId },
                            new LorIdRoot { Id = 2010, PackageId = TheColorsModParameters.PackageId },
                            new LorIdRoot { Id = 2011, PackageId = TheColorsModParameters.PackageId },
                            new LorIdRoot { Id = 2012, PackageId = TheColorsModParameters.PackageId },
                            new LorIdRoot { Id = 2013, PackageId = TheColorsModParameters.PackageId },
                            new LorIdRoot { Id = 2014, PackageId = TheColorsModParameters.PackageId },
                            new LorIdRoot { Id = 2015, PackageId = TheColorsModParameters.PackageId }
                        }
                    }
                },
                new PassiveOptionRoot
                {
                    PackageId = TheColorsModParameters.PackageId, PassiveId = 40,
                    CustomFloorOptions = new CustomFloorOptionRoot
                    {
                        PackageId = TheColorsModParameters.PackageId,
                        IconId = "TheColorFloorRage_C21341",
                        FloorNameId = "TheColorFloorRage_C21341",
                        CustomFloorMap = new MapModelRoot
                        {
                            Component = "ColorsFloorRage_C21341MapManager",
                            Stage = "ColorsFloorRage_C21341",
                            Bgy = 0.25f,
                            Fy = 0.8f
                        },
                        EgoCardsId = new List<LorIdRoot>
                        {
                            new LorIdRoot { Id = 2026, PackageId = TheColorsModParameters.PackageId },
                            new LorIdRoot { Id = 2017, PackageId = TheColorsModParameters.PackageId },
                            new LorIdRoot { Id = 2018, PackageId = TheColorsModParameters.PackageId },
                            new LorIdRoot { Id = 2019, PackageId = TheColorsModParameters.PackageId },
                            new LorIdRoot { Id = 2020, PackageId = TheColorsModParameters.PackageId }
                        },
                        EmotionCardsId = new List<LorIdRoot>
                        {
                            new LorIdRoot { Id = 2023, PackageId = TheColorsModParameters.PackageId },
                            new LorIdRoot { Id = 2024, PackageId = TheColorsModParameters.PackageId },
                            new LorIdRoot { Id = 2025, PackageId = TheColorsModParameters.PackageId },
                            new LorIdRoot { Id = 2004, PackageId = TheColorsModParameters.PackageId },
                            new LorIdRoot { Id = 2005, PackageId = TheColorsModParameters.PackageId },
                            new LorIdRoot { Id = 2006, PackageId = TheColorsModParameters.PackageId },
                            new LorIdRoot { Id = 2007, PackageId = TheColorsModParameters.PackageId },
                            new LorIdRoot { Id = 2008, PackageId = TheColorsModParameters.PackageId },
                            new LorIdRoot { Id = 2009, PackageId = TheColorsModParameters.PackageId },
                            new LorIdRoot { Id = 2010, PackageId = TheColorsModParameters.PackageId },
                            new LorIdRoot { Id = 2011, PackageId = TheColorsModParameters.PackageId },
                            new LorIdRoot { Id = 2012, PackageId = TheColorsModParameters.PackageId },
                            new LorIdRoot { Id = 2013, PackageId = TheColorsModParameters.PackageId },
                            new LorIdRoot { Id = 2014, PackageId = TheColorsModParameters.PackageId },
                            new LorIdRoot { Id = 2015, PackageId = TheColorsModParameters.PackageId }
                        }
                    }
                }
            };
        }

        public static List<SkinOptionRoot> SkinOptionRoot()
        {
            return new List<SkinOptionRoot>
            {
                new SkinOptionRoot { PackageId = TheColorsModParameters.PackageId, SkinName = "MioNormalEye_C21341" },
                new SkinOptionRoot { PackageId = TheColorsModParameters.PackageId, SkinName = "MioRedEye_C21341" },
                new SkinOptionRoot { PackageId = TheColorsModParameters.PackageId, SkinName = "KamiyoMask_C21341" },
                new SkinOptionRoot { PackageId = TheColorsModParameters.PackageId, SkinName = "Sae_C21341" },
                new SkinOptionRoot { PackageId = TheColorsModParameters.PackageId, SkinName = "SaeRage_C21341" },
                new SkinOptionRoot { PackageId = TheColorsModParameters.PackageId, SkinName = "Wonderland_C21341" },
                new SkinOptionRoot { PackageId = TheColorsModParameters.PackageId, SkinName = "Zero_C21341" },
                new SkinOptionRoot { PackageId = TheColorsModParameters.PackageId, SkinName = "Raziel_C21341" },
                new SkinOptionRoot
                {
                    PackageId = TheColorsModParameters.PackageId, SkinName = "GreenHunter_C21341",
                    MotionSounds = new List<MotionSoundOptionRoot>
                    {
                        new MotionSoundOptionRoot
                        {
                            Motion = MotionDetail.F,
                            MotionSound = new MotionSoundRoot
                            {
                                FileNameWin = "GreenHunterShot_C21341.ogg", FileNameLose = "GreenHunterShot_C21341.ogg"
                            }
                        }
                    }
                },
                new SkinOptionRoot
                {
                    PackageId = TheColorsModParameters.PackageId, SkinName = "GreenHunterEgo_C21341",
                    MotionSounds = new List<MotionSoundOptionRoot>
                    {
                        new MotionSoundOptionRoot
                        {
                            Motion = MotionDetail.F,
                            MotionSound = new MotionSoundRoot
                            {
                                FileNameWin = "GreenHunterShot_C21341.ogg", FileNameLose = "GreenHunterShot_C21341.ogg"
                            }
                        }
                    }
                },
                new SkinOptionRoot
                {
                    PackageId = TheColorsModParameters.PackageId, SkinName = "Miyu_C21341",
                    MotionSounds = new List<MotionSoundOptionRoot>
                    {
                        new MotionSoundOptionRoot
                        {
                            Motion = MotionDetail.J,
                            MotionSound = new MotionSoundRoot
                            {
                                FileNameWin = "Yuzin_Special_Atk", IsBaseSoundWin = true,
                                FileNameLose = "Yuzin_Special_Atk", IsBaseSoundLose = true
                            }
                        },
                        new MotionSoundOptionRoot
                        {
                            Motion = MotionDetail.Z,
                            MotionSound = new MotionSoundRoot
                            {
                                FileNameWin = "Puppet_thorn", IsBaseSoundWin = true, FileNameLose = "Puppet_thorn",
                                IsBaseSoundLose = true
                            }
                        },
                        new MotionSoundOptionRoot
                        {
                            Motion = MotionDetail.F,
                            MotionSound = new MotionSoundRoot
                            {
                                FileNameWin = "Philip_FilterOn", IsBaseSoundWin = true,
                                FileNameLose = "Philip_FilterOn", IsBaseSoundLose = true
                            }
                        },
                        new MotionSoundOptionRoot
                        {
                            Motion = MotionDetail.S1,
                            MotionSound = new MotionSoundRoot
                            {
                                FileNameWin = "Claw_Heal", IsBaseSoundWin = true, FileNameLose = "Claw_Heal",
                                IsBaseSoundLose = true
                            }
                        },
                        new MotionSoundOptionRoot
                        {
                            Motion = MotionDetail.S4,
                            MotionSound = new MotionSoundRoot
                            {
                                FileNameWin = "Claw_Heal", IsBaseSoundWin = true, FileNameLose = "Claw_Heal",
                                IsBaseSoundLose = true
                            }
                        },
                        new MotionSoundOptionRoot
                        {
                            Motion = MotionDetail.S5,
                            MotionSound = new MotionSoundRoot
                            {
                                FileNameWin = "Claw_Heal", IsBaseSoundWin = true, FileNameLose = "Claw_Heal",
                                IsBaseSoundLose = true
                            }
                        },
                        new MotionSoundOptionRoot
                        {
                            Motion = MotionDetail.S2,
                            MotionSound = new MotionSoundRoot
                            {
                                FileNameWin = "Binah_Chain", IsBaseSoundWin = true, FileNameLose = "Binah_Chain",
                                IsBaseSoundLose = true
                            }
                        },
                        new MotionSoundOptionRoot
                        {
                            Motion = MotionDetail.S8,
                            MotionSound = new MotionSoundRoot
                            {
                                FileNameWin = "Philip_FilterOn", IsBaseSoundWin = true,
                                FileNameLose = "Philip_FilterOn", IsBaseSoundLose = true
                            }
                        },
                        new MotionSoundOptionRoot
                        {
                            Motion = MotionDetail.H,
                            MotionSound = new MotionSoundRoot
                            {
                                FileNameWin = "WaterMagic_C21341.ogg", FileNameLose = "WaterMagic_C21341.ogg"
                            }
                        },
                        new MotionSoundOptionRoot
                        {
                            Motion = MotionDetail.S9,
                            MotionSound = new MotionSoundRoot
                            {
                                FileNameWin = "Xiao_DragonUp_End", IsBaseSoundWin = true,
                                FileNameLose = "Xiao_DragonUp_End", IsBaseSoundLose = true
                            }
                        }
                    }
                }
            };
        }

        public static List<CustomSkinOptionRoot> CustomSkinOptionRoot()
        {
            return new List<CustomSkinOptionRoot>
            {
                new CustomSkinOptionRoot
                {
                    PackageId = TheColorsModParameters.PackageId, SkinName = "MioNormalEye_C21341",
                    KeypageId = 10000001, CharacterNameId = 1
                },
                new CustomSkinOptionRoot
                {
                    PackageId = TheColorsModParameters.PackageId, SkinName = "KamiyoMask_C21341", KeypageId = 10000002,
                    CharacterNameId = 2
                },
                new CustomSkinOptionRoot
                {
                    PackageId = TheColorsModParameters.PackageId, SkinName = "Sae_C21341", KeypageId = 10000003,
                    CharacterNameId = 3
                },
                new CustomSkinOptionRoot
                {
                    PackageId = TheColorsModParameters.PackageId, SkinName = "Zero_C21341", KeypageId = 10000004,
                    CharacterNameId = 4
                },
                new CustomSkinOptionRoot
                {
                    PackageId = TheColorsModParameters.PackageId, SkinName = "GreenHunter_C21341", KeypageId = 10000005,
                    CharacterNameId = 5
                },
                new CustomSkinOptionRoot
                {
                    PackageId = TheColorsModParameters.PackageId, SkinName = "GreenHunterEgo_C21341",
                    KeypageId = 10000005, CharacterNameId = 5
                },
                new CustomSkinOptionRoot
                {
                    PackageId = TheColorsModParameters.PackageId, SkinName = "Raziel_C21341", KeypageId = 10000006,
                    CharacterNameId = 6
                },
                new CustomSkinOptionRoot
                {
                    PackageId = TheColorsModParameters.PackageId, SkinName = "Miyu_C21341", KeypageId = 10000007,
                    CharacterNameId = 7
                },
                new CustomSkinOptionRoot
                {
                    PackageId = TheColorsModParameters.PackageId, SkinName = "Wonderland_C21341", KeypageId = 10000900,
                    CharacterNameId = 90
                }
            };
        }

        public static List<SpriteOptionRoot> SpriteOptionRoot()
        {
            return new List<SpriteOptionRoot>
            {
                new SpriteOptionRoot
                {
                    PackageId = TheColorsModParameters.PackageId, Ids = new List<int> { 10000001 },
                    SpritePK = "MioDefault_C21341"
                },
                new SpriteOptionRoot
                {
                    PackageId = TheColorsModParameters.PackageId, Ids = new List<int> { 10000002 },
                    SpritePK = "KamiyoDefault_C21341"
                },
                new SpriteOptionRoot
                {
                    PackageId = TheColorsModParameters.PackageId, Ids = new List<int> { 10000003 },
                    SpritePK = "SaeDefault_C21341"
                },
                new SpriteOptionRoot
                {
                    PackageId = TheColorsModParameters.PackageId, Ids = new List<int> { 10000004 },
                    SpritePK = "ZeroDefault_C21341"
                },
                new SpriteOptionRoot
                {
                    PackageId = TheColorsModParameters.PackageId, Ids = new List<int> { 10000005 },
                    SpritePK = "GreenDefault_C21341"
                },
                new SpriteOptionRoot
                {
                    PackageId = TheColorsModParameters.PackageId, Ids = new List<int> { 10000006 },
                    SpritePK = "RazielDefault_C21341"
                },
                new SpriteOptionRoot
                {
                    PackageId = TheColorsModParameters.PackageId, Ids = new List<int> { 10000007 },
                    SpritePK = "MiyuDefault_C21341"
                },
                new SpriteOptionRoot
                {
                    PackageId = TheColorsModParameters.PackageId, Ids = new List<int> { 10000900, 10000901 },
                    SpritePK = "WonderlandDefault_C21341"
                },
                new SpriteOptionRoot
                {
                    PackageId = TheColorsModParameters.PackageId, Ids = new List<int> { 10000902 },
                    SpritePK = "FragmentDefault_C21341"
                },
                new SpriteOptionRoot
                {
                    PackageId = TheColorsModParameters.PackageId, Ids = new List<int> { 10000903 },
                    SpritePK = "FragmentRedDefault_C21341"
                }
            };
        }

        public static List<UnitModelRoot> UnitModelRoot()
        {
            return new List<UnitModelRoot>
            {
                new UnitModelRoot
                {
                    PackageId = TheColorsModParameters.PackageId, Id = 10000901, AutoPlay = true, SummonedOnPlay = true,
                    UnitNameId = 91
                }
            };
        }

        public static List<BuffOptionRoot> BuffOptionRoot()
        {
            return new List<BuffOptionRoot>
            {
                new BuffOptionRoot
                {
                    BuffId = "EmotionPreyOwner_C21341",
                    ForceAggroOptions = new ForceAggroOptionsRoot
                        { ForceAggroByBuffByKeywordId = new List<string> { "EmotionPrey_C21341" } }
                }
            };
        }
    }
}