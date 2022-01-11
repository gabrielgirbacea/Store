using Store.Core.Entities;

namespace Store.Core.Specifications
{
    public class ProductsWithFiltersForCountSpecification : BaseSpecification<Product>
    {
        public ProductsWithFiltersForCountSpecification(ProductSpecParams productParams)
            : base(x =>
                (string.IsNullOrWhiteSpace(productParams.Search) || x.Name.ToLower().Contains(productParams.Search)) &&
                (!productParams.BrandId.HasValue || x.BrandId == productParams.BrandId) &&
                (!productParams.TypeId.HasValue || x.TypeId == productParams.TypeId))
        {

        }
    }
}
