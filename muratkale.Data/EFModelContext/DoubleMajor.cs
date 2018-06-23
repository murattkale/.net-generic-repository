using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Double_Major")]
    public partial class DoubleMajor
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
        [Column("DMAdvisor")]
        [StringLength(10)]
        public string Dmadvisor { get; set; }
        [Required]
        [Column("DMAA")]
        [StringLength(10)]
        public string Dmaa { get; set; }
        [Required]
        [Column("DMFYK")]
        [StringLength(10)]
        public string Dmfyk { get; set; }
        [Column("DiplomaID")]
        [StringLength(20)]
        public string DiplomaId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LeavingDate { get; set; }
        [StringLength(15)]
        public string Major { get; set; }
        [Column("DoubleMajor")]
        [StringLength(15)]
        public string DoubleMajor1 { get; set; }

        [ForeignKey("ProgramId")]
        [InverseProperty("DoubleMajor")]
        public ProgramDepts Program { get; set; }
        [ForeignKey("StuId")]
        [InverseProperty("DoubleMajor")]
        public Student Stu { get; set; }
    }
}
