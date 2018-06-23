using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    public partial class Regulations
    {
        [Column("referans")]
        public int Referans { get; set; }
        [Required]
        [StringLength(5)]
        public string ArticleNo { get; set; }
        [Required]
        [StringLength(500)]
        public string Article { get; set; }
        [Column("Violation_Type", TypeName = "nchar(10)")]
        public string ViolationType { get; set; }
        [Column(TypeName = "nchar(100)")]
        public string Violation { get; set; }
        [Column("DeptID")]
        [StringLength(5)]
        public string DeptId { get; set; }

        [ForeignKey("DeptId")]
        [InverseProperty("Regulations")]
        public Department Dept { get; set; }
    }
}
