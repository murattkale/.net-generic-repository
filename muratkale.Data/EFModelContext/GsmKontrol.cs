using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("GSM_Kontrol")]
    public partial class GsmKontrol
    {
        [Key]
        [Column("stuID")]
        [StringLength(11)]
        public string StuId { get; set; }
        [Column("GSM_No")]
        [StringLength(10)]
        public string GsmNo { get; set; }
        public int? Code { get; set; }
        [Column("approve")]
        public bool? Approve { get; set; }
    }
}
