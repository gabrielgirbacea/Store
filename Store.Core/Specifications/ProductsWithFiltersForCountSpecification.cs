using Store.Core.Entities;

namespace Store.Core.Specifications
{
    public class ProductsWithFiltersForCountSpecification : BaseSpecification<Product>
    {
        public ProductsWithFiltersForCountSpecification(ProductSpecParams productParams)
            : base(x =>
            (!productParams.BrandId.HasValue || x.BrandId == productParams.BrandId)
            && (!productParams.TypeId.HasValue || x.TypeId == productParams.TypeId))
        {

        }
    }
}
