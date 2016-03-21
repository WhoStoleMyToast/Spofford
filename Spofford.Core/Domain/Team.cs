namespace Spofford.Core.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Team")]
    public partial class Team
    {
        public Team()
        {
            this.Entries = new HashSet<Entry>();
        }
        public int TeamID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public string Description { get; set; }

        public string Image { get; set; }

        public int Seed { get; set; }

        public int RegionID { get; set; }

        public int Year { get; set; }

        public int? RoundEliminated { get; set; }

        public virtual ICollection<Entry> Entries { get; set; }
    }
}
