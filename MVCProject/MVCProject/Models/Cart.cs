namespace MVCProject.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int Total { get; set; }

        public virtual List<Product> Products { get; set; }

    }
}
