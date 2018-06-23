using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("GSMTelCodes")]
    public partial class GsmtelCodes
    {
        [Key]
        [Column("GSMTelCode", TypeName = "char(3)")]
        public string GsmtelCode { get; set; }
    }
}
