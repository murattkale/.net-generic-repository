using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Dept_Power_Users")]
    public partial class DeptPowerUsers
    {
        [Column("DeptID")]
        [StringLength(5)]
        public string DeptId { get; set; }
        [Column("UserID")]
        [StringLength(10)]
        public string UserId { get; set; }

        [ForeignKey("DeptId")]
        [InverseProperty("DeptPowerUsers")]
        public Department Dept { get; set; }
        [ForeignKey("UserId")]
        [InverseProperty("DeptPowerUsers")]
        public Staff User { get; set; }
    }
}
