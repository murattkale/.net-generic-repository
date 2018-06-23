using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("silinecek")]
    public partial class Silinecek
    {
        [Column("stuid")]
        [StringLength(11)]
        public string Stuid { get; set; }
        [Column("course_code")]
        [StringLength(13)]
        public string CourseCode { get; set; }
        [Required]
        [Column(TypeName = "char(2)")]
        public string Section { get; set; }
        [Column("Course_Title")]
        [StringLength(120)]
        public string CourseTitle { get; set; }
        public byte? Credit { get; set; }
        [Column(TypeName = "char(2)")]
        public string Status { get; set; }
        [Column("Taken_For")]
        [StringLength(15)]
        public string TakenFor { get; set; }
    }
}
