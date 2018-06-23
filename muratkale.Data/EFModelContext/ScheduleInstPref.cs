using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Schedule_Inst_Pref")]
    public partial class ScheduleInstPref
    {
        [Column("InstID")]
        [StringLength(10)]
        public string InstId { get; set; }
        [StringLength(2)]
        public string Day { get; set; }
        public byte Hour { get; set; }

        [ForeignKey("InstId")]
        [InverseProperty("ScheduleInstPref")]
        public Instructor Inst { get; set; }
    }
}
