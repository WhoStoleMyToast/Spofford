namespace Spofford.Core.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Entry")]
    public partial class Entry
    {
        public Entry()
        {
            this.Teams = new HashSet<Team>();
        }

        public int EntryID { get; set; }

        public int PlayerID { get; set; }

        public int Year { get; set; }

        public virtual Player Player { get; set; }

        public virtual ICollection<Team> Teams { get; set; }
    }
}
