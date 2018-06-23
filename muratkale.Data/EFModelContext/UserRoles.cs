using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("User_Roles")]
    public partial class UserRoles
    {
        [Column("UserID")]
        [StringLength(11)]
        public string UserId { get; set; }
        [StringLength(50)]
        public string UserRole { get; set; }
    }
}
