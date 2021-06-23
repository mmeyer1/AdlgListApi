using AdlgListApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdlgListApi.Repositories
{
    public interface IListOptionRepository
    {
        public ArmyListOptions GetArmyListOptions(int id);
    }
}
