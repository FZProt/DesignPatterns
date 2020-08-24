using System;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            bool islogenabled = true;
            var shoppingcartfactory = new ShoppingCartFactory();
            var cart = shoppingcartfactory.getCart(islogenabled);

            Execute(cart);

        }

        private static void Execute(IShoppingCart cart)
        {
            cart.addProduct(new Product() { Id=1, Name="shirt", Quantity=2 });
            cart.addProduct(new Product() { Id = 2, Name = "socks", Quantity = 2 });
            cart.removeProduct(new Product() { Id = 1, Name = "shirt" });
            cart.updateQuantity(new Product() { Id=2, Name="socks" }, 5);
        }
    }

    class ShoppingCartFactory
    {
        public ShoppingCartFactory()
        {
        }
        public IShoppingCart getCart(bool islogenabled)
        {
            if (islogenabled)
            {
                return new ShoppingCartWithLogging(new ShoppingCart());
            }
            else
            {
                return new ShoppingCart();
            }
        }
    }
}
