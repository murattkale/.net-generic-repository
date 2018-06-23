using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Petition_Header")]
    public partial class PetitionHeader
    {
        [Key]
        [Column("petitionid")]
        public int Petitionid { get; set; }
        [Required]
        [Column("StuID")]
        [StringLength(11)]
        public string StuId { get; set; }
        [Column("petitiondate", TypeName = "datetime")]
        public DateTime Petitiondate { get; set; }
        [Column("rsrhtml", TypeName = "ntext")]
        public string Rsrhtml { get; set; }
        [Column("processresult")]
        public byte Processresult { get; set; }
        [Column("processresulttext")]
        [StringLength(1000)]
        public string Processresulttext { get; set; }
    }
}
