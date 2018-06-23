using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Part_Time_Instructor_Institution")]
    public partial class PartTimeInstructorInstitution
    {
        [Key]
        [Column("InstID")]
        [StringLength(10)]
        public string InstId { get; set; }
        [StringLength(50)]
        public string Institution { get; set; }

        [ForeignKey("InstId")]
        [InverseProperty("PartTimeInstructorInstitution")]
        public Instructor Inst { get; set; }
    }
}
