using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    public partial class Advisor
    {
        [Key]
        [Column("StuID")]
        [StringLength(11)]
        public string StuId { get; set; }
        [Column("AdvisorID")]
        [StringLength(10)]
        public string AdvisorId { get; set; }
        [Column("AAID")]
        [StringLength(10)]
        public string Aaid { get; set; }
        [Column("FYKID")]
        [StringLength(10)]
        public string Fykid { get; set; }

        [ForeignKey("StuId")]
        [InverseProperty("Advisor")]
        public Student Stu { get; set; }
    }
}
