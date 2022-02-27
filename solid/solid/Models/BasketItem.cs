using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace solid.Models
{
    public class BasketItem
    {
        public Product product { get; set; }
        public int count { get; set; }
        public int totalPrice { get; set; }
        public BasketItem()
        {}

        public BasketItem(Product p)
        {
            product = p;
            totalPrice = p.Price;
            count = 1;
        }

        public void increaseCount()
        {
            this.count++;
            totalPrice += product.Price;
        }

        public void decreaseCount()
        {
            this.count--;
            totalPrice -= product.Price;
        }
    }
}
