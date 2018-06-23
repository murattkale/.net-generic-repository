using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("CCR_Double_test")]
    public partial class CcrDoubleTest
    {
        [Column("StuID")]
        [StringLength(11)]
        public string StuId { get; set; }
        [Column("Program_Semester", TypeName = "char(1)")]
        public string ProgramSemester { get; set; }
        [Column("Course_Code")]
        [StringLength(20)]
        public string CourseCode { get; set; }
        [Column("Course_Title")]
        [StringLength(100)]
        public string CourseTitle { get; set; }
        public byte? Credit { get; set; }
        [StringLength(500)]
        public string History { get; set; }
        public bool Completed { get; set; }
        [Column("ProgramID")]
        [StringLength(25)]
        public string ProgramId { get; set; }
        [Column("Last_Grade", TypeName = "char(3)")]
        public string LastGrade { get; set; }
    }
}
