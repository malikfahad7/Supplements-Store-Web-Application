using ProteinApp.Models;

namespace ProteinApp.Services
{
    public class CartService
    {
        private List<Product> cartItems = new List<Product>();

        public void AddTocart(Product product)
        {
            cartItems.Add(product);
        }

        public List<Product> GetCartItems()
        {
            return cartItems;
        }
    }

}
