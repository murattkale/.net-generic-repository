using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Proficiency_Scores")]
    public partial class ProficiencyScores
    {
        [Key]
        [Column("StuID")]
        [StringLength(11)]
        public string StuId { get; set; }
        public short Score { get; set; }
        [Required]
        [StringLength(20)]
        public string State { get; set; }

        [ForeignKey("StuId")]
        [InverseProperty("ProficiencyScores")]
        public Student Stu { get; set; }
    }
}
