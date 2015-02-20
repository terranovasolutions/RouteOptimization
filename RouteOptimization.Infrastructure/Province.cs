namespace RouteOptimization.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Province")]
    public partial class Province
    {
        public Province()
        {
            Addresses = new HashSet<Address>();
            Cities = new HashSet<City>();
        }

        public int ProvinceID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public int CountryID { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }

        public virtual ICollection<City> Cities { get; set; }

        public virtual Country Country { get; set; }
    }
}
