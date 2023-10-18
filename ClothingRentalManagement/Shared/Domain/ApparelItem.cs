﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingRentalManagement.Shared.Domain
{
    public class ApparelItem : BaseDomainModel
    {
        public string ShortDesc { get; set; } = string.Empty;
        public string LongDesc { get; set; } = string.Empty;
        public int BrandId { get; set; }
        public virtual Brand Brand { get; set; } = new Brand();
        public int ApparelTypeId { get; set; }
        public virtual ApparelType ApparelType { get; set; } = new ApparelType();
        public int ColorId { get; set; }
        public virtual Color Color { get; set; } = new Color();
        public int SeasonId { get; set; }
        public virtual Season Season { get; set; } = new Season();
        public int SizeId { get; set; }
        public virtual Size Size { get; set; } = new Size();
        public double Rate { get; set; }
        public virtual List<Wearing> Wearings { get; set; } = new List<Wearing>();
    }

}
