//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotePalaceWebApp2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Users
    {
        public Users()
        {
            this.Reserves = new HashSet<Reserves>();
        }
    
        public int ID { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
        public Nullable<int> Class { get; set; }
    
        public virtual ICollection<Reserves> Reserves { get; set; }
        public virtual UserDetails UserDetails { get; set; }
    }
}