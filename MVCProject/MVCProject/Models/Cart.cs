using System.ComponentModel.DataAnnotations.Schema;

namespace MVCProject.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int Total { get; set; }

        public virtual List<Product> Products { get; set; }

        [ForeignKey("ApplicationUser")]
        public int UserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }

    }
}
