using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingRentalManagement.Shared.Domain
{
    public class Wearer: BaseDomainModel
    {
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string LastName { get; set; } = string.Empty;

        public string Address { get; set; }= string.Empty;

        [Required(ErrorMessage = "Enter Tax Id")]
        [StringLength(15, MinimumLength = 8, ErrorMessage = "Tax Id does not meet length requirements")]
        public string TaxId { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.PhoneNumber)]
        public string ContactNumber { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string EmailAddress { get; set; } = string.Empty;
        public virtual List<Wearing> Wearings { get; set; } = new List<Wearing>();
    }
}
