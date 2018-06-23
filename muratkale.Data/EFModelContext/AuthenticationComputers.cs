using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Authentication_Computers")]
    public partial class AuthenticationComputers
    {
        public int Id { get; set; }
        [Required]
        [Column("IPAddress")]
        [StringLength(50)]
        public string Ipaddress { get; set; }
    }
}
