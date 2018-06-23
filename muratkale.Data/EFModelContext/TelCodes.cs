using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    public partial class TelCodes
    {
        [Key]
        [Column(TypeName = "char(3)")]
        public string TelCode { get; set; }
        [Column("type")]
        [StringLength(5)]
        public string Type { get; set; }
    }
}
