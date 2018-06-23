using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Status_Values")]
    public partial class StatusValues
    {
        public StatusValues()
        {
            RegStatus = new HashSet<RegStatus>();
        }

        [Key]
        public byte StatusId { get; set; }
        [Required]
        [StringLength(50)]
        public string Status { get; set; }

        [InverseProperty("Status")]
        public ICollection<RegStatus> RegStatus { get; set; }
    }
}
