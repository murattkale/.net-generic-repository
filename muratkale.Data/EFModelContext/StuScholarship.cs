using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Stu_Scholarship")]
    public partial class StuScholarship
    {
        [Column("RecordID")]
        public int RecordId { get; set; }
        [Column("StuID")]
        [StringLength(11)]
        public string StuId { get; set; }
        [Column("ScholarshipID")]
        public int ScholarshipId { get; set; }
        public int Year { get; set; }
        [StringLength(10)]
        public string Semester { get; set; }
        public bool? Active { get; set; }
        [StringLength(255)]
        public string Description { get; set; }

        [ForeignKey("ScholarshipId")]
        [InverseProperty("StuScholarship")]
        public Scholarship Scholarship { get; set; }
        [ForeignKey("StuId")]
        [InverseProperty("StuScholarship")]
        public Student Stu { get; set; }
    }
}
