using Store.Core.Entities;
using System;
using System.Threading.Tasks;

namespace Store.Core.Interfaces
{
    public interface IBasketRepository
    {
        Task<CustomerBasket> GetBasketAsync(Guid basketId);

        Task<CustomerBasket> UpdateBasketAsync(CustomerBasket basket);

        Task<bool> DeleteBasketAsync(Guid basketId);
    }
}
