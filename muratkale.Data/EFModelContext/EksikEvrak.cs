using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("eksik_evrak")]
    public partial class EksikEvrak
    {
        [Key]
        [Column("StuID")]
        [StringLength(11)]
        public string StuId { get; set; }
        [Required]
        [Column("eksik_evrak")]
        [StringLength(250)]
        public string EksikEvrak1 { get; set; }
        [Required]
        [Column("kayit_tipi")]
        [StringLength(50)]
        public string KayitTipi { get; set; }
        [Column("kayit_tarihi", TypeName = "datetime")]
        public DateTime? KayitTarihi { get; set; }
        [Column("evrak_teslim_tarihi", TypeName = "datetime")]
        public DateTime? EvrakTeslimTarihi { get; set; }
        [Column("kaydi_alan")]
        [StringLength(250)]
        public string KaydiAlan { get; set; }
    }
}
