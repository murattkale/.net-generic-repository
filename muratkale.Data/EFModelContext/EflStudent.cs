using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("EFL_Student")]
    public partial class EflStudent
    {
        [Key]
        [Column("StuID")]
        [StringLength(11)]
        public string StuId { get; set; }
        [Column("TrackID")]
        public int TrackId { get; set; }
        [Column("ApprovedTrackID")]
        public int ApprovedTrackId { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ExitDate { get; set; }

        [ForeignKey("TrackId")]
        [InverseProperty("EflStudent")]
        public EflTracks Track { get; set; }
    }
}
