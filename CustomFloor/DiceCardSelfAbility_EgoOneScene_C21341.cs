using System.Linq;
using CustomMapUtility;
using UtilLoader21341;
using UtilLoader21341.Models;
using UtilLoader21341.Util;

namespace TheColorsMod_C21341.CustomFloor
{
    public class DiceCardSelfAbility_EgoOneScene_C21341 : DiceCardSelfAbilityBase
    {
        public bool MapActivated;
        public virtual string MapModelComponent => "";
        public virtual string SkinName => "";
        public string PackageId => TheColorsModParameters.PackageId;

        public override void OnUseCard()
        {
            var mapModel = ModParameters.MapModels.FirstOrDefault(x => x.Component == MapModelComponent);
            if (!string.IsNullOrEmpty(SkinName))
            {
                owner.view.StartEgoSkinChangeEffect("Character");
                owner.view.SetAltSkin(SkinName);
            }

            ChangeToEgoMap(mapModel);
        }

        public override void OnEndAreaAttack()
        {
            if (string.IsNullOrEmpty(SkinName)) return;
            owner.view.StartEgoSkinChangeEffect("Character");
            owner.view.CreateSkin();
        }

        public void ChangeToEgoMap(MapModelRoot mapModel)
        {
            if (mapModel == null || SingletonBehavior<BattleSceneRoot>.Instance.currentMapObject.isEgo) return;
            if (MapUtil.ChangeMap(CustomMapHandler.GetCMU(PackageId), mapModel)) MapActivated = true;
        }

        public void ReturnFromEgoMap(MapModelRoot mapModel)
        {
            MapActivated = false;
            if (mapModel == null) return;
            MapUtil.ReturnFromEgoMap(CustomMapHandler.GetCMU(PackageId), mapModel.Stage,
                mapModel.OriginalMapStageIds.Select(x => x.ToLorId()).ToList());
        }

        public override void OnRoundEnd(BattleUnitModel unit, BattleDiceCardModel self)
        {
            if (!MapActivated) return;
            var mapModel = ModParameters.MapModels.FirstOrDefault(x => x.Component == MapModelComponent);
            ReturnFromEgoMap(mapModel);
        }
    }
}