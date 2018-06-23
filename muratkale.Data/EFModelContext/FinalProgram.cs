using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Final_Program")]
    public partial class FinalProgram
    {
        [Column("StuID")]
        [StringLength(11)]
        public string StuId { get; set; }
        [Column("Course_Code")]
        [StringLength(50)]
        public string CourseCode { get; set; }
        [Required]
        [Column(TypeName = "char(2)")]
        public string Section { get; set; }
        [Required]
        [Column("Course_Title")]
        [StringLength(120)]
        public string CourseTitle { get; set; }
        public byte? Credit { get; set; }
        [Required]
        [Column(TypeName = "char(2)")]
        public string Status { get; set; }
        [Required]
        [Column("Taken_For")]
        [StringLength(20)]
        public string TakenFor { get; set; }

        [ForeignKey("CourseCode")]
        [InverseProperty("FinalProgram")]
        public Course CourseCodeNavigation { get; set; }
        [ForeignKey("StuId")]
        [InverseProperty("FinalProgram")]
        public Student Stu { get; set; }
    }
}
