using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    public partial class Electives
    {
        [Column("HSS_Code")]
        [StringLength(20)]
        public string HssCode { get; set; }
        [Column("Course_Code")]
        [StringLength(13)]
        public string CourseCode { get; set; }
        [Column("DeptID")]
        [StringLength(5)]
        public string DeptId { get; set; }
        public byte Credit { get; set; }
        [Column("Elec_Title")]
        [StringLength(35)]
        public string ElecTitle { get; set; }

        [ForeignKey("DeptId")]
        [InverseProperty("Electives")]
        public Department Dept { get; set; }
    }
}
