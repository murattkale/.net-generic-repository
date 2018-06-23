using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Course_WebApi_Users")]
    public partial class CourseWebApiUsers
    {
        [Required]
        [Column("username")]
        [StringLength(50)]
        public string Username { get; set; }
        [Required]
        [Column("password")]
        [StringLength(50)]
        public string Password { get; set; }
        [Key]
        [Column("api_key")]
        [StringLength(50)]
        public string ApiKey { get; set; }
    }
}
