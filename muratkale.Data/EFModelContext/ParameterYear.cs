using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Parameter_Year")]
    public partial class ParameterYear
    {
        public int Year { get; set; }
        [StringLength(10)]
        public string Semester { get; set; }
    }
}
