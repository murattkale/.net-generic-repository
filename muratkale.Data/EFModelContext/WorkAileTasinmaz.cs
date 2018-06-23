using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("work_aile_tasinmaz")]
    public partial class WorkAileTasinmaz
    {
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [Column("stuID")]
        [StringLength(11)]
        public string StuId { get; set; }
        [Column("cins")]
        [StringLength(30)]
        public string Cins { get; set; }
        [Column("adet")]
        public int? Adet { get; set; }
        [Column("il")]
        [StringLength(30)]
        public string Il { get; set; }
        [Column("semt")]
        [StringLength(30)]
        public string Semt { get; set; }
        [Column("olcu")]
        [StringLength(30)]
        public string Olcu { get; set; }
        [Column("deger", TypeName = "money")]
        public decimal? Deger { get; set; }
    }
}
