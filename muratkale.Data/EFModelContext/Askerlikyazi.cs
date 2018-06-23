using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("askerlikyazi")]
    public partial class Askerlikyazi
    {
        [Column("stuID")]
        [StringLength(11)]
        public string StuId { get; set; }
        [Column("asdate")]
        [StringLength(50)]
        public string Asdate { get; set; }
        [Column("asyazi")]
        [StringLength(50)]
        public string Asyazi { get; set; }
        [Column("asil")]
        [StringLength(50)]
        public string Asil { get; set; }
    }
}
