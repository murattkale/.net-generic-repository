using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("User_Types")]
    public partial class UserTypes
    {
        [Key]
        [Column("UserID", TypeName = "char(11)")]
        public string UserId { get; set; }
        [Required]
        [Column("User_Type", TypeName = "char(1)")]
        public string UserType { get; set; }
    }
}
