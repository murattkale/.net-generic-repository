using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Program_Codes")]
    public partial class ProgramCodes
    {
        [Column("id")]
        public int Id { get; set; }
        [StringLength(11)]
        public string ProgramCode { get; set; }
        [Column("Yok_Birim")]
        [StringLength(25)]
        public string YokBirim { get; set; }
        [Column("birim_adi")]
        [StringLength(150)]
        public string BirimAdi { get; set; }
        [StringLength(50)]
        public string Faculty { get; set; }
        [StringLength(50)]
        public string Tur { get; set; }
        [Column("iselective")]
        public int? Iselective { get; set; }
        [StringLength(11)]
        public string Language { get; set; }
        [Column("isPrep")]
        public int? IsPrep { get; set; }
    }
}
