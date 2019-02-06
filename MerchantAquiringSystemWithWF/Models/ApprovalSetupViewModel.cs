using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MerchantAquiringSystemWithWF.Models
{
    public class ApprovalSetupViewModel
    {
       

            public Int32 Id { get; set; }
            public Int32 ApprovalCount { get; set; }
            public string Rank { get; set; }
            public bool WithRequirements { get; set; }
            public bool WithException { get; set; }

            public String RequestType { get; set; }


       
    }
}