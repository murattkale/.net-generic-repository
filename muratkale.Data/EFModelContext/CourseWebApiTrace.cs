using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Course_WebApi_Trace")]
    public partial class CourseWebApiTrace
    {
        [Column("username")]
        [StringLength(50)]
        public string Username { get; set; }
        [Column("used_method")]
        [StringLength(50)]
        public string UsedMethod { get; set; }
        [Column("used_parameters")]
        [StringLength(250)]
        public string UsedParameters { get; set; }
        [Column("api_worked_time", TypeName = "datetime")]
        public DateTime? ApiWorkedTime { get; set; }
        [Column("id")]
        public int Id { get; set; }
    }
}
