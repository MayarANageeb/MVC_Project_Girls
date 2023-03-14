using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCProject.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; } ///Order Date
        public DateTime ShipDate { get; set; }
        public int Totalprice { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StreetAddress {get; set;}

        [MaxLength(11, ErrorMessage = "Phone Number Must be 11 Numbers")]
        public string Phone { get; set;}


        [RegularExpression(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z",
        ErrorMessage = "Please enter a correct e-mail address")]
        public string Email { get; set; }

        [ForeignKey("Payment")]
        public int PaymentId { get; set; }
        public virtual Payment Payment { get; set; }
        public virtual List<OrderDetails> OrderDetails { get; set; }
    }
}
