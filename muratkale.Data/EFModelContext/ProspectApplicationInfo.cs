using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Prospect_Application_Info")]
    public partial class ProspectApplicationInfo
    {
        [Key]
        [Column("Stu_ID_No")]
        [StringLength(12)]
        public string StuIdNo { get; set; }
        [Column("mail_sent")]
        public bool? MailSent { get; set; }
        [Column("apply_acitivated")]
        public bool? ApplyAcitivated { get; set; }
        [Column("mail_sent_time", TypeName = "datetime")]
        public DateTime? MailSentTime { get; set; }
        [Column("apply_activated_time", TypeName = "datetime")]
        public DateTime? ApplyActivatedTime { get; set; }
    }
}
