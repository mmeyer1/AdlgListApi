using AdlgListApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdlgListApi.Handlers
{
    public interface IAdlgListOptionsHandler
    {
        public Task<ArmyListOptions> HandleGetOptionAsync(int listId);
    }
}
