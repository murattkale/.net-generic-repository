using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Reg_Iterations")]
    public partial class RegIterations
    {
        [Column("StuID")]
        [StringLength(11)]
        public string StuId { get; set; }
        [Column(TypeName = "char(1)")]
        public string Period { get; set; }
        public short Iteration { get; set; }
        public bool Used { get; set; }

        [ForeignKey("StuId")]
        [InverseProperty("RegIterations")]
        public Student Stu { get; set; }
    }
}
