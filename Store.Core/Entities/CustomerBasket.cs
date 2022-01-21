using System;
using System.Collections.Generic;

namespace Store.Core.Entities
{
    public class CustomerBasket
    {
        public CustomerBasket(Guid id)
        {
            Id = id;
        }

        public CustomerBasket()
        {

        }

        public Guid Id { get; set; }

        public List<BasketItem> Items { get; set; } = new List<BasketItem>();
    }
}
