using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace comp_users_api.Models
{
    public partial class User
    {
        [Key]
        [StringLength(250)]
        public string Id { get; set; }
        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(100)]
        public string LastName { get; set; }
        [Required]
        [StringLength(254)]
        public string Email { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateRegistered { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateAccessed { get; set; }
        [Column("HasCOR")]
        public bool? HasCor { get; set; }
        [StringLength(25)]
        public string Code { get; set; }
        public string IdentityProvider { get; set; }
        public bool? Status { get; set; }
    }
}
