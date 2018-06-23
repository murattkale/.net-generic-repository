using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    public partial class Scholarship
    {
        public Scholarship()
        {
            StuScholarship = new HashSet<StuScholarship>();
        }

        [Column("ScholarshipID")]
        public int ScholarshipId { get; set; }
        [Required]
        [Column("Scholarship_Name")]
        [StringLength(50)]
        public string ScholarshipName { get; set; }
        [Required]
        [Column("Awarding_Institution")]
        [StringLength(50)]
        public string AwardingInstitution { get; set; }
        public bool? Active { get; set; }
        [StringLength(5)]
        public string Percent { get; set; }

        [InverseProperty("Scholarship")]
        public BursKategori BursKategori { get; set; }
        [InverseProperty("Scholarship")]
        public ICollection<StuScholarship> StuScholarship { get; set; }
    }
}
