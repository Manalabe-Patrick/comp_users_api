using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace comp_users_api.Models
{
    public partial class Subscription
    {
        [Key]
        public Guid Id { get; set; }
        public int Company { get; set; }
        public int? Plan { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateCreated { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateExpired { get; set; }
        public int Tier { get; set; }
    }
}
