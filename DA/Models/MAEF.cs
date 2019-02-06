using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA.Models
{
    public partial class MAEF
    {

        public MAEF()
        {
            //this.CreditChecking = new HashSet<CreditChecking>();
        }


        public Int32 Id { get; set; }

        public Nullable<int> affiliation { get; set; }

        public string tangent { get; set; }

        public Nullable<int> requestType { get; set; }

        public Nullable<bool> simulInstallment { get; set; }

        public Nullable<bool> simulDebit { get; set; }

        public string currency { get; set; }

        public Nullable<int> creditMidCount { get; set; }

        public Nullable<int> debitTidCount { get; set; }

        public string pepList { get; set; }

        public string pepListRemarks { get; set; }

        public Nullable<bool> isDeclined { get; set; }

        public string declinedRemarks { get; set; }

        public Nullable<int> location { get; set; }

        public string appearance { get; set; }

        public Nullable<bool> withTelephone { get; set; }

        public Nullable<bool> isLargeAccount { get; set; }

        public string natureOfBusiness { get; set; }

        public Nullable<bool> mccCorrect { get; set; }

        public string personalAccountNo { get; set; }

        public string isBdoAccountNo { get; set; }

        public string psv { get; set; }

        public Nullable<bool> isSignatureVerified { get; set; }

       

        public string midCap { get; set; }

        public string payDelay { get; set; }

        public string holdoutAmt { get; set; }

        public string processedBy { get; set; }

        public string approvedBy { get; set; }
        public Nullable<bool> withRequirements { get; set; }

        public Nullable<bool> withException { get; set; }
        public Nullable<bool> tempoWaiver { get; set; }
        public Nullable<bool> permanentWaiver { get; set; }
        // public virtual Request Request { get; set; }

        // public virtual ICollection<CreditChecking> CreditChecking { get; set; }
    }
}
