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
    
    public partial class User
    {
        public User()
        {
            this.Rosters = new HashSet<Roster>();
        }
    
        public int UserID { get; set; }
        public int UserTypeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailID { get; set; }
        public string Phone { get; set; }
        public int AddressID { get; set; }
    
        public virtual ICollection<Roster> Rosters { get; set; }
        public virtual UserType UserType { get; set; }
    }
}
