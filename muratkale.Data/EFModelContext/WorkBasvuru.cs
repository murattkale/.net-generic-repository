using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("work_basvuru")]
    public partial class WorkBasvuru
    {
        [Key]
        [Column("stuid")]
        [StringLength(11)]
        public string Stuid { get; set; }
        [Column("kabul")]
        [StringLength(5)]
        public string Kabul { get; set; }
        [Column("ekbilgi", TypeName = "text")]
        public string Ekbilgi { get; set; }
        [Column("birim1")]
        [StringLength(5)]
        public string Birim1 { get; set; }
        [Column("birim2")]
        [StringLength(5)]
        public string Birim2 { get; set; }
        [Column("birim3")]
        [StringLength(5)]
        public string Birim3 { get; set; }
        [Column("birim4")]
        [StringLength(5)]
        public string Birim4 { get; set; }
        [Column("birim5")]
        [StringLength(5)]
        public string Birim5 { get; set; }
        [Column("birim6")]
        [StringLength(55)]
        public string Birim6 { get; set; }
        [Column("saglik", TypeName = "text")]
        public string Saglik { get; set; }
        [Column("date1")]
        [StringLength(55)]
        public string Date1 { get; set; }
        [Column("toplam_puan")]
        public int? ToplamPuan { get; set; }
    }
}
