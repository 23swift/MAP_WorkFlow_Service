using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA.Models
{
    public class POSRequest : BaseEntity
    {
        [ForeignKey("Request")]
        public Int32 Id { get; set; }
        public string RequestDescription { get; set; }
        public Int32 Status { get; set; }
        public Guid WorkflowInstanceId { get; set; }
        public Request Request { get; set; }
        public string userScreenFlow { get; set; }

        // public virtual Branch Branch { get; set; }

    }
}
