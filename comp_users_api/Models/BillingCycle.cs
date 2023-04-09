using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace comp_users_api.Models
{
    public partial class BillingCycle
    {
        [Key]
        public int Id { get; set; }
        public int Company { get; set; }
        [Required]
        [StringLength(50)]
        public string CycleType { get; set; }
        public int? Status { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateCreated { get; set; }
        public Guid Billing { get; set; }
        public int Payment { get; set; }
    }
}
