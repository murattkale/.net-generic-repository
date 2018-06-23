using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Student_Work")]
    public partial class StudentWork
    {
        [Key]
        [Column("StuID")]
        [StringLength(11)]
        public string StuId { get; set; }
        [Required]
        [Column("Company_Name")]
        [StringLength(50)]
        public string CompanyName { get; set; }
        [StringLength(20)]
        public string Position { get; set; }
        [Required]
        [StringLength(150)]
        public string Address { get; set; }
        [StringLength(20)]
        public string Town { get; set; }
        [Required]
        [StringLength(20)]
        public string City { get; set; }
        [Required]
        [Column("Postal_Code")]
        [StringLength(5)]
        public string PostalCode { get; set; }
        [Required]
        [StringLength(11)]
        public string Phone1 { get; set; }
        [StringLength(11)]
        public string Phone2 { get; set; }
        [StringLength(11)]
        public string Fax { get; set; }
    }
}
