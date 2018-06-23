using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    public partial class Minor
    {
        [Key]
        [Column("StuID")]
        [StringLength(11)]
        public string StuId { get; set; }
        [Required]
        [Column("ProgramID")]
        [StringLength(25)]
        public string ProgramId { get; set; }
        [Required]
        [Column("MAdvisor")]
        [StringLength(10)]
        public string Madvisor { get; set; }
        [Required]
        [Column("MAA")]
        [StringLength(10)]
        public string Maa { get; set; }
        [Required]
        [Column("MFYK")]
        [StringLength(10)]
        public string Mfyk { get; set; }

        [ForeignKey("ProgramId")]
        [InverseProperty("Minor")]
        public ProgramDepts Program { get; set; }
        [ForeignKey("StuId")]
        [InverseProperty("Minor")]
        public Student Stu { get; set; }
    }
}
