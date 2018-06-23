using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    public partial class Senator
    {
        [Required]
        [Column(TypeName = "nchar(10)")]
        public string Numara { get; set; }
        [Column("OperatorID", TypeName = "nchar(15)")]
        public string OperatorId { get; set; }
        [Required]
        [Column(TypeName = "nchar(10)")]
        public string Tutanak { get; set; }
        [Column("Tutanak_Tarihi", TypeName = "date")]
        public DateTime TutanakTarihi { get; set; }
        [Required]
        [StringLength(5)]
        public string DeptId { get; set; }
        [Key]
        [Column("ProgramID")]
        [StringLength(25)]
        public string ProgramId { get; set; }

        [ForeignKey("ProgramId")]
        [InverseProperty("Senator")]
        public ProgramDepts Program { get; set; }
    }
}
