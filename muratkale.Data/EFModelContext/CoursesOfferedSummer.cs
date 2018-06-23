using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Courses_Offered_Summer")]
    public partial class CoursesOfferedSummer
    {
        [Column("Course_Code")]
        [StringLength(13)]
        public string CourseCode { get; set; }
        [Column(TypeName = "char(2)")]
        public string Section { get; set; }
        [Column("Course_Title")]
        [StringLength(120)]
        public string CourseTitle { get; set; }
        [Column("Course_Credit")]
        public int? CourseCredit { get; set; }
        [StringLength(10)]
        public string Instructor { get; set; }
        [StringLength(160)]
        public string Schedule { get; set; }
        [Column("Course_Dept")]
        [StringLength(10)]
        public string CourseDept { get; set; }
        [Column("Course_Type")]
        [StringLength(15)]
        public string CourseType { get; set; }
        [Column("RoomID")]
        [StringLength(255)]
        public string RoomId { get; set; }
        [StringLength(5)]
        public string Exam { get; set; }
        [Column("Offered_To")]
        [StringLength(150)]
        public string OfferedTo { get; set; }
        public bool? Closed { get; set; }
    }
}
