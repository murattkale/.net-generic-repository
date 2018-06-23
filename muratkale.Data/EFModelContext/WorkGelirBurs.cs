using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("work_gelir_burs")]
    public partial class WorkGelirBurs
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("stuID")]
        [StringLength(11)]
        public string StuId { get; set; }
        [StringLength(100)]
        public string BursKurum { get; set; }
        [Column(TypeName = "money")]
        public decimal? BursTutar { get; set; }
    }
}
