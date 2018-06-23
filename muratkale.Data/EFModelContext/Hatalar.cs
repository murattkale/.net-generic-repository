using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("hatalar")]
    public partial class Hatalar
    {
        [Key]
        [Column("stuID")]
        [StringLength(12)]
        public string StuId { get; set; }
        [Column("hatalist", TypeName = "text")]
        public string Hatalist { get; set; }
        [Column("approvedby")]
        [StringLength(100)]
        public string Approvedby { get; set; }
    }
}
