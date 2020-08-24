using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern
{
    class ShoppingCartWithLogging : IShoppingCart
    {
        private ShoppingCart _mainshoppingCart;

        public ShoppingCartWithLogging(ShoppingCart shoppingCart)
        {
            this._mainshoppingCart = shoppingCart;
        }

        public void addProduct(Product pd)
        {
            Console.WriteLine("logging before");
            _mainshoppingCart.addProduct(pd);
            Console.WriteLine("logging after");
        }

        public void removeProduct(Product pd)
        {
            Console.WriteLine("logging before");
            _mainshoppingCart.removeProduct(pd);
            Console.WriteLine("logging after");
        }

        public void updateQuantity(Product pd, int newQuantity)
        {
            Console.WriteLine("logging before");
            _mainshoppingCart.updateQuantity(pd, newQuantity);
            Console.WriteLine("logging after");
        }
        public void checkout()
        {
            //throw new NotImplementedException();
        }
    }
}
