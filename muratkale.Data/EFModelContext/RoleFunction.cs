using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    public partial class RoleFunction
    {
        [Column("FunctionID")]
        public int FunctionId { get; set; }
        [Column(TypeName = "char(40)")]
        public string FunctionName { get; set; }
        [StringLength(40)]
        public string FunctionRole { get; set; }
        [Column("IPProtected")]
        public short Ipprotected { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreationDate { get; set; }
    }
}
