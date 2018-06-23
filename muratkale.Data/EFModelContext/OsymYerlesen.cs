using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("osym_yerlesen")]
    public partial class OsymYerlesen
    {
        [Key]
        [Column("TC")]
        [StringLength(11)]
        public string Tc { get; set; }
        [Column("isim")]
        [StringLength(20)]
        public string Isim { get; set; }
        [Column("isim2")]
        [StringLength(20)]
        public string Isim2 { get; set; }
        [Column("soyisim")]
        [StringLength(50)]
        public string Soyisim { get; set; }
        [Required]
        [Column("FactID")]
        [StringLength(10)]
        public string FactId { get; set; }
        [Required]
        [Column("Tur_Name")]
        [StringLength(100)]
        public string TurName { get; set; }
        [Column("DeptID")]
        [StringLength(5)]
        public string DeptId { get; set; }
        [Column("Dept_tur_Name")]
        [StringLength(60)]
        public string DeptTurName { get; set; }
        [Required]
        [Column("ProgramID")]
        [StringLength(10)]
        public string ProgramId { get; set; }
        [Column("ProgramAdi_Tur")]
        [StringLength(150)]
        public string ProgramAdiTur { get; set; }
        [Required]
        [StringLength(11)]
        public string ProgramCode { get; set; }
        [Column("Yerlesme_Burs")]
        [StringLength(50)]
        public string YerlesmeBurs { get; set; }
        [Column("Yerlesme_Oran")]
        [StringLength(50)]
        public string YerlesmeOran { get; set; }
        [Column("Kayıt_Burs")]
        [StringLength(50)]
        public string KayıtBurs { get; set; }
        [Column("Kayıt_Oran")]
        [StringLength(50)]
        public string KayıtOran { get; set; }
        [Column("Yerlesme_Sene")]
        public int? YerlesmeSene { get; set; }
        [Column("Kayıt_Aralık")]
        [StringLength(25)]
        public string KayıtAralık { get; set; }
        [Column("Yerlesme_Tipi")]
        [StringLength(15)]
        public string YerlesmeTipi { get; set; }
        [Column("StuID")]
        [StringLength(11)]
        public string StuId { get; set; }
        [Column("STU_GENDER", TypeName = "nchar(1)")]
        public string StuGender { get; set; }
        [Column("Lise_il")]
        [StringLength(20)]
        public string LiseIl { get; set; }
    }
}
