//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KeysPlus.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class JobWatchList
    {
        public int Id { get; set; }
        public int MarketJobId { get; set; }
        public int PersonId { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public System.DateTime UpdatedOn { get; set; }
        public bool IsActive { get; set; }
    
        public virtual Person Person { get; set; }
        public virtual TenantJobRequest TenantJobRequest { get; set; }
    }
}
