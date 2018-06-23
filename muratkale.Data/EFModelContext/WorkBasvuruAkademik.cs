using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("work_basvuru_akademik")]
    public partial class WorkBasvuruAkademik
    {
        [Key]
        [Column("stuid")]
        [StringLength(11)]
        public string Stuid { get; set; }
        [Column("kabul")]
        [StringLength(5)]
        public string Kabul { get; set; }
        [Column("fakulte")]
        [StringLength(55)]
        public string Fakulte { get; set; }
        [Column("bolum")]
        [StringLength(55)]
        public string Bolum { get; set; }
        [Column("saglik", TypeName = "text")]
        public string Saglik { get; set; }
        [Column("date1")]
        [StringLength(55)]
        public string Date1 { get; set; }
    }
}
