using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("khk_ogrenciler")]
    public partial class KhkOgrenciler
    {
        [Column("Stu_ID_No")]
        [StringLength(11)]
        public string StuIdNo { get; set; }
        [Key]
        [Column("StuID")]
        [StringLength(11)]
        public string StuId { get; set; }
        [Column("kordinator_uni")]
        [StringLength(250)]
        public string KordinatorUni { get; set; }
        [Column("ozel_ogrenci_uni")]
        [StringLength(250)]
        public string OzelOgrenciUni { get; set; }
        [Column("ozel_ogrenci")]
        public bool? OzelOgrenci { get; set; }
        [Column("aciklama")]
        [StringLength(250)]
        public string Aciklama { get; set; }
    }
}
