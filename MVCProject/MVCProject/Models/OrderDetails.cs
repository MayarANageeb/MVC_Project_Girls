﻿using System.ComponentModel.DataAnnotations.Schema;

namespace MVCProject.Models
{
    public class OrderDetails
    {
        public int Id { get; set; }
        [ForeignKey("Product")]
        public int ProId { get; set; }
        public virtual Product Product { get; set; }

        [ForeignKey("Order")]
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }

    }
}
