using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    public partial class Petitions
    {
        [Column("StuID", TypeName = "nchar(10)")]
        public string StuId { get; set; }
        [Column("Petition_Type")]
        [StringLength(50)]
        public string PetitionType { get; set; }
        [Column("Position_Addressed")]
        [StringLength(50)]
        public string PositionAddressed { get; set; }
        [StringLength(50)]
        public string Subject { get; set; }
        [Column("Petition_Date", TypeName = "datetime")]
        public DateTime PetitionDate { get; set; }
        [Required]
        [Column("Petition_Message", TypeName = "ntext")]
        public string PetitionMessage { get; set; }
        [StringLength(50)]
        public string Note { get; set; }
        public bool? Active { get; set; }
    }
}
