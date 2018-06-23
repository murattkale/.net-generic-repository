using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Parameter_CityProvince")]
    public partial class ParameterCityProvince
    {
        [Key]
        [Column("SubProvinceID")]
        [StringLength(4)]
        public string SubProvinceId { get; set; }
        [Required]
        [StringLength(50)]
        public string SubProvince { get; set; }
    }
}
