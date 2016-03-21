using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spofford.Core.Domain
{
    public class TeamCreateViewModel
    {
        public int TeamID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Image { get; set; }

        public int Seed { get; set; }

        public int RegionID { get; set; }

        public int Year { get; set; }

        public int? RoundEliminated { get; set; }
    }
}
