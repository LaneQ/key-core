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
    
    public partial class PropertyRequestMedia
    {
        public int Id { get; set; }
        public int PropertyRequestId { get; set; }
        public string OldFileName { get; set; }
        public string NewFileName { get; set; }
        public bool IsActive { get; set; }
    
        public virtual PropertyRequest PropertyRequest { get; set; }
    }
}