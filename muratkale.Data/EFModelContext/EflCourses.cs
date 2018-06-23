using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("EFL_Courses")]
    public partial class EflCourses
    {
        [Column("course_code")]
        [StringLength(50)]
        public string CourseCode { get; set; }
        [Column("section")]
        public int Section { get; set; }
        [Column("instID")]
        [StringLength(10)]
        public string InstId { get; set; }
    }
}
