using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;
using KitchenData;

namespace SaltyFood.Customs.Items
{
    public class CookedLobster : CustomItem
    {
        // UniqueNameID - This is used internally to generate the ID of this GDO. Once you've set it, don't change it.
        public override string UniqueNameID => "CookedLobster";
        
        // Prefab - This is the GameObject used for this Item's visual. AssignMaterialsByNames() is a helper method that assigns materials to the GameObject based on the names of the materials.
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("Cooked Lobster").AssignMaterialsByNames();

        // SplitSubItem - What Item will this Item split into.
        public override Item SplitSubItem => (Item)GDOUtils.GetCustomGameDataObject<CookedLobsterFlesh>().GameDataObject;

        // SplitCount - How many times this Item can be split.
        public override int SplitCount => 3;
    }
}