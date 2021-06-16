using AdlgListApi.Models;
using AdlgListApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdlgListApi.Handlers
{
    public class AldgListHandler : IAdlgListHandler
    {
        private IListOptionRepository listOptionRepository;

        public AldgListHandler(IListOptionRepository ListOptionRepostiory)
        {
            this.listOptionRepository = ListOptionRepostiory;
        }
        public async Task<ArmyListOptions> HandleGetOptionAsync(int listId)
        {
            // Placeholder for now, plugin a repository pattern to grab the options
            // from the persistence layer corresponding to the list later
            var armyListOption = listOptionRepository.GetArmyListOptions(listId);
            return armyListOption;
        }
    }
}
