using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Request_types")]
    public partial class RequestTypes
    {
        public RequestTypes()
        {
            StuRequest = new HashSet<StuRequest>();
        }

        [Key]
        [Column("ReqID")]
        public int ReqId { get; set; }
        [Required]
        [Column("Request_Eng")]
        [StringLength(50)]
        public string RequestEng { get; set; }
        [Column("Request_Tur")]
        [StringLength(50)]
        public string RequestTur { get; set; }

        [InverseProperty("Req")]
        public ICollection<StuRequest> StuRequest { get; set; }
    }
}
