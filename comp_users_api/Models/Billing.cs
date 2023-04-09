using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace comp_users_api.Models
{
    public partial class Billing
    {
        [Key]
        public Guid Id { get; set; }
        public int Company { get; set; }
        public int Plan { get; set; }
        public int? RetryRemaining { get; set; }
        public int Status { get; set; }
        [StringLength(50)]
        public string Code { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateCreated { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateModified { get; set; }
        public Guid? Subscription { get; set; }
        public Guid? PaymayaSubscription { get; set; }
        public int? Customer { get; set; }
        public int? Card { get; set; }
    }
}
