using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    public partial class Passcard
    {
        [Key]
        [Column("StuID")]
        [StringLength(11)]
        public string StuId { get; set; }
        [Required]
        [Column("Pass_Type", TypeName = "char(1)")]
        public string PassType { get; set; }

        [ForeignKey("StuId")]
        [InverseProperty("Passcard")]
        public Student Stu { get; set; }
    }
}
