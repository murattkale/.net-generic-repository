using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Stu_Sport")]
    public partial class StuSport
    {
        [Key]
        [Column("StuID")]
        [StringLength(11)]
        public string StuId { get; set; }
        [Column("Garment_Size")]
        [StringLength(3)]
        public string GarmentSize { get; set; }
        [Column("Foot_Size")]
        public int? FootSize { get; set; }
        public int? Branch { get; set; }
        [Column("Beginning_Year")]
        public int? BeginningYear { get; set; }
        [Column("Training_Regularity")]
        [StringLength(25)]
        public string TrainingRegularity { get; set; }

        [ForeignKey("Branch")]
        [InverseProperty("StuSport")]
        public SportsBranch BranchNavigation { get; set; }
    }
}
