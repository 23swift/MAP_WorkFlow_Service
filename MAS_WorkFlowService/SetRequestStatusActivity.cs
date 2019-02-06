using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities;
using DA;
namespace MAS_WorkFlowService
{

    public sealed class SetRequestStatusActivity : CodeActivity
    {
        // Define an activity input argument of type string
        public InArgument<Int32> Status { get; set; }
        public InArgument<Int32> RequestId { get; set; }
        // If your activity returns a value, derive from CodeActivity<TResult>
        // and return the value from the Execute method.
        protected override void Execute(CodeActivityContext context)
        {
            // Obtain the runtime value of the Text input argument
            Int32 _status = context.GetValue(this.Status);
            Int32 _requestId = context.GetValue(this.RequestId);
            string displayName = this.DisplayName.Trim();

            using (var unitOfWork = new UnitOfWork()) {


                var currentRequest = unitOfWork.RequestRepository.Get(_requestId);
                //currentRequest.Status = _status;
                currentRequest.Status = RequestConfigHelper.GetStatus(displayName).Value;

                unitOfWork.Complete();
            }

        }
    }
}
