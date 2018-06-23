using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Master_Thesis")]
    public partial class MasterThesis
    {
        [Key]
        [Column("StuID")]
        [StringLength(11)]
        public string StuId { get; set; }
        [Column("InstID")]
        [StringLength(10)]
        public string InstId { get; set; }
        [Column("Thesis_Issue")]
        [StringLength(255)]
        public string ThesisIssue { get; set; }
        [Column("Course_Code")]
        [StringLength(35)]
        public string CourseCode { get; set; }
    }
}
