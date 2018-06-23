using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    public partial class Clubs
    {
        public Clubs()
        {
            StuClub = new HashSet<StuClub>();
        }

        [Key]
        [Column("ClubID")]
        public int ClubId { get; set; }
        [Required]
        [Column("Club_Name")]
        [StringLength(50)]
        public string ClubName { get; set; }

        [InverseProperty("ClubNavigation")]
        public ICollection<StuClub> StuClub { get; set; }
    }
}
