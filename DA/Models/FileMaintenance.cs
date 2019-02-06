using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA.Models
{
   public class FileMaintenance:BaseEntity
    {
        [ForeignKey("Request")]
        public Int32 Id { get; set; }
        public LegalEntity LegalEntity { get; set; }
        public virtual Request Request { get; set; }
        public string userScreenFlow { get; set; }
    }

    public class LegalEntity
    {
        public Int32 Id { get; set; }
        public Customer Customer { get; set; }
    }
}
