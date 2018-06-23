using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Semester_Grades")]
    public partial class SemesterGrades
    {
        [Column("Course_Code")]
        [StringLength(50)]
        public string CourseCode { get; set; }
        [Required]
        [StringLength(2)]
        public string Section { get; set; }
        [Column("StuID")]
        [StringLength(11)]
        public string StuId { get; set; }
        [Required]
        [StringLength(10)]
        public string Grade { get; set; }
        public bool Submitted { get; set; }
        public bool Updated { get; set; }

        [ForeignKey("CourseCode")]
        [InverseProperty("SemesterGrades")]
        public Course CourseCodeNavigation { get; set; }
        [ForeignKey("Grade")]
        [InverseProperty("SemesterGrades")]
        public GradesSymbols GradeNavigation { get; set; }
        [ForeignKey("StuId")]
        [InverseProperty("SemesterGrades")]
        public Student Stu { get; set; }
    }
}
