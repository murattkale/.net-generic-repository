using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Final_Exam_Room")]
    public partial class FinalExamRoom
    {
        [Column("Course_Code")]
        [StringLength(50)]
        public string CourseCode { get; set; }
        [Column(TypeName = "char(2)")]
        public string Section { get; set; }
        [Column("Exam_Room", TypeName = "nchar(10)")]
        public string ExamRoom { get; set; }

        [ForeignKey("CourseCode")]
        [InverseProperty("FinalExamRoom")]
        public Course CourseCodeNavigation { get; set; }
    }
}
