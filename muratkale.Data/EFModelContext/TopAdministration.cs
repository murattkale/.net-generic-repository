using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Top_Administration")]
    public partial class TopAdministration
    {
        [Key]
        [Column("InstID")]
        [StringLength(10)]
        public string InstId { get; set; }
        [StringLength(50)]
        public string AdminType { get; set; }

        [ForeignKey("InstId")]
        [InverseProperty("TopAdministration")]
        public Instructor Inst { get; set; }
    }
}
