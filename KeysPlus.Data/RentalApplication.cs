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
    
    public partial class RentalApplication
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RentalApplication()
        {
            this.RentalApplicationMedia = new HashSet<RentalApplicationMedia>();
        }
    
        public int Id { get; set; }
        public int RentalListingId { get; set; }
        public int PersonId { get; set; }
        public string Note { get; set; }
        public Nullable<int> TenantsCount { get; set; }
        public int ApplicationStatusId { get; set; }
        public string TenantIdType { get; set; }
        public string TenantIdNo { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public System.DateTime UpdatedOn { get; set; }
        public bool IsActive { get; set; }
        public Nullable<bool> IsViewedByOwner { get; set; }
        public Nullable<int> EmploymentInYears { get; set; }
        public Nullable<int> EmploymentInMonths { get; set; }
        public Nullable<decimal> IncomePerWeek { get; set; }
        public Nullable<decimal> OtherIncome { get; set; }
        public string WorkManagerName { get; set; }
        public string WorkManagerPhone { get; set; }
        public string PreviousEmployment { get; set; }
        public Nullable<System.DateTime> PreferredMoveInDate { get; set; }
        public Nullable<int> IntendedLength { get; set; }
        public Nullable<bool> Smokers { get; set; }
        public string Commitment { get; set; }
        public Nullable<bool> Winz { get; set; }
        public string WinzNumber { get; set; }
        public Nullable<bool> Pets { get; set; }
        public string PetsDescription { get; set; }
        public Nullable<bool> BeenEvicted { get; set; }
        public string BennEvictedDetail { get; set; }
        public Nullable<bool> CriminalOffence { get; set; }
        public string CriminalOffenceDetail { get; set; }
        public Nullable<bool> AcceptePropertyConditionOption { get; set; }
        public string AcceptePropertyConditionOptionDetail { get; set; }
        public string DriverLicenseNO { get; set; }
        public string DriverLicenseVersion { get; set; }
        public string CarRegisteration { get; set; }
        public string CarMake { get; set; }
        public string CarModel { get; set; }
        public string CurrentLandlordFirstName { get; set; }
        public string CurrentLandlordLastName { get; set; }
        public string CurrentLandlordPhoneNumber { get; set; }
        public string CurrentLandlordEmail { get; set; }
        public Nullable<bool> CanBeRef { get; set; }
        public string EmergencyContactFirstName { get; set; }
        public string EmergencyContactLastName { get; set; }
        public string EmergencyContactEmail { get; set; }
        public string EmergencyContactPhone { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string HomePhone { get; set; }
        public string WorkPhone { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public Nullable<System.DateTime> DateOfBirth { get; set; }
    
        public virtual Person Person { get; set; }
        public virtual RentalApplicationStatus RentalApplicationStatus { get; set; }
        public virtual RentalListing RentalListing { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RentalApplicationMedia> RentalApplicationMedia { get; set; }
    }
}
