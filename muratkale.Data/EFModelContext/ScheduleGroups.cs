using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Schedule_Groups")]
    public partial class ScheduleGroups
    {
        [Column("Group_Code")]
        [StringLength(10)]
        public string GroupCode { get; set; }
        [Column("Course_Code")]
        [StringLength(50)]
        public string CourseCode { get; set; }
        [Column(TypeName = "char(2)")]
        public string Section { get; set; }

        [ForeignKey("CourseCode")]
        [InverseProperty("ScheduleGroups")]
        public Course CourseCodeNavigation { get; set; }
    }
}
