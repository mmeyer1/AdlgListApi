using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdlgListApi.Models
{
    public class UserArmyList 
    {
        public UserArmyList()
        {
            unitSelections = new List<UnitSelection>();
        }

        private List<UnitSelection> unitSelections;
        public int UserId { get; set; }

        public int Id { get; set; }
        public int ListId { get; set; }
        public string Desciption { get; set; }
        public List<UnitSelection> UnitSelections { get => unitSelections; set => unitSelections = value; }
    }
}
