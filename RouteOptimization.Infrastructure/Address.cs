namespace RouteOptimization.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Address")]
    public partial class Address
    {
        public Address()
        {
            Retailers = new HashSet<Retailer>();
            Stores = new HashSet<Store>();
        }

        public int AddressID { get; set; }

        [Required]
        [StringLength(50)]
        public string Address1 { get; set; }

        [StringLength(50)]
        public string Address2 { get; set; }

        public int CityID { get; set; }

        public int ProvinceID { get; set; }

        [Required]
        [StringLength(50)]
        public string PostalCode { get; set; }

        public int CountryID { get; set; }

        public virtual City City { get; set; }

        public virtual Country Country { get; set; }

        public virtual Province Province { get; set; }

        public virtual ICollection<Retailer> Retailers { get; set; }

        public virtual ICollection<Store> Stores { get; set; }
    }
}
