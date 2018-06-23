using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("work_tasit_stu")]
    public partial class WorkTasitStu
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("stuID")]
        [StringLength(11)]
        public string StuId { get; set; }
        [Column("marka")]
        [StringLength(30)]
        public string Marka { get; set; }
        [Column("yil")]
        [StringLength(30)]
        public string Yil { get; set; }
        [Column("plaka")]
        [StringLength(10)]
        public string Plaka { get; set; }
        [Column("mulkiyet")]
        [StringLength(30)]
        public string Mulkiyet { get; set; }
    }
}
