using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Placement_Scores")]
    public partial class PlacementScores
    {
        [Key]
        [Column("StuID")]
        [StringLength(11)]
        public string StuId { get; set; }
        public short Score { get; set; }
        [StringLength(20)]
        public string State { get; set; }

        [ForeignKey("StuId")]
        [InverseProperty("PlacementScores")]
        public Student Stu { get; set; }
    }
}
