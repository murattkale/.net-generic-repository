using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("EFL_Tracks")]
    public partial class EflTracks
    {
        public EflTracks()
        {
            EflStudent = new HashSet<EflStudent>();
        }

        [Key]
        [Column("TrackID")]
        public int TrackId { get; set; }
        [Required]
        [Column("Track_Name")]
        [StringLength(20)]
        public string TrackName { get; set; }

        [InverseProperty("Track")]
        public ICollection<EflStudent> EflStudent { get; set; }
    }
}
