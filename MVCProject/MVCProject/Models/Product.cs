using System.ComponentModel.DataAnnotations.Schema;

namespace MVCProject.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Image { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }

        [ForeignKey("SubCategory")]
        public int SubCatId { get; set; }
        public virtual SubCategory SubCategory { get; set; }

        [ForeignKey("Cart")]
        public int CartId { get; set; }
        public virtual Cart Cart { get; set; }

        [ForeignKey("Supplier")]
        public int SupplierId { get; set; }
        public virtual Supplier Supplier { get; set; }

        public virtual List<Comment> Comments { get; set; }

        public virtual List<OrderDetails> OrderDetails { get; set; }

    }
}
