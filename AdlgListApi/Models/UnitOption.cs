using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdlgListApi.Models
{
    public class UnitOption : Units
    {
        public int Minimum { get; set; }
        public int Maximum { get; set; }
    }
}
