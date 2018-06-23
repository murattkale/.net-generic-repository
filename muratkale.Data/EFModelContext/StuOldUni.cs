using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Stu_Old_Uni")]
    public partial class StuOldUni
    {
        [Column("StuID")]
        [StringLength(11)]
        public string StuId { get; set; }
        [StringLength(100)]
        public string Institution { get; set; }
        [StringLength(50)]
        public string Faculty { get; set; }
        [StringLength(50)]
        public string Department { get; set; }
        [Column("Entry_Year")]
        public int EntryYear { get; set; }
        [Column("Exit_Year")]
        public int ExitYear { get; set; }
        [Column("derece")]
        [StringLength(20)]
        public string Derece { get; set; }
        [Column("mezun_mu")]
        public bool? MezunMu { get; set; }
    }
}
