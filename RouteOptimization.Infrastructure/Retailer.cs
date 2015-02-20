namespace RouteOptimization.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Retailer")]
    public partial class Retailer
    {
        public Retailer()
        {
            Stores = new HashSet<Store>();
        }

        public int RetailerID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string RetailerNumber { get; set; }

        [StringLength(50)]
        public string EmailID { get; set; }

        [Required]
        [StringLength(50)]
        public string Phone { get; set; }

        public int AddressID { get; set; }

        public virtual Address Address { get; set; }

        public virtual ICollection<Store> Stores { get; set; }
    }
}
