namespace RouteOptimization.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("City")]
    public partial class City
    {
        public City()
        {
            Addresses = new HashSet<Address>();
        }

        public int CityID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public int ProvinceID { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }

        public virtual Province Province { get; set; }
    }
}
