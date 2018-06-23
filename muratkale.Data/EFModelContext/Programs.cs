using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    public partial class Programs
    {
        [Key]
        [Column("ProgramID")]
        [StringLength(50)]
        public string ProgramId { get; set; }
        [Column("ProgramAdi_Eng")]
        [StringLength(100)]
        public string ProgramAdiEng { get; set; }
        [Column("ProgramAdi_Tur")]
        [StringLength(100)]
        public string ProgramAdiTur { get; set; }
        [Column("Program_Level")]
        [StringLength(50)]
        public string ProgramLevel { get; set; }
    }
}
