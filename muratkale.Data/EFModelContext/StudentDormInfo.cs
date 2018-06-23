using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Student_Dorm_info")]
    public partial class StudentDormInfo
    {
        [Column("stuid")]
        [StringLength(11)]
        public string Stuid { get; set; }
        [Column("type")]
        [StringLength(50)]
        public string Type { get; set; }
        [Column("block", TypeName = "nchar(1)")]
        public string Block { get; set; }
        [Column("room", TypeName = "nchar(4)")]
        public string Room { get; set; }
        [Column("year", TypeName = "nchar(4)")]
        public string Year { get; set; }
        [Column("semester", TypeName = "nchar(6)")]
        public string Semester { get; set; }
        [Column("drop_type")]
        [StringLength(50)]
        public string DropType { get; set; }

        [ForeignKey("Stuid,Year,Semester,DropType")]
        [InverseProperty("InverseStudentDormInfoNavigation")]
        public StudentDormInfo StudentDormInfoNavigation { get; set; }
        [InverseProperty("StudentDormInfoNavigation")]
        public StudentDormInfo InverseStudentDormInfoNavigation { get; set; }
    }
}
