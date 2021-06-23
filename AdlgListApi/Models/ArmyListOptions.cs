using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdlgListApi.Models
{
    public class ArmyListOptions
    {
        public ArmyListOptions()
        {
            unitOptions = new List<UnitOption>();
        }

        private List<UnitOption> unitOptions;
        public string Desciption { get; set; }
        public List<UnitOption> UnitOptions { get => unitOptions; set => unitOptions = value; }
    }
}
