using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Co_requisiteOR")]
    public partial class CoRequisiteOr
    {
        [Column("Course_Code")]
        [StringLength(13)]
        public string CourseCode { get; set; }
        [Column("Co_Req")]
        [StringLength(13)]
        public string CoReq { get; set; }
    }
}
