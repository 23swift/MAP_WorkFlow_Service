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
    
    public partial class DetailsMaintenance
    {
        public int Id { get; set; }
        public Nullable<long> Masted_Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
    
        public virtual MasterMaintenance MasterMaintenance { get; set; }
    }
}
