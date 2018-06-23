using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("work_aile_konut")]
    public partial class WorkAileKonut
    {
        [Key]
        [Column("stuID")]
        [StringLength(11)]
        public string StuId { get; set; }
        [Column("aile_konut")]
        [StringLength(30)]
        public string AileKonut { get; set; }
        [Column("konut_ilce")]
        [StringLength(30)]
        public string KonutIlce { get; set; }
        [Column("konut_il")]
        [StringLength(30)]
        public string KonutIl { get; set; }
        [Column("olcu")]
        [StringLength(30)]
        public string Olcu { get; set; }
        [Column("deger")]
        [StringLength(30)]
        public string Deger { get; set; }
        [Column("aile_konut1")]
        [StringLength(50)]
        public string AileKonut1 { get; set; }
    }
}
