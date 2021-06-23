using AdlgListApi.Enums;
using AdlgListApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdlgListApi.Repositories
{
    public class InMemoryUserArmyListRepository : IUserArmyListRepostiory
    {
        private List<UserArmyList> inMemoryList = new List<UserArmyList> { new UserArmyList
            {
                Id = 1,
                UserId = 1,
                ListId = 1,
                Desciption = "a test list",
                UnitSelections = new List<UnitSelection>
                {
                    new UnitSelection
                    {
                        Cost = 2,
                        Quantity = 4,
                        UnitType = UnitTypes.Bowmen,
                        UnitDescription = "Some hairy bowmen",
                        UnitModifiers = new List<UnitModifiers> { UnitModifiers.None
    }
}
                }
            } };

        public UnitSelection AddUnit(int userId, int listId, UnitSelection newUnit)
        {
            var list = GetUserArmyList(listId, userId);
            if (list == null)
            {
                throw new InvalidOperationException();
            }

            list.UnitSelections.Add(newUnit);

            return newUnit;
        }

        public UserArmyList CreateUserArmyList(int userId, int selectedListId)
        {
            var newArmyList = new UserArmyList
            {
                UserId = userId,
                ListId = selectedListId,
                Id = inMemoryList.Count() + 1
            };

            return newArmyList;
        }

        public bool DeleteUnit(int userId, int listId, int unitIdToDelete)
        {
            var list = GetUserArmyList(listId, userId);
            if (list == null)
            {
                throw new InvalidOperationException();
            }

            var removed = list.UnitSelections.RemoveAll(unit => unitIdToDelete == unit.Id);

            return removed > 0;
        }

        public bool DeleteUserArmyList(int userId, int listId)
        {
            var removed = inMemoryList.RemoveAll(userLists => userLists.Id == listId && userLists.UserId == userId);
            return removed > 0;
        }

        public UnitSelection EditUnit(int userId, int listId, UnitSelection editedUnit)
        {
            var list = GetUserArmyList(listId, userId);
            if (list == null)
            {
                throw new InvalidOperationException();
            }

            var removed = list.UnitSelections.RemoveAll(unit => unit.Id == editedUnit.Id);
            if (removed > 0 )
            {
                list.UnitSelections.Add(editedUnit);
                return editedUnit;
            } else
            {
                throw new InvalidOperationException();
            }
        }

        public UserArmyList GetUserArmyList(int listId, int userId)
        {
            var foundList = inMemoryList.FirstOrDefault(li => li.Id == listId && li.UserId == userId);
            return foundList;
        }
    }
}
