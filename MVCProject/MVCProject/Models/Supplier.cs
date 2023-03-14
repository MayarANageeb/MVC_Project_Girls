using System.ComponentModel.DataAnnotations;

namespace MVCProject.Models
{
    public class Supplier
    {
        public int Id { get; set; }
        public string Name { get; set; }


        [RegularExpression(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z",
         ErrorMessage = "Please enter a correct e-mail address")]
         public string Email { get; set; }

        [MaxLength(11,ErrorMessage ="Phone Number Must be 11 Numbers")]
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        public virtual List<Product> Products { get; set; }
    }
}
