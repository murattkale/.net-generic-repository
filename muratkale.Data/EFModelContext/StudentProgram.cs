using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Student_Program")]
    public partial class StudentProgram
    {
        [Column("StuID")]
        [StringLength(11)]
        public string StuId { get; set; }
        [Column("Course_Code")]
        [StringLength(13)]
        public string CourseCode { get; set; }
        [Required]
        [Column(TypeName = "char(2)")]
        public string Section { get; set; }
        [Column(TypeName = "char(1)")]
        public string Origin { get; set; }
        [Required]
        [Column(TypeName = "char(2)")]
        public string Status { get; set; }
        [Required]
        [Column("Taken_For")]
        [StringLength(15)]
        public string TakenFor { get; set; }
        public int? Approved { get; set; }
    }
}
