using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("burs_kategori")]
    public partial class BursKategori
    {
        [Key]
        [Column("ScholarshipID")]
        public int ScholarshipId { get; set; }
        [Required]
        [Column("Scholarship_Name")]
        [StringLength(50)]
        public string ScholarshipName { get; set; }
        [Column(TypeName = "nchar(100)")]
        public string Kategori { get; set; }

        [ForeignKey("ScholarshipId")]
        [InverseProperty("BursKategori")]
        public Scholarship Scholarship { get; set; }
    }
}
