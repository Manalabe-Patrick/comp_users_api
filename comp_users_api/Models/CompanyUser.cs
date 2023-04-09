using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace comp_users_api.Models
{
    public partial class CompanyUser
    {
        [Key]
        public int Id { get; set; }
        public string User { get; set; }
        public int Company { get; set; }
        [Required]
        [StringLength(25)]
        public string Role { get; set; }
        public bool Status { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateCreated { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateAccessed { get; set; }
        public string Email { get; set; }
        public Guid Guid { get; set; }
    }
}
