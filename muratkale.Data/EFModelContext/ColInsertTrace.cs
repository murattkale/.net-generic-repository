using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("COL_INSERT_TRACE")]
    public partial class ColInsertTrace
    {
        [Key]
        [Column("TraceID")]
        public long TraceId { get; set; }
        [StringLength(200)]
        public string TableName { get; set; }
        [Column(TypeName = "text")]
        public string SqlStatement { get; set; }
        [Column("OperatorID")]
        [StringLength(20)]
        public string OperatorId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? OperationDate { get; set; }
    }
}
