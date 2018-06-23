using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    public partial class SemesterOrder
    {
        [Key]
        [StringLength(25)]
        public string Semester { get; set; }
        public int OrderNo { get; set; }
    }
}
