using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Parameter_High_School")]
    public partial class ParameterHighSchool
    {
        [Key]
        [Column("schoolid", TypeName = "numeric(18, 0)")]
        public decimal Schoolid { get; set; }
        [Column("school_code")]
        public int? SchoolCode { get; set; }
        [Column("school_name")]
        [StringLength(55)]
        public string SchoolName { get; set; }
    }
}
