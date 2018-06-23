using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Team_Players")]
    public partial class TeamPlayers
    {
        [Column("StuID")]
        [StringLength(11)]
        public string StuId { get; set; }
        [Column("TeamID")]
        public int TeamId { get; set; }

        [ForeignKey("TeamId")]
        [InverseProperty("TeamPlayers")]
        public Teams Team { get; set; }
    }
}
