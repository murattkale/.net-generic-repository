using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Exemption_Coordinator")]
    public partial class ExemptionCoordinator
    {
        [Column("InstID")]
        [StringLength(10)]
        public string InstId { get; set; }
        [Column("Course_Code")]
        [StringLength(50)]
        public string CourseCode { get; set; }

        [ForeignKey("CourseCode")]
        [InverseProperty("ExemptionCoordinator")]
        public Course CourseCodeNavigation { get; set; }
    }
}
