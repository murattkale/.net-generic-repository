using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("CV_Membership")]
    public partial class CvMembership
    {
        [Column("StuID")]
        [StringLength(11)]
        public string StuId { get; set; }
        [StringLength(50)]
        public string MemberOf { get; set; }
    }
}
