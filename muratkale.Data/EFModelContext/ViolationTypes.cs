using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Violation_Types")]
    public partial class ViolationTypes
    {
        [Column("DeptID")]
        [StringLength(10)]
        public string DeptId { get; set; }
        [StringLength(25)]
        public string Violation { get; set; }
        [Column("Stu_Status")]
        [StringLength(12)]
        public string StuStatus { get; set; }
        [Column("Stu_Standing", TypeName = "char(1)")]
        public string StuStanding { get; set; }
        [Column(TypeName = "char(1)")]
        public string Period { get; set; }
        [Required]
        [Column("Violation_Type")]
        [StringLength(10)]
        public string ViolationType { get; set; }
        [Column("GPA_Limit")]
        public double GpaLimit { get; set; }
    }
}
