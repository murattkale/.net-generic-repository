using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Hold_Desc")]
    public partial class HoldDesc
    {
        public HoldDesc()
        {
            Holds = new HashSet<Holds>();
        }

        [Key]
        [Column("Hold_Type")]
        [StringLength(50)]
        public string HoldType { get; set; }
        [Required]
        [Column("Hold_Description")]
        [StringLength(255)]
        public string HoldDescription { get; set; }

        [InverseProperty("HoldTypeNavigation")]
        public ICollection<Holds> Holds { get; set; }
    }
}
