using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("DM_M_ApprovalStatus")]
    public partial class DmMApprovalStatus
    {
        [Key]
        [Column("StuID")]
        [StringLength(11)]
        public string StuId { get; set; }
        public int ApprovalStatus { get; set; }
        [Required]
        [StringLength(10)]
        public string LastApproveBy { get; set; }

        [ForeignKey("StuId")]
        [InverseProperty("DmMApprovalStatus")]
        public Student Stu { get; set; }
    }
}
