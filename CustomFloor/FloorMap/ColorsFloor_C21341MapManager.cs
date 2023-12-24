using CustomMapUtility;
using UnityEngine;

namespace TheColorsMod_C21341.CustomFloor.FloorMap
{
    public class ColorsFloor_C21341MapManager : CustomMapManager
    {
        protected override string[] CustomBGMs => new[] { "TheColorsTheme1_C21341.ogg", "TheColorsTheme2_C21341.ogg" };

        public override void EnableMap(bool b)
        {
            sephirahColor = Color.black;
            base.EnableMap(b);
        }
    }
}