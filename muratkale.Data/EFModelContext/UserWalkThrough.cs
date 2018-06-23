using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    public partial class UserWalkThrough
    {
        [Column("ID")]
        public long Id { get; set; }
        [Column("UserID")]
        [StringLength(20)]
        public string UserId { get; set; }
        [StringLength(50)]
        public string PageName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EntranceDate { get; set; }
    }
}
