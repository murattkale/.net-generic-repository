using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Stu_Semester")]
    public partial class StuSemester
    {
        [Key]
        [Column("stuID")]
        [StringLength(11)]
        public string StuId { get; set; }
        [Column("semesterCount")]
        public int? SemesterCount { get; set; }
        [Column("hazirlikSemester")]
        public int? HazirlikSemester { get; set; }
        [Column("hazirlikdurum")]
        public int? Hazirlikdurum { get; set; }
    }
}
