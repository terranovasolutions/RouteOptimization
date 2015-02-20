namespace RouteOptimization.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        public int ProductID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string ProductNumber { get; set; }

        [Column(TypeName = "money")]
        public decimal ListPrice { get; set; }

        [StringLength(50)]
        public string Size { get; set; }

        [StringLength(50)]
        public string Weight { get; set; }
    }
}
