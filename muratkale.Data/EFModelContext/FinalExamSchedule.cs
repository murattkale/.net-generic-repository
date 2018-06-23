using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Final_Exam_Schedule")]
    public partial class FinalExamSchedule
    {
        [Column("Course_Code")]
        [StringLength(50)]
        public string CourseCode { get; set; }
        [Column(TypeName = "char(2)")]
        public string Section { get; set; }
        [Required]
        [Column("Exam_Date")]
        [StringLength(2)]
        public string ExamDate { get; set; }
        [Column("Exam_Slot")]
        public byte ExamSlot { get; set; }

        [ForeignKey("CourseCode")]
        [InverseProperty("FinalExamSchedule")]
        public Course CourseCodeNavigation { get; set; }
    }
}
