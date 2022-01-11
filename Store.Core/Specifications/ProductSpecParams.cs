using System;

namespace Store.Core.Specifications
{
    public class ProductSpecParams
    {
        private const int MaxPageSize = 50;
        private int _pageSize = 2;

        public int PageIndex { get; set; } = 1;

        public int PageSize
        {
            get => _pageSize;
            set => _pageSize = (value > MaxPageSize) ? MaxPageSize : value;
        }

        public Guid? BrandId { get; set; }
        public Guid? TypeId { get; set; }
        public string Sort { get; set; }
    }
}
