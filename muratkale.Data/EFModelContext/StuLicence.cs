using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Stu_Licence")]
    public partial class StuLicence
    {
        [Column("StuID")]
        [StringLength(11)]
        public string StuId { get; set; }
        [StringLength(30)]
        public string Club { get; set; }
        public int Branch { get; set; }
        public int? Year { get; set; }

        [ForeignKey("Branch")]
        [InverseProperty("StuLicence")]
        public SportsBranch BranchNavigation { get; set; }
        [ForeignKey("StuId")]
        [InverseProperty("StuLicence")]
        public Student Stu { get; set; }
    }
}
