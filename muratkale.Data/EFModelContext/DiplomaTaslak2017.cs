using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("diploma_taslak_2017")]
    public partial class DiplomaTaslak2017
    {
        [Key]
        [Column("ProgramID")]
        [StringLength(25)]
        public string ProgramId { get; set; }
        [Required]
        [Column("Fakülte_ID")]
        [StringLength(10)]
        public string FakülteId { get; set; }
        [Column("alan_fakülte")]
        [StringLength(100)]
        public string AlanFakülte { get; set; }
        [Column("anabilim_Dalı")]
        [StringLength(50)]
        public string AnabilimDalı { get; set; }
        [Column("Alan_Program")]
        [StringLength(150)]
        public string AlanProgram { get; set; }
        [Column("alan_Program_diploma")]
        [StringLength(150)]
        public string AlanProgramDiploma { get; set; }
        [Column("alan_onay")]
        [StringLength(50)]
        public string AlanOnay { get; set; }
        [Column("alan_bachelor")]
        [StringLength(150)]
        public string AlanBachelor { get; set; }
        [Column("alan_faculty")]
        [StringLength(50)]
        public string AlanFaculty { get; set; }
        [Column("alan_hoca_imza")]
        [StringLength(50)]
        public string AlanHocaImza { get; set; }
        [Column("alan_onay_tipi")]
        [StringLength(50)]
        public string AlanOnayTipi { get; set; }
        [Column("alan_onay_ingilizce")]
        [StringLength(50)]
        public string AlanOnayIngilizce { get; set; }

        [ForeignKey("ProgramId")]
        [InverseProperty("DiplomaTaslak2017")]
        public ProgramDepts Program { get; set; }
    }
}
