using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA.Models
{
    public class BranchAffiliation
    {
        public BranchAffiliation()
        {
            Branches = new HashSet<Branch>();
        }

        [ForeignKey("Request")]
        public Int32 Id { get; set; }

        public Boolean WithRequirements { get; set; }
        public Boolean WithException { get; set; }
        public virtual ICollection<Branch> Branches { get; set; }

        public string userScreenFlow { get; set; }
        public string eMail { get; set; }
        public virtual Customer Customer { get; set; }

        public virtual Request Request { get; set; }
    }
}
