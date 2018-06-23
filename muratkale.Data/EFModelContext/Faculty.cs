using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    public partial class Faculty
    {
        public Faculty()
        {
            Department = new HashSet<Department>();
        }

        [Key]
        [Column("FactID")]
        [StringLength(10)]
        public string FactId { get; set; }
        [Required]
        [Column("Fac_Name")]
        [StringLength(100)]
        public string FacName { get; set; }
        [StringLength(10)]
        public string Dean { get; set; }
        [Column("Tur_Name")]
        [StringLength(100)]
        public string TurName { get; set; }
        [StringLength(10)]
        public string Secretary { get; set; }
        [Column("GroupID")]
        [StringLength(50)]
        public string GroupId { get; set; }

        [ForeignKey("Secretary")]
        [InverseProperty("Faculty")]
        public Staff SecretaryNavigation { get; set; }
        [InverseProperty("Fact")]
        public ICollection<Department> Department { get; set; }
    }
}
