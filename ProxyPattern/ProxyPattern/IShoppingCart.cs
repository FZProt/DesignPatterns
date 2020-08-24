using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern
{
    interface IShoppingCart
    {
        public void addProduct(Product pd);
        public void removeProduct(Product pd);
        public void updateQuantity(Product pd, int newQuantity);
        public void checkout();
    }
}
