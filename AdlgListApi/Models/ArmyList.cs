using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdlgListApi.Models
{
    public class ArmyList
    {
        private IEnumerable<Units> unitOptions;
        public string Desciption { get; set; }
        public IEnumerable<Units> UnitOptions { get => unitOptions; set => unitOptions = value; }
    }
}
