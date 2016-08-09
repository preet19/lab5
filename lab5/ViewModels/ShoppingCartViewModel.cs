using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using lab5.Models;

namespace lab5.ViewModels
{
    public class ShoppingCartViewModel
    {
        public virtual List<Cart> CartItems { get; set; }
        public virtual decimal CartTotal { get; set; }
    }
}