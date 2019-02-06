using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities;
using DA;
namespace MAS_WorkFlowService
{

    public sealed class MQRApproveRequestActivity : CodeActivity
    {
        // Define an activity input argument of type string
        public InArgument<Int32> RequestId { get; set; }
        public InArgument<string> ApprovedBy { get; set; }
        public InArgument<string> Rank { get; set; }
        public InOutArgument<bool> IsApproved { get; set; }
        public OutArgument<bool> hasCompleteApproval { get; set; }
        // If your activity returns a value, derive from CodeActivity<TResult>
        // and return the value from the Execute method.
        protected override void Execute(CodeActivityContext context)
        {
            // Obtain the runtime value of the Text input argument
            Int32 _requestId = context.GetValue(this.RequestId);
            string approvedBy = context.GetValue(this.ApprovedBy);
            bool isApproved = context.GetValue(this.IsApproved);
            string rank = context.GetValue(this.ApprovedBy);
            using (var unitOfWork = new UnitOfWork())
            {

                var currentRequest = unitOfWork.RequestRepository.Get(_requestId, x => x.MQRRequiredApprovals);

                var approval = currentRequest.MQRRequiredApprovals.Where(x => x.User == null).FirstOrDefault();

                approval.User = approvedBy;
                approval.isApproved = isApproved;
                unitOfWork.Complete();


                if (currentRequest.MQRRequiredApprovals.Where(x => x.User == null).FirstOrDefault() == null)
                {

                    context.SetValue(this.hasCompleteApproval, true);

                    if (currentRequest.MQRRequiredApprovals.Where(x => x.isApproved.Equals(false)).FirstOrDefault() == null)
                    {
                        context.SetValue(this.IsApproved, true);
                    }
                    else { context.SetValue(this.IsApproved, false); }



                }
                else { context.SetValue(this.hasCompleteApproval, false); context.SetValue(this.IsApproved, false); }


            }
        }
    }
}
