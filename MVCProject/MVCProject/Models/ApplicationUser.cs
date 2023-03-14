using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCProject.Models
{
    public class ApplicationUser:IdentityUser
    {
        //add any extra property
        public string Address { get; set; }

        [ForeignKey("Cart")]
        public int CartId { get; set; }
        public virtual Cart Cart { get; set; }
    }
}
