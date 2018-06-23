using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    public partial class UserLoginLog
    {
        [Column("UserID")]
        [StringLength(50)]
        public string UserId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime EntranceDate { get; set; }
    }
}
