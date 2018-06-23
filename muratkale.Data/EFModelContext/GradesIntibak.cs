using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("GradesINTIBAK")]
    public partial class GradesIntibak
    {
        [Column("Course_Code")]
        [StringLength(13)]
        public string CourseCode { get; set; }
        [Required]
        [Column(TypeName = "nchar(2)")]
        public string Section { get; set; }
        [Column("StuID")]
        [StringLength(11)]
        public string StuId { get; set; }
        public int Year { get; set; }
        [StringLength(8)]
        public string Semester { get; set; }
        [Required]
        [Column("Letter_Grade")]
        [StringLength(10)]
        public string LetterGrade { get; set; }
        [Column(TypeName = "char(2)")]
        public string Status { get; set; }
        [Column("Repeated_For")]
        [StringLength(15)]
        public string RepeatedFor { get; set; }
        [Column("Taken_For")]
        [StringLength(15)]
        public string TakenFor { get; set; }
        [Column("Old_Taken_For")]
        [StringLength(15)]
        public string OldTakenFor { get; set; }
    }
}
