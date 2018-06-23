using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    public partial class Prerequisite
    {
        [Column("Course_Code")]
        [StringLength(13)]
        public string CourseCode { get; set; }
        [StringLength(13)]
        public string Prereq { get; set; }
        [Column("Min_Grade")]
        [StringLength(2)]
        public string MinGrade { get; set; }
        [Column("Pre_Desc")]
        [StringLength(250)]
        public string PreDesc { get; set; }
    }
}
