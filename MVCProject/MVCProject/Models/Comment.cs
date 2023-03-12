using System.ComponentModel.DataAnnotations.Schema;

namespace MVCProject.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string UserName { get; set; }


        [ForeignKey("Product")]
        public int ProId { get; set; }
        public virtual Product Product { get; set; }
    }
}
