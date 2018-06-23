using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("pardoned6111")]
    public partial class Pardoned6111
    {
        [Key]
        [Column("stuid")]
        [StringLength(11)]
        public string Stuid { get; set; }
        [Column("year")]
        public int Year { get; set; }
        [Required]
        [Column("semester")]
        [StringLength(10)]
        public string Semester { get; set; }
        [Column("regdate")]
        [StringLength(25)]
        public string Regdate { get; set; }
        [Column("description")]
        [StringLength(255)]
        public string Description { get; set; }
        [Column("Leaving_Date", TypeName = "datetime")]
        public DateTime? LeavingDate { get; set; }
        [Column("plaw")]
        [StringLength(255)]
        public string Plaw { get; set; }
        [Column("onay", TypeName = "datetime")]
        public DateTime? Onay { get; set; }
    }
}
