using AdlgListApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdlgListApi.Handlers
{
    public class AldgListHandler : IAdlgListHandler
    {
        public async Task<ArmyListOptions> HandleGetOptionAsync(int listId)
        {
            // Placeholder for now, plugin a repository pattern to grab the options corresponding to the list later
            var armyListOption = new ArmyListOptions { Desciption = listId.ToString()};
            return armyListOption;
        }
    }
}
