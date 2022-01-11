﻿using System;

namespace Store.Core.Specifications
{
    public class ProductSpecParams
    {
        private const int MaxPageSize = 50;
        private int _pageSize = 2;
        private string _search;

        public int PageSize
        {
            get => _pageSize;
            set => _pageSize = (value > MaxPageSize) ? MaxPageSize : value;
        }

        public string Search
        {
            get => _search;
            set => _search = value.ToLower();
        }
        public int PageIndex { get; set; } = 1;

        public Guid? BrandId { get; set; }

        public Guid? TypeId { get; set; }

        public string Sort { get; set; }
    }
}
