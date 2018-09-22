using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Bookshop_Management.Models
{
    public class CartItem
    {   
        [DisplayName("Item Name")]
        public String ItemName { get; set; }

        [DisplayName("Unit Price")]
        public int UnitPrice { get; set; }

        public int Quantity { get; set; }

        [DisplayName("Total Price")]
        public int TotalPrice { get; set; }
    }
}
