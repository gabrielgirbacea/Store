using Store.Core.Entities;
using System;

namespace Store.Core.Specifications
{
    public class ProductsWithTypesAndBrandsSpecification : BaseSpecification<Product>
    {
        public ProductsWithTypesAndBrandsSpecification()
        {
            AddInclude(x => x.Type);
            AddInclude(x => x.Brand);
        }

        public ProductsWithTypesAndBrandsSpecification(Guid id) : base(x => x.Id == id)
        {
            AddInclude(x => x.Type);
            AddInclude(x => x.Brand);
        }
    }
}
