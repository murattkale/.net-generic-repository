using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    public partial class Tuition
    {
        [Column("ProgramID")]
        [StringLength(10)]
        public string ProgramId { get; set; }
        public int Year { get; set; }
        [Column("Tuition", TypeName = "smallmoney")]
        public decimal Tuition1 { get; set; }
    }
}
