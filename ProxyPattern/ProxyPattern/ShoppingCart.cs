using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProxyPattern
{
    class ShoppingCart: IShoppingCart
    {
        private List<Product> _products = new List<Product>();
        public void addProduct(Product pd)
        {
            _products.Add(pd);
        }
        public void removeProduct(Product pd)
        {
            _products.Remove(pd);
        }
        public void updateQuantity(Product pd, int newQuantity)
        {
            var storedProduct = _products.FirstOrDefault(p => p.Id == pd.Id);
            if(storedProduct != null)
            {
                storedProduct.Quantity = newQuantity;
            }
        }
        public void checkout()
        {

        }
    }
}
