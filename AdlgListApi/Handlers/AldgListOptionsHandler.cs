using AdlgListApi.Models;
using AdlgListApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdlgListApi.Handlers
{
    public class AldgListOptionsHandler : IAdlgListOptionsHandler
    {
        private IListOptionRepository listOptionRepository;

        private IUserArmyListRepostiory userArmyListRepository;

        public AldgListOptionsHandler(IListOptionRepository ListOptionRepostiory, IUserArmyListRepostiory UserArmyListRepository)
        {
            this.listOptionRepository = ListOptionRepostiory;
            this.userArmyListRepository = UserArmyListRepository;
        }
        public async Task<ArmyListOptions> HandleGetOptionAsync(int listId)
        {
            var armyListOption = listOptionRepository.GetArmyListOptions(listId);
            return armyListOption;
        }

        public async Task<UserArmyList> HandleGetUserArmyList(int userId, int listId)
        {
            var userArmyList = userArmyListRepository.GetUserArmyList(listId, userId);
            return userArmyList;
        }
    }
}
