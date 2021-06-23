using AdlgListApi.Enums;
using AdlgListApi.Models;
using AdlgListApi.Repositories;
using System.Collections.Generic;

namespace AdlgListApi
{
    public class InMemoryRepository : IListOptionRepository
    {
        private ArmyListOptions inMemoryArmyListOption = new ArmyListOptions();
        public ArmyListOptions GetArmyListOptions(int listId)
        {
            inMemoryArmyListOption.Desciption = "TEST In Memory Army list option set";
            inMemoryArmyListOption.UnitOptions.Add(new UnitOption
            {
                Cost = 3,
                Maximum = 4,
                Minimum = 1,
                UnitDescription = "Scary Sword Dudes",
                UnitType = UnitTypes.Heavy_Swordsmen,
                UnitModifiers = new List<UnitModifiers>() { UnitModifiers.Armored }
            });

            inMemoryArmyListOption.UnitOptions.Add(new UnitOption
            {
                Cost = 1,
                Maximum = 8,
                Minimum = 0,
                UnitDescription = "Not Scary Spearmen",
                UnitType = UnitTypes.Medium_Spearmen,
                UnitModifiers = new List<UnitModifiers>() { UnitModifiers.None }
            });

            return inMemoryArmyListOption;
        }
    }
}
