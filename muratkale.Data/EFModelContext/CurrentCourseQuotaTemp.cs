using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Current_Course_Quota_Temp")]
    public partial class CurrentCourseQuotaTemp
    {
        [Column("Course_Code")]
        [StringLength(13)]
        public string CourseCode { get; set; }
        [Column(TypeName = "char(2)")]
        public string Section { get; set; }
        [Required]
        [StringLength(10)]
        public string Constraint { get; set; }
        [StringLength(10)]
        public string Group { get; set; }
        public short Quota { get; set; }
        public short Captured { get; set; }
        public short Sold { get; set; }
        public short Reserved { get; set; }
    }
}
