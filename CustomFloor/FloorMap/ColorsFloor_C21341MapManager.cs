using CustomMapUtility;
using UnityEngine;

namespace TheColorsMod_C21341.CustomFloor.FloorMap
{
    public class ColorsFloor_C21341MapManager : CustomMapManager
    {
        protected override string[] CustomBGMs => new[] { "HayatePhase1_Re21341.ogg", "HayatePhase2_Re21341.ogg" };

        public override void EnableMap(bool b)
        {
            sephirahColor = Color.black;
            base.EnableMap(b);
        }
    }
}