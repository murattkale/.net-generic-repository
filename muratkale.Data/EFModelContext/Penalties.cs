using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    public partial class Penalties
    {
        public Penalties()
        {
            StuPenalty = new HashSet<StuPenalty>();
        }

        [Key]
        [Column("PenaltyID")]
        public int PenaltyId { get; set; }
        [Required]
        [Column("Penalty_Desc")]
        [StringLength(50)]
        public string PenaltyDesc { get; set; }

        [InverseProperty("Penalty")]
        public ICollection<StuPenalty> StuPenalty { get; set; }
    }
}
