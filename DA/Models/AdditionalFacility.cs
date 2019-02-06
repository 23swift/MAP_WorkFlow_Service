using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA.Models
{
   public class AdditionalFacility : BaseEntity
    {
        [ForeignKey("Request")]
        public Int32 Id { get; set; }
       public string RequestDesc { get; set; }
        public virtual Request Request { get; set; }
        public string userScreenFlow { get; set; }
    }
}
