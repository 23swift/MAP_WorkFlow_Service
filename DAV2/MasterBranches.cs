//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAV2
{
    using System;
    using System.Collections.Generic;
    
    public partial class MasterBranches
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MasterBranches()
        {
            this.AdditionalFacility = new HashSet<AdditionalFacility>();
            this.MasterMID = new HashSet<MasterMID>();
            this.MasterTID = new HashSet<MasterTID>();
        }
    
        public int Id { get; set; }
        public Nullable<int> Business_Id { get; set; }
        public Nullable<int> AddFacility_Id { get; set; }
        public Nullable<System.Guid> Code { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AdditionalFacility> AdditionalFacility { get; set; }
        public virtual MasterBusiness MasterBusiness { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MasterMID> MasterMID { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MasterTID> MasterTID { get; set; }
    }
}
