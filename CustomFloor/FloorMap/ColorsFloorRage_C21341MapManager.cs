using CustomMapUtility;
using UnityEngine;

namespace TheColorsMod_C21341.CustomFloor.FloorMap
{
    public class ColorsFloorRage_C21341MapManager : CustomMapManager
    {
        protected override string[] CustomBGMs => new[]
            { "TheColorsTheme3_C21341.ogg", "TheColorsTheme4_C21341.ogg", "TheColorsTheme5_C21341.ogg" };

        public override void EnableMap(bool b)
        {
            sephirahColor = Color.black;
            base.EnableMap(b);
        }
    }
}