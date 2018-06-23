using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Petition_Reviews")]
    public partial class PetitionReviews
    {
        [Column("petitiondetailid")]
        public int Petitiondetailid { get; set; }
        [Column("reviewertype")]
        [StringLength(50)]
        public string Reviewertype { get; set; }
        [Column("reviewerid")]
        [StringLength(50)]
        public string Reviewerid { get; set; }
        [Column("reviewdate", TypeName = "datetime")]
        public DateTime? Reviewdate { get; set; }
        [Column("reviewresult")]
        public bool? Reviewresult { get; set; }
        [Column("comment", TypeName = "text")]
        public string Comment { get; set; }
    }
}
