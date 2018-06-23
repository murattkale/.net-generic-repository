using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("GRS_PUAN_TUR")]
    public partial class GrsPuanTur
    {
        [Key]
        [Column("KOD")]
        [StringLength(20)]
        public string Kod { get; set; }
        [Column("AD")]
        [StringLength(30)]
        public string Ad { get; set; }
    }
}
