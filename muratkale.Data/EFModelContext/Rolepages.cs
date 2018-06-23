using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("ROLEPAGES")]
    public partial class Rolepages
    {
        [StringLength(50)]
        public string RoleName { get; set; }
        [StringLength(100)]
        public string PageName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreationDate { get; set; }
    }
}
