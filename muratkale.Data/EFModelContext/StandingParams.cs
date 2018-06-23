using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Standing_Params")]
    public partial class StandingParams
    {
        [Column("ProgramID")]
        [StringLength(25)]
        public string ProgramId { get; set; }
        [StringLength(15)]
        public string Standing { get; set; }
        [Column("Credits_To_Complete")]
        public byte CreditsToComplete { get; set; }

        [ForeignKey("ProgramId")]
        [InverseProperty("StandingParams")]
        public ProgramDepts Program { get; set; }
    }
}
