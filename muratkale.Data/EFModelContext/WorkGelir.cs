using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("work_gelir")]
    public partial class WorkGelir
    {
        [Key]
        [Column("stuID")]
        [StringLength(11)]
        public string StuId { get; set; }
        [StringLength(11)]
        public string KrediY { get; set; }
        [StringLength(11)]
        public string Basvuru { get; set; }
        [Column("bBurs")]
        [StringLength(11)]
        public string BBurs { get; set; }
        [Column(TypeName = "money")]
        public decimal? Harclik { get; set; }
        [StringLength(255)]
        public string BursKurum { get; set; }
        [Column(TypeName = "money")]
        public decimal? BursTutar { get; set; }
    }
}
