﻿using System.Collections.Generic;
using CustomColorUtil.Models;

namespace TheColorsMod_C21341
{
    public static class CustomColorLoader21341
    {
        public static List<CardOptionRoot> CardOptionRoot()
        {
            return new List<CardOptionRoot>
            {
                new CardOptionRoot
                {
                    PackageId = TheColorsModParameters.PackageId, Ids = new List<int> { 1, 4, 6, 900 },
                    CardColorOptions = new CardColorOptionRoot
                    {
                        CardColor = new ColorRoot { R = 255, G = 255, B = 255, A = 255 },
                        IconColor = new HsvColorRoot { H = 0, S = 0, V = 1.5f }
                    }
                },
                new CardOptionRoot
                {
                    PackageId = TheColorsModParameters.PackageId, Ids = new List<int> { 23, 25, 26, 903 },
                    CardColorOptions = new CardColorOptionRoot
                    {
                        CardColor = new ColorRoot { R = 127, G = 127, B = 127, A = 255 },
                        IconColor = new HsvColorRoot { H = 0, S = 0, V = 0.05f }
                    }
                },
                new CardOptionRoot
                {
                    PackageId = TheColorsModParameters.PackageId, Ids = new List<int> { 19, 901, 902 },
                    CardColorOptions = new CardColorOptionRoot
                    {
                        CardColor = new ColorRoot { R = 153, G = 0, B = 0, A = 255 },
                        CustomIconColor = new ColorRoot { R = 153, G = 0, B = 0, A = 255 }, UseHSVFilter = false
                    }
                },
                new CardOptionRoot
                {
                    PackageId = TheColorsModParameters.PackageId, Ids = new List<int> { 27, 28, 29, 34, 904 },
                    CardColorOptions = new CardColorOptionRoot
                    {
                        CardColor = new ColorRoot { R = 176, G = 102, B = 255, A = 255 },
                        CustomIconColor = new ColorRoot { R = 176, G = 102, B = 255, A = 255 }, UseHSVFilter = false
                    }
                },
                new CardOptionRoot
                {
                    PackageId = TheColorsModParameters.PackageId, Ids = new List<int> { 37, 38, 39, 40, 905 },
                    CardColorOptions = new CardColorOptionRoot
                    {
                        CardColor = new ColorRoot { R = 102, G = 176, B = 255, A = 255 },
                        CustomIconColor = new ColorRoot { R = 102, G = 176, B = 255, A = 255 }, UseHSVFilter = false
                    }
                },
                new CardOptionRoot
                {
                    PackageId = TheColorsModParameters.PackageId, Ids = new List<int> { 50, 55, 58, 906 },
                    CardColorOptions = new CardColorOptionRoot
                    {
                        CardColor = new ColorRoot { R = 153, G = 255, B = 153, A = 255 },
                        CustomIconColor = new ColorRoot { R = 153, G = 255, B = 153, A = 255 }, UseHSVFilter = false
                    }
                },
                new CardOptionRoot
                {
                    PackageId = TheColorsModParameters.PackageId,
                    Ids = new List<int> { 67, 70, 71, 72, 73, 74, 75, 77, 78, 82, 83, 84, 908 },
                    CardColorOptions = new CardColorOptionRoot
                    {
                        CardColor = new ColorRoot { R = 140, G = 0, B = 72, A = 255 },
                        CustomIconColor = new ColorRoot { R = 140, G = 41, B = 72, A = 255 }, UseHSVFilter = false
                    }
                },
                new CardOptionRoot
                {
                    PackageId = TheColorsModParameters.PackageId,
                    Ids = new List<int> { 68 },
                    CardColorOptions = new CardColorOptionRoot
                    {
                        CardColor = new ColorRoot { R = 140, G = 0, B = 72, A = 255 },
                        CustomIconColor = new ColorRoot { R = 140, G = 41, B = 72, A = 255 }, UseHSVFilter = false,
                        CustomDiceIcon = new List<CustomDiceIconRoot>
                        {
                            new CustomDiceIconRoot
                            {
                                PackageId = "CustomColorUtil21341", KeywordIconId = "HealHitDie",
                                KeywordIconIdClash = "HealHitCombatDie",
                                DiceColor = new ColorRoot { R = 0, G = 255, B = 0, A = 255 },
                                TextColor = new ColorRoot { R = 0, G = 255, B = 0, A = 255 }, DiceNumber = 0
                            },
                            new CustomDiceIconRoot
                            {
                                PackageId = "CustomColorUtil21341", KeywordIconId = "HealHitDie",
                                KeywordIconIdClash = "HealHitCombatDie",
                                DiceColor = new ColorRoot { R = 0, G = 255, B = 0, A = 255 },
                                TextColor = new ColorRoot { R = 0, G = 255, B = 0, A = 255 }, DiceNumber = 1
                            }
                        }
                    }
                },
                new CardOptionRoot
                {
                    PackageId = TheColorsModParameters.PackageId,
                    Ids = new List<int> { 76, 79 },
                    CardColorOptions = new CardColorOptionRoot
                    {
                        CardColor = new ColorRoot { R = 140, G = 0, B = 72, A = 255 },
                        CustomIconColor = new ColorRoot { R = 140, G = 41, B = 72, A = 255 }, UseHSVFilter = false,
                        CustomDiceIcon = new List<CustomDiceIconRoot>
                        {
                            new CustomDiceIconRoot
                            {
                                PackageId = "CustomColorUtil21341", KeywordIconId = "HealHitDie",
                                KeywordIconIdClash = "HealHitCombatDie",
                                DiceColor = new ColorRoot { R = 0, G = 255, B = 0, A = 255 },
                                TextColor = new ColorRoot { R = 0, G = 255, B = 0, A = 255 }, DiceNumber = 0
                            }
                        }
                    }
                }
            };
        }

