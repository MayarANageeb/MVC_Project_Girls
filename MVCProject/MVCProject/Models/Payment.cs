using System.ComponentModel.DataAnnotations.Schema;

namespace MVCProject.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public bool Allowed { get; set; }

        [ForeignKey("Order")]
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }
    }
}
