using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Sports_Branch")]
    public partial class SportsBranch
    {
        public SportsBranch()
        {
            StuLicence = new HashSet<StuLicence>();
            StuSport = new HashSet<StuSport>();
        }

        [Key]
        [Column("BranchID")]
        public int BranchId { get; set; }
        [Required]
        [Column("Branch_Name")]
        [StringLength(50)]
        public string BranchName { get; set; }

        [InverseProperty("BranchNavigation")]
        public ICollection<StuLicence> StuLicence { get; set; }
        [InverseProperty("BranchNavigation")]
        public ICollection<StuSport> StuSport { get; set; }
    }
}
