using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Last_GPA")]
    public partial class LastGpa
    {
        [Key]
        [Column("StuID")]
        [StringLength(11)]
        public string StuId { get; set; }
        [Column("GPA")]
        public double Gpa { get; set; }
        [StringLength(12)]
        public string Status { get; set; }
    }
}
