using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spofford.Core.Domain
{
    public class EntryCreateViewModel
    {
        public EntryCreateViewModel()
        {
            this.Teams = new HashSet<TeamCreateViewModel>();
        }

        public int EntryID { get; set; }

        public int PlayerID { get; set; }

        public int Year { get; set; }

        public virtual Player Player { get; set; }

        public virtual ICollection<TeamCreateViewModel> Teams { get; set; }
    }
}
