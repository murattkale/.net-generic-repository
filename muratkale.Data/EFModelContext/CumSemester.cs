using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Cum_Semester")]
    public partial class CumSemester
    {
        [Column("StuID")]
        [StringLength(11)]
        public string StuId { get; set; }
        public int Year { get; set; }
        [StringLength(25)]
        public string Semester { get; set; }
        [Column("Cr_Att")]
        public int CrAtt { get; set; }
        [Column("Cr_Comp")]
        public int? CrComp { get; set; }
        [Column("Pts_Earned")]
        public double PtsEarned { get; set; }
        [Column("SPA")]
        public double Spa { get; set; }

        [ForeignKey("StuId")]
        [InverseProperty("CumSemester")]
        public Student Stu { get; set; }
    }
}
