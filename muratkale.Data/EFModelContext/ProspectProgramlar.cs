using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("prospect_programlar")]
    public partial class ProspectProgramlar
    {
        [Key]
        [Column("sira")]
        public int Sira { get; set; }
        [Column("ProgramAdi_Tur")]
        [StringLength(100)]
        public string ProgramAdiTur { get; set; }
        [Column("Tur_Name")]
        [StringLength(50)]
        public string TurName { get; set; }
        [StringLength(50)]
        public string Tipi { get; set; }
        public bool? Tezli { get; set; }
        [Column("FactID")]
        public int? FactId { get; set; }
        public int? ProgramCode { get; set; }
        [StringLength(100)]
        public string Birim { get; set; }
        public int? YokBirim { get; set; }
    }
}
