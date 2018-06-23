using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Query_Logs")]
    public partial class QueryLogs
    {
        [Key]
        [Column("LogID")]
        public int LogId { get; set; }
        [Required]
        [Column("User_IP", TypeName = "char(16)")]
        public string UserIp { get; set; }
        [Column("Date_Time", TypeName = "datetime")]
        public DateTime DateTime { get; set; }
        [Required]
        [Column("Query_Text", TypeName = "ntext")]
        public string QueryText { get; set; }
        public bool Success { get; set; }
    }
}
