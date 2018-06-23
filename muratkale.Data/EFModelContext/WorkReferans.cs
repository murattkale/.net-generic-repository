using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("work_referans")]
    public partial class WorkReferans
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("stuID")]
        [StringLength(11)]
        public string StuId { get; set; }
        [Column("ref_Ad")]
        [StringLength(50)]
        public string RefAd { get; set; }
        [Column("ref_iletisim")]
        [StringLength(150)]
        public string RefIletisim { get; set; }
    }
}
