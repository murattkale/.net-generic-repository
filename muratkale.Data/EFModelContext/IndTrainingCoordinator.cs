using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Ind_Training_Coordinator")]
    public partial class IndTrainingCoordinator
    {
        [Column("InstID")]
        [StringLength(10)]
        public string InstId { get; set; }
        [Column("Course_Code")]
        [StringLength(50)]
        public string CourseCode { get; set; }

        [ForeignKey("CourseCode")]
        [InverseProperty("IndTrainingCoordinator")]
        public Course CourseCodeNavigation { get; set; }
    }
}
