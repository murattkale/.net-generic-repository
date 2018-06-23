using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    public partial class Teams
    {
        public Teams()
        {
            TeamPlayers = new HashSet<TeamPlayers>();
        }

        [Key]
        [Column("TeamID")]
        public int TeamId { get; set; }
        [Required]
        [Column("Team_Name")]
        [StringLength(50)]
        public string TeamName { get; set; }

        [InverseProperty("Team")]
        public ICollection<TeamPlayers> TeamPlayers { get; set; }
    }
}
