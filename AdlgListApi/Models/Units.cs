using AdlgListApi.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdlgListApi.Models
{
    public class Units
    {
        private IEnumerable<UnitModifiers> unitModifiers;
        public string UnitDescription { get; set; }
        public UnitTypes UnitType { get; set; }
        public IEnumerable<UnitModifiers> UnitModifiers { get => unitModifiers; set => unitModifiers = value; }
        public int Cost { get; set; }
        public int Minimum { get; set; }
        public int Maximum { get; set; }
    }
}
