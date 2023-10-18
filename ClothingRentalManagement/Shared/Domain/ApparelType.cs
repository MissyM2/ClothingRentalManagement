using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingRentalManagement.Shared.Domain
{
    public class ApparelType : BaseDomainModel
    {
        [Required]
        public string Name { get; set; } = string.Empty;
    }
}