        public static List<CategoryOptionRoot> CategoryOptionRoot()
        {
            return new List<CategoryOptionRoot>
            {
                new CategoryOptionRoot
                {
                    PackageId = TheColorsModParameters.PackageId, AdditionalValue = "_1",
                    BookDataColor = new ColorOptionsRoot
                    {
                        TextColor = new ColorRoot { R = 255, G = 255, B = 255, A = 255 },
                        FrameColor = new ColorRoot { R = 255, G = 255, B = 255, A = 255 }
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
                    PackageId = TheColorsModParameters.PackageId, Ids = new List<int> { 10000001, 10000902 },
                    KeypageColorOptions = new ColorOptionsRoot
                    {
                        FrameColor = new ColorRoot { R = 255, G = 255, B = 255, A = 255 },
                        TextColor = new ColorRoot { R = 255, G = 255, B = 255, A = 255 }
                    }
                },
                new KeypageOptionRoot
                {
                    PackageId = TheColorsModParameters.PackageId, Ids = new List<int> { 10000002 },
                    KeypageColorOptions = new ColorOptionsRoot
                    {
                        FrameColor = new ColorRoot { R = 127, G = 127, B = 127, A = 255 },
                        TextColor = new ColorRoot { R = 127, G = 127, B = 127, A = 255 }
                    }
                },
                new KeypageOptionRoot
                {
                    PackageId = TheColorsModParameters.PackageId, Ids = new List<int> { 10000003, 10000903 },
                    KeypageColorOptions = new ColorOptionsRoot
                    {
                        FrameColor = new ColorRoot { R = 153, G = 0, B = 0, A = 255 },
                        TextColor = new ColorRoot { R = 153, G = 0, B = 0, A = 255 }
                    }
                },
                new KeypageOptionRoot
                {
                    PackageId = TheColorsModParameters.PackageId, Ids = new List<int> { 10000004 },
                    KeypageColorOptions = new ColorOptionsRoot
                    {
                        FrameColor = new ColorRoot { R = 102, G = 176, B = 255, A = 255 },
                        TextColor = new ColorRoot { R = 102, G = 176, B = 255, A = 255 }
                    }
                },
                new KeypageOptionRoot
                {
                    PackageId = TheColorsModParameters.PackageId, Ids = new List<int> { 10000005 },
                    KeypageColorOptions = new ColorOptionsRoot
                    {
                        FrameColor = new ColorRoot { R = 153, G = 255, B = 153, A = 255 },
                        TextColor = new ColorRoot { R = 153, G = 255, B = 153, A = 255 }
                    }
                },
                new KeypageOptionRoot
                {
                    PackageId = TheColorsModParameters.PackageId, Ids = new List<int> { 10000007 },
                    KeypageColorOptions = new ColorOptionsRoot
                    {
                        FrameColor = new ColorRoot { R = 140, G = 0, B = 72, A = 255 },
                        TextColor = new ColorRoot { R = 140, G = 0, B = 72, A = 255 }
                    }
                },
                new KeypageOptionRoot
                {
                    PackageId = TheColorsModParameters.PackageId, Ids = new List<int> { 10000900, 10000901 },
                    KeypageColorOptions = new ColorOptionsRoot
                    {
                        FrameColor = new ColorRoot { R = 176, G = 102, B = 255, A = 255 },
                        TextColor = new ColorRoot { R = 176, G = 102, B = 255, A = 255 }
                    }
                }
            };
        }

        public static List<PassiveOptionRoot> PassiveOptionRoot()
        {
            return new List<PassiveOptionRoot>
            {
                new PassiveOptionRoot
                {
                    PackageId = TheColorsModParameters.PackageId, Ids = new List<int> { 1 },
                    PassiveColorOptions = new ColorOptionsRoot
                    {
                        FrameColor = new ColorRoot { R = 255, G = 255, B = 255, A = 255 },
                        TextColor = new ColorRoot { R = 255, G = 255, B = 255, A = 255 }
                    }
                },
                new PassiveOptionRoot
                {
                    PackageId = TheColorsModParameters.PackageId, Ids = new List<int> { 5 },
                    PassiveColorOptions = new ColorOptionsRoot
                    {
                        FrameColor = new ColorRoot { R = 127, G = 127, B = 127, A = 255 },
                        TextColor = new ColorRoot { R = 127, G = 127, B = 127, A = 255 }
                    }
                },
                new PassiveOptionRoot
                {
                    PackageId = TheColorsModParameters.PackageId, Ids = new List<int> { 11 },
                    PassiveColorOptions = new ColorOptionsRoot
                    {
                        FrameColor = new ColorRoot { R = 153, G = 0, B = 0, A = 255 },
                        TextColor = new ColorRoot { R = 153, G = 0, B = 0, A = 255 }
                    }
                },
                new PassiveOptionRoot
                {
                    PackageId = TheColorsModParameters.PackageId, Ids = new List<int> { 20 },
                    PassiveColorOptions = new ColorOptionsRoot
                    {
                        FrameColor = new ColorRoot { R = 102, G = 176, B = 255, A = 255 },
                        TextColor = new ColorRoot { R = 102, G = 176, B = 255, A = 255 }
                    }
                },
                new PassiveOptionRoot
                {
                    PackageId = TheColorsModParameters.PackageId, Ids = new List<int> { 23 },
                    PassiveColorOptions = new ColorOptionsRoot
                    {
                        FrameColor = new ColorRoot { R = 153, G = 255, B = 153, A = 255 },
                        TextColor = new ColorRoot { R = 153, G = 255, B = 153, A = 255 }
                    }
                },
                new PassiveOptionRoot
                {
                    PackageId = TheColorsModParameters.PackageId, Ids = new List<int> { 18 },
                    PassiveColorOptions = new ColorOptionsRoot
                    {
                        FrameColor = new ColorRoot { R = 176, G = 102, B = 255, A = 255 },
                        TextColor = new ColorRoot { R = 176, G = 102, B = 255, A = 255 }
                    }
                },
                new PassiveOptionRoot
                {
                    PackageId = TheColorsModParameters.PackageId, Ids = new List<int> { 31 },
                    PassiveColorOptions = new ColorOptionsRoot
                    {
                        FrameColor = new ColorRoot { R = 140, G = 0, B = 72, A = 255 },
                        TextColor = new ColorRoot { R = 140, G = 0, B = 72, A = 255 }
                    }
                },
                new PassiveOptionRoot
                {
                    PackageId = TheColorsModParameters.PackageId, Ids = new List<int> { 37 },
                    PassiveColorOptions = new ColorOptionsRoot
                    {
                        FrameColor = new ColorRoot { R = 255, G = 255, B = 255, A = 255 },
                        TextColor = new ColorRoot { R = 255, G = 255, B = 255, A = 255 }
                    },
                    CustomDiceColorOptions = new CustomDiceColorOptionRoot
                    {
                        IconId = "ColorsFloorDefault_C21341",
                        TextColor = new ColorRoot { R = 255, G = 255, B = 255, A = 255 }
                    }
                },
                new PassiveOptionRoot
                {
                    PackageId = TheColorsModParameters.PackageId, Ids = new List<int> { 40 },
                    PassiveColorOptions = new ColorOptionsRoot
                    {
                        FrameColor = new ColorRoot { R = 153, G = 0, B = 0, A = 255 },
                        TextColor = new ColorRoot { R = 153, G = 0, B = 0, A = 255 }
                    },
                    CustomDiceColorOptions = new CustomDiceColorOptionRoot
                    {
                        IconId = "ColorsFloorRageDefault_C21341",
                        TextColor = new ColorRoot { R = 153, G = 0, B = 0, A = 255 }
                    }
                }
            };
        }
    }
}