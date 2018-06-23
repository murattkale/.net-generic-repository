using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("RoleFunctionIP")]
    public partial class RoleFunctionIp
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("UserID")]
        [StringLength(20)]
        public string UserId { get; set; }
        [StringLength(30)]
        public string UserRole { get; set; }
        public int RoleFunction { get; set; }
        [Column("IP")]
        [StringLength(30)]
        public string Ip { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreationDate { get; set; }
    }
}
