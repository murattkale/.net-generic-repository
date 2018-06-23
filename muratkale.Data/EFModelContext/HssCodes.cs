using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("HSS_Codes")]
    public partial class HssCodes
    {
        [Key]
        [Column("HSS_Code")]
        [StringLength(20)]
        public string HssCode { get; set; }
    }
}
