﻿using System;

namespace Store.Core.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public string PictureUrl { get; set; }

        public ProductType Type { get; set; }

        public Guid TypeId { get; set; }

        public ProductBrand Brand { get; set; }

        public Guid BrandId { get; set; }
    }
}
