

namespace DA.Models
{
    using System.ComponentModel.DataAnnotations;
    using System;
    using System.Collections.Generic;
    
    public partial class MaintenanceMaster:BaseEntity
    {
     
        public MaintenanceMaster()
        {
            this.MaintenanceDetails = new HashSet<MaintenanceDetails>();
        }
    
    
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
    
      
        public virtual ICollection<MaintenanceDetails> MaintenanceDetails { get; set; }
    }
}
