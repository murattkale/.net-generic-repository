using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    public partial class HazirlikSinav
    {
        [Key]
        [Column("stuid")]
        [StringLength(11)]
        public string Stuid { get; set; }
        [Required]
        [Column("hazirlikistek")]
        [StringLength(10)]
        public string Hazirlikistek { get; set; }
        [Required]
        [Column("sinavistek")]
        [StringLength(10)]
        public string Sinavistek { get; set; }
    }
}
