namespace RouteOptimization.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserType")]
    public partial class UserType
    {
        public UserType()
        {
            Users = new HashSet<User>();
        }

        public int UserTypeID { get; set; }

        [Required]
        [StringLength(50)]
        public string Description { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
