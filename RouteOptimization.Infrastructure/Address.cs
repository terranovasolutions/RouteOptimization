//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RouteOptimization.Infrastructure
{
    using System;
    using System.Collections.Generic;
    
    public partial class Address
    {
        public Address()
        {
            this.Retailers = new HashSet<Retailer>();
            this.Stores = new HashSet<Store>();
        }
    
        public int AddressID { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public int CityID { get; set; }
        public int ProvinceID { get; set; }
        public string PostalCode { get; set; }
        public int CountryID { get; set; }
    
        public virtual City City { get; set; }
        public virtual Country Country { get; set; }
        public virtual Province Province { get; set; }
        public virtual ICollection<Retailer> Retailers { get; set; }
        public virtual ICollection<Store> Stores { get; set; }
    }
}
