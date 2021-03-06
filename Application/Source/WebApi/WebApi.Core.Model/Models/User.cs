//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApi.Core.Model.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public System.Guid Id { get; set; }
        public string DisplayName { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public Nullable<int> Contact { get; set; }
        public string Paassword { get; set; }
        public Nullable<int> TimeZondeId { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<System.DateTime> DateDeleted { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public Nullable<System.DateTime> ModifiedBy { get; set; }
    
        public virtual TimeZone TimeZone { get; set; }
    }
}
