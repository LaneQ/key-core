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
    
    public partial class RentalPaymentTracking
    {
        public int Id { get; set; }
        public int TenantPropertyId { get; set; }
        public System.DateTime DueDate { get; set; }
        public bool PaymentComplete { get; set; }
    
        public virtual TenantProperty TenantProperty { get; set; }
    }
}