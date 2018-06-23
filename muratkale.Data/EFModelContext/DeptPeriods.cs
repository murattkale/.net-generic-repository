using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Dept_Periods")]
    public partial class DeptPeriods
    {
        [Key]
        [Column("DeptID")]
        [StringLength(5)]
        public string DeptId { get; set; }
        [Required]
        [Column(TypeName = "char(1)")]
        public string Period { get; set; }

        [ForeignKey("DeptId")]
        [InverseProperty("DeptPeriods")]
        public Department Dept { get; set; }
    }
}
