using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("work_aile_kisiler")]
    public partial class WorkAileKisiler
    {
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("stuID")]
        [StringLength(11)]
        public string StuId { get; set; }
        [Column("ad")]
        [StringLength(50)]
        public string Ad { get; set; }
        [Column("yakinlik_der")]
        [StringLength(30)]
        public string YakinlikDer { get; set; }
        [Column("is_stu")]
        [StringLength(30)]
        public string IsStu { get; set; }
        [Column("is_work")]
        [StringLength(30)]
        public string IsWork { get; set; }
        [Column("aylik_net", TypeName = "money")]
        public decimal? AylikNet { get; set; }
    }
}
