namespace Spofford.Core.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Player")]
    public partial class Player
    {
        public int PlayerID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public bool HasPaid { get; set; }
    }
}
