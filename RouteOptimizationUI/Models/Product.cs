using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RouteOptimizationUI.Models
{
    public class Product
    {
       public Int32 productId { get; set; }
       public string productName { get; set; }
       public string productNumber { get; set; }
       public double price { get; set; }
       public double size { get; set; }
       public double weight { get; set; }
    }

}