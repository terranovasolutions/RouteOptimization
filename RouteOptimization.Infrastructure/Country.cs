namespace RouteOptimization.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Country")]
    public partial class Country
    {
        public Country()
        {
            Addresses = new HashSet<Address>();
            Provinces = new HashSet<Province>();
        }

        public int CountryID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }

        public virtual ICollection<Province> Provinces { get; set; }
    }
}
