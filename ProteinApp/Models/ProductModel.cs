using System.Transactions;

namespace ProteinApp.Models
{
    public class Product
    {
        public int p_quantity { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public string p_img { get; set; }

        public double total()
        {
            return p_quantity * Price;
        }

      
    }


}
