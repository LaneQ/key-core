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
    
    public partial class Job
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Job()
        {
            this.JobMedia = new HashSet<JobMedia>();
        }
    
        public int Id { get; set; }
        public Nullable<int> ProviderId { get; set; }
        public int PropertyId { get; set; }
        public decimal PaymentAmount { get; set; }
        public Nullable<System.DateTime> JobStartDate { get; set; }
        public Nullable<System.DateTime> JobEndDate { get; set; }
        public string JobDescription { get; set; }
        public int JobStatusId { get; set; }
        public string UpdatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime UpdatedOn { get; set; }
        public Nullable<decimal> MaxBudget { get; set; }
        public Nullable<int> PercentDone { get; set; }
        public string Note { get; set; }
        public Nullable<decimal> AcceptedQuote { get; set; }
        public Nullable<bool> OwnerUpdate { get; set; }
        public Nullable<bool> ServiceUpdate { get; set; }
        public Nullable<int> JobRequestId { get; set; }
        public Nullable<int> OwnerId { get; set; }
    
        public virtual ServiceProviderJobStatus ServiceProviderJobStatus { get; set; }
        public virtual Property Property { get; set; }
        public virtual ServiceProvider ServiceProvider { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JobMedia> JobMedia { get; set; }
    }
}
