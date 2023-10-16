using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingRentalManagement.Shared.Domain
{
    public class Wearing : BaseDomainModel
    {
        public int ApparelItemId { get; set; }
        public virtual ApparelItem ApparelItem { get; set; }
        public DateTime DateOut { get; set; }
        public DateTime DateIn { get; set; }
        public Wearer Wearer { get; set; }  
        public int WearerId { get; set; }
    }
}
