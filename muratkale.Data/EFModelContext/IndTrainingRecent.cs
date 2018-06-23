using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Ind_Training_Recent")]
    public partial class IndTrainingRecent
    {
        [Column("StuID")]
        [StringLength(11)]
        public string StuId { get; set; }
        [Column("Course_Code")]
        [StringLength(13)]
        public string CourseCode { get; set; }
        public bool Recent { get; set; }

        [ForeignKey("StuId")]
        [InverseProperty("IndTrainingRecent")]
        public Student Stu { get; set; }
    }
}
