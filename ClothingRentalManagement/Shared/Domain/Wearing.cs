using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingRentalManagement.Shared.Domain
{
    public class Wearing : BaseDomainModel
    {
        public int ApparelItemId { get; set; }
        public virtual ApparelItem ApparelItem { get; set; } = new ApparelItem();

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOut { get; set; }
        public DateTime? DateIn { get; set; }
        public Wearer Wearer { get; set; } = new Wearer();
        public int WearerId { get; set; }
    }
}
