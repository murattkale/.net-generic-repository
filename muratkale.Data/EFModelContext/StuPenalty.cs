using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Stu_Penalty")]
    public partial class StuPenalty
    {
        [Column("StuID")]
        [StringLength(11)]
        public string StuId { get; set; }
        [Column("PenaltyID")]
        public int PenaltyId { get; set; }
        [Column("Penalty_Date", TypeName = "datetime")]
        public DateTime PenaltyDate { get; set; }
        [Column(TypeName = "text")]
        public string Description { get; set; }
        [Column("Start_Date", TypeName = "datetime")]
        public DateTime? StartDate { get; set; }
        [Column("Finish_Date", TypeName = "datetime")]
        public DateTime? FinishDate { get; set; }

        [ForeignKey("PenaltyId")]
        [InverseProperty("StuPenalty")]
        public Penalties Penalty { get; set; }
        [ForeignKey("StuId")]
        [InverseProperty("StuPenalty")]
        public Student Stu { get; set; }
    }
}
