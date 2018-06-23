using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    public partial class DropType
    {
        public DropType()
        {
            StuDropped = new HashSet<StuDropped>();
        }

        [Key]
        [Column("Drop_Type")]
        [StringLength(2)]
        public string DropType1 { get; set; }
        [Required]
        [Column("Drop_Description", TypeName = "nchar(100)")]
        public string DropDescription { get; set; }
        [Column(TypeName = "nchar(50)")]
        public string Type { get; set; }

        [InverseProperty("DropTypeNavigation")]
        public ICollection<StuDropped> StuDropped { get; set; }
    }
}
