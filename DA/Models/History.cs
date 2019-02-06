using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA.Models
{
    public partial class History
    {

        public int HistoryId { get; set; }

        public System.DateTime date { get; set; }

        public string remarks { get; set; }

        public string action { get; set; }

        public string user { get; set; }

        public string groupCode { get; set; }

        //public virtual Request Request { get; set; }
    }
}
