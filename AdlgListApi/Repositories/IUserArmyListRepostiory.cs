using AdlgListApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdlgListApi.Repositories
{
    public interface IUserArmyListRepostiory
    {
        public UserArmyList GetUserArmyList(int listId, int userId);

        public UserArmyList CreateUserArmyList(int userId, int selectedListId);

        public bool DeleteUserArmyList(int userId, int listId);

        public UnitSelection AddUnit(int userId, int listId, UnitSelection newUnit);

        public bool DeleteUnit(int userId, int listId, int unitIdToDelete);

        public UnitSelection EditUnit(int userId, int listId, UnitSelection editedUnit);
    }
}
