using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("work_ikamet")]
    public partial class WorkIkamet
    {
        [Key]
        [Column("stuID")]
        [StringLength(11)]
        public string StuId { get; set; }
        [Column("ik1")]
        [StringLength(25)]
        public string Ik1 { get; set; }
        [Column("blok")]
        [StringLength(25)]
        public string Blok { get; set; }
        [Column("oda")]
        [StringLength(25)]
        public string Oda { get; set; }
        [Column("yurtadi")]
        [StringLength(50)]
        public string Yurtadi { get; set; }
        [Column("akder")]
        [StringLength(25)]
        public string Akder { get; set; }
        [Column("ptutar")]
        [StringLength(25)]
        public string Ptutar { get; set; }
        [Column("ktutar")]
        [StringLength(25)]
        public string Ktutar { get; set; }
        [Column("adres")]
        [StringLength(150)]
        public string Adres { get; set; }
        [Column("telefon", TypeName = "nchar(10)")]
        public string Telefon { get; set; }
    }
}
