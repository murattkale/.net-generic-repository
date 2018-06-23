using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Suggested_Program")]
    public partial class SuggestedProgram
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
        [Column(TypeName = "char(2)")]
        public string Status { get; set; }
        [Required]
        [Column("Taken_For")]
        [StringLength(11)]
        public string TakenFor { get; set; }

        [ForeignKey("CourseCode")]
        [InverseProperty("SuggestedProgram")]
        public Course CourseCodeNavigation { get; set; }
        [ForeignKey("StuId")]
        [InverseProperty("SuggestedProgram")]
        public Student Stu { get; set; }
    }
}
