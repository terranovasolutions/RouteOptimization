namespace RouteOptimization.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Store")]
    public partial class Store
    {
        public int StoreID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string StoreNumber { get; set; }

        public int RetailerID { get; set; }

        [StringLength(50)]
        public string EmailID { get; set; }

        [Required]
        [StringLength(50)]
        public string Phone { get; set; }

        public int AddressID { get; set; }

        public virtual Address Address { get; set; }

        public virtual Retailer Retailer { get; set; }
    }
}
