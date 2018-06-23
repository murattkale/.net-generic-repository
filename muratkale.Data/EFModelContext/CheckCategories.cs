using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    public partial class CheckCategories
    {
        [Column("DeptID")]
        [StringLength(5)]
        public string DeptId { get; set; }
        [StringLength(25)]
        public string CheckName { get; set; }
        [Required]
        [StringLength(4)]
        public string Category { get; set; }
        [Column("Senior_Stat")]
        [StringLength(4)]
        public string SeniorStat { get; set; }
        [Column("Fresh_Stat")]
        [StringLength(4)]
        public string FreshStat { get; set; }

        [ForeignKey("DeptId")]
        [InverseProperty("CheckCategories")]
        public Department Dept { get; set; }
    }
}
