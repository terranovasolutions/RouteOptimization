using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RouteOptimizationUI.Models
{
    public class Store
    {
        public int StoreID { get; set; }
        public string Name { get; set; }
        public string StoreNumber { get; set; }
        public int RetailerID { get; set; }
        public string EmailID { get; set; }
        public string Phone { get; set; }
        public int AddressID { get; set; }
        
    }
}