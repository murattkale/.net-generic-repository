using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Substitution_Stu")]
    public partial class SubstitutionStu
    {
        [Column("Course_Code")]
        [StringLength(13)]
        public string CourseCode { get; set; }
        [StringLength(12)]
        public string Substitute { get; set; }
        [Column("StuID")]
        [StringLength(11)]
        public string StuId { get; set; }
    }
}
