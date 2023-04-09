using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace comp_users_api.Models
{
    public partial class Company
    {
        [Key]
        public int Id { get; set; }
        [StringLength(250)]
        public string FirstName { get; set; }
        [StringLength(250)]
        public string MiddleName { get; set; }
        [StringLength(250)]
        public string LastName { get; set; }
        [Required]
        [StringLength(250)]
        public string Name { get; set; }
        [StringLength(250)]
        public string TradeName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Birthdate { get; set; }
        [StringLength(50)]
        public string Gender { get; set; }
        public string Address { get; set; }
        [StringLength(10)]
        public string ZipCode { get; set; }
        [Required]
        [StringLength(50)]
        public string Contact { get; set; }
        [Column("TIN")]
        [StringLength(17)]
        public string Tin { get; set; }
        [Column("RDO")]
        [StringLength(4)]
        public string Rdo { get; set; }
        public string Occupation { get; set; }
        [StringLength(50)]
        public string DeductionMethod { get; set; }
        [StringLength(50)]
        public string BusinessType { get; set; }
        [StringLength(50)]
        public string IncomeSource { get; set; }
        [Column("COR")]
        public string Cor { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateCreated { get; set; }
        [Required]
        [StringLength(254)]
        public string Email { get; set; }
        [StringLength(500)]
        public string Forms { get; set; }
        [StringLength(50)]
        public string TaxpayerType { get; set; }
        [StringLength(50)]
        public string TaxCode { get; set; }
        [StringLength(50)]
        public string IncomeTaxRateType { get; set; }
        public string Signature { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? BirRegistration { get; set; }
        [StringLength(50)]
        public string CivilStatus { get; set; }
        [StringLength(50)]
        public string Citizenship { get; set; }
        public bool? SpouseHasIncome { get; set; }
        public bool? IncomeTaxExempt { get; set; }
        public bool? SpecialRate { get; set; }
        [Column("BMBE")]
        public bool? Bmbe { get; set; }
        [StringLength(100)]
        public string Usage { get; set; }
        public bool? IsCorporation { get; set; }
        public bool? IsDormant { get; set; }
        [StringLength(100)]
        public string DataSource { get; set; }
    }
}
