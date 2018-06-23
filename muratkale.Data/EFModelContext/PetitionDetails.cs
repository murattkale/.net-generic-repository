using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Petition_Details")]
    public partial class PetitionDetails
    {
        [Key]
        [Column("petitiondetailid")]
        public int Petitiondetailid { get; set; }
        [Column("petitionid")]
        public int Petitionid { get; set; }
        [Column("petitiontypeid")]
        public int Petitiontypeid { get; set; }
        [Column("petdata")]
        [StringLength(50)]
        public string Petdata { get; set; }
        [Column("pettext")]
        [StringLength(1000)]
        public string Pettext { get; set; }
    }
}
