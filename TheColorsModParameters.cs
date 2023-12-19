using System.Collections.Generic;
using LOR_DiceSystem;

namespace TheColorsMod_C21341
{
    public static class TheColorsModParameters
    {
        public static string PackageId = "TheColorsC21341.Mod";
        public static string Path;
        public static int EgoEmotionLevel = 3;
        public static int EgoSceneCount = 2;
        public static int WonderlandCloneCount = 4;

        public static List<LorId> SaeAttackDeck = new List<LorId>
        {
            new LorId(PackageId, 18), new LorId(PackageId, 18), new LorId(PackageId, 17), new LorId(PackageId, 17),
            new LorId(PackageId, 12), new LorId(PackageId, 12), new LorId(PackageId, 13), new LorId(PackageId, 13),
            new LorId(PackageId, 902)
        };

        public static List<LorId> SaeDefDeck = new List<LorId>
        {
            new LorId(PackageId, 10), new LorId(PackageId, 10), new LorId(PackageId, 10), new LorId(PackageId, 11),
            new LorId(PackageId, 11), new LorId(PackageId, 11), new LorId(PackageId, 13), new LorId(PackageId, 13),
            new LorId(PackageId, 13)
        };

        public static List<UpgradePages> GreenHunterUpgradeDeck = new List<UpgradePages>
        {
            new UpgradePages { OldPageId = new LorId(PackageId, 47), NewPageId = new LorId(PackageId, 51) },
            new UpgradePages { OldPageId = new LorId(PackageId, 48), NewPageId = new LorId(PackageId, 54) },
            new UpgradePages { OldPageId = new LorId(PackageId, 49), NewPageId = new LorId(PackageId, 53) },
            new UpgradePages { OldPageId = new LorId(PackageId, 50), NewPageId = new LorId(PackageId, 55) }
        };

        public static List<LorId> MiyuDeck = new List<LorId>
        {
            new LorId(PackageId, 67), new LorId(PackageId, 68), new LorId(PackageId, 71), new LorId(PackageId, 72),
            new LorId(PackageId, 73), new LorId(PackageId, 74), new LorId(PackageId, 75), new LorId(PackageId, 76),
            new LorId(PackageId, 77), new LorId(PackageId, 78), new LorId(PackageId, 79)
        };

        public static Dictionary<MotionDetail, string> MiyuEffects = new Dictionary<MotionDetail, string>
        {
            { MotionDetail.J, "MiyuMagic1_C21341" },
            { MotionDetail.H, "MiyuMagic3_C21341" },
            { MotionDetail.Z, "MiyuMagic7_C21341" },
            { MotionDetail.F, "MiyuMagic11_C21341" },
            { MotionDetail.S1, "MiyuMagic8_C21341" },
            { MotionDetail.S2, "MiyuMagic9_C21341" },
            { MotionDetail.S4, "MiyuMagic2_C21341" },
            { MotionDetail.S5, "MiyuMagic6_C21341" },
            { MotionDetail.S8, "MiyuMagic12_C21341" },
            { MotionDetail.S9, "MiyuMagic10_C21341" }
        };
    }

    public class UpgradePages
    {
        public LorId NewPageId;
        public LorId OldPageId;
    }
}