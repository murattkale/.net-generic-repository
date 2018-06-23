using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Same_Courses")]
    public partial class SameCourses
    {
        [Column("Course_Code")]
        [StringLength(13)]
        public string CourseCode { get; set; }
        [Column("Same_Course")]
        [StringLength(13)]
        public string SameCourse { get; set; }
    }
}
