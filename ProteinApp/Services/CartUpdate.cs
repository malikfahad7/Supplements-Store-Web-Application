namespace ProteinApp.Services
{
    public class CartUpdate
    {
        public int cartvalue { get; set; } = 0;

        public void cartIncrement()
        {
            cartvalue++;
        }
        public void cartDecrement()
        {
            cartvalue--;
        }
    }
}
