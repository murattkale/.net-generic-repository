using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    public partial class Grades
    {
        [Column("Course_Code")]
        [StringLength(50)]
        public string CourseCode { get; set; }
        [Required]
        [Column(TypeName = "nchar(2)")]
        public string Section { get; set; }
        [Column("StuID")]
        [StringLength(11)]
        public string StuId { get; set; }
        public int Year { get; set; }
        [StringLength(25)]
        public string Semester { get; set; }
        [Required]
        [Column("Letter_Grade")]
        [StringLength(10)]
        public string LetterGrade { get; set; }
        [Column(TypeName = "char(2)")]
        public string Status { get; set; }
        [Column("Repeated_For")]
        [StringLength(50)]
        public string RepeatedFor { get; set; }
        [Column("Taken_For")]
        [StringLength(25)]
        public string TakenFor { get; set; }

        [ForeignKey("LetterGrade")]
        [InverseProperty("Grades")]
        public GradesSymbols LetterGradeNavigation { get; set; }
    }
}
