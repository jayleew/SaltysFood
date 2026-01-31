using System.Collections.Generic;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.References;
using KitchenLib.Utils;
using UnityEngine;

namespace SaltyFood.Customs.Items
{
    public class CookedTortilla : CustomItem
    {
        // UniqueNameID - This is used internally to generate the ID of this GDO. Once you've set it, don't change it.
        public override string UniqueNameID => "CookedTortilla";
        
        // Prefab - This is the GameObject used for this Item's visual. AssignMaterialsByNames() is a helper method that assigns materials to the GameObject based on the names of the materials.
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("Cooked Tortilla").AssignMaterialsByNames();

        public override List<Item.ItemProcess> Processes => new List<Item.ItemProcess>
        {
            new Item.ItemProcess
            {
                Duration = 2,
                Process = (Process)GDOUtils.GetExistingGDO(ProcessReferences.Chop),
                Result = (Item)GDOUtils.GetCustomGameDataObject<CookedChips>().GameDataObject
            }
        };
    }
}