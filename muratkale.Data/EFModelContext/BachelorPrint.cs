using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("bachelor_print")]
    public partial class BachelorPrint
    {
        [Key]
        [Column("ProgramID")]
        [StringLength(25)]
        public string ProgramId { get; set; }
        [Column("DeptID")]
        [StringLength(5)]
        public string DeptId { get; set; }
        [Column("ProgramAdi_Eng")]
        [StringLength(150)]
        public string ProgramAdiEng { get; set; }
        [Column("ProgramAdi_Tur")]
        [StringLength(150)]
        public string ProgramAdiTur { get; set; }
        [Column("Tur_Name")]
        [StringLength(100)]
        public string TurName { get; set; }
        [Required]
        [Column("Fac_Name")]
        [StringLength(100)]
        public string FacName { get; set; }
        [Required]
        [Column("FactID")]
        [StringLength(10)]
        public string FactId { get; set; }

        [ForeignKey("ProgramId")]
        [InverseProperty("BachelorPrint")]
        public ProgramDepts Program { get; set; }
    }
}
