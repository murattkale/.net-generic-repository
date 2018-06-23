using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    public partial class PasswordChanger
    {
        [Column("UserID", TypeName = "char(11)")]
        public string UserId { get; set; }
        public int Year { get; set; }
        [StringLength(10)]
        public string Semester { get; set; }
    }
}
