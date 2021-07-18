using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorClientDinerApp.Models
{
    public class OrderResultModel
    {
        public OrderModel Order { get; set; }
        public string ItemPurchased { get; set; }
    }
}
