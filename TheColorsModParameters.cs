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
    }
}