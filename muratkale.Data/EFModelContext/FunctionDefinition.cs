using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    public partial class FunctionDefinition
    {
        [Column("FunctionID")]
        public int FunctionId { get; set; }
        [StringLength(50)]
        public string PageName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreationDate { get; set; }
    }
}
