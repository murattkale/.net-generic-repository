using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Coming_Types")]
    public partial class ComingTypes
    {
        public ComingTypes()
        {
            StuBackground = new HashSet<StuBackground>();
        }

        [Key]
        public int Code { get; set; }
        [Required]
        [Column("Coming_Name")]
        [StringLength(150)]
        public string ComingName { get; set; }

        [InverseProperty("ComingTypeNavigation")]
        public ICollection<StuBackground> StuBackground { get; set; }
    }
}
