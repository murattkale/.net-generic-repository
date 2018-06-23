using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Course_Requirements")]
    public partial class CourseRequirements
    {
        [Column("Course_Code")]
        [StringLength(50)]
        public string CourseCode { get; set; }
        [StringLength(13)]
        public string Prereq { get; set; }
        [Column("Min_Grade")]
        [StringLength(2)]
        public string MinGrade { get; set; }
        [Column("Requirement_Type")]
        [StringLength(20)]
        public string RequirementType { get; set; }

        [ForeignKey("CourseCode")]
        [InverseProperty("CourseRequirements")]
        public Course CourseCodeNavigation { get; set; }
    }
}
