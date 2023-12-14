using System.Collections.Generic;

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
    }

    public class UpgradePages
    {
        public LorId NewPageId;
        public LorId OldPageId;
    }
}