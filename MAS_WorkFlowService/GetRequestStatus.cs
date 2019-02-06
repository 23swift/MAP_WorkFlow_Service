using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities;
using DA;
namespace MAS_WorkFlowService
{

    public sealed class GetRequestStatus : CodeActivity
    {
        // Define an activity input argument of type string
        public OutArgument<Int32> Status { get; set; }
        public InArgument<Int32> RequestId { get; set; }
        // If your activity returns a value, derive from CodeActivity<TResult>
        // and return the value from the Execute method.
        protected override void Execute(CodeActivityContext context)
        {
            // Obtain the runtime value of the Text input argument
           // Int32 _status = context.GetValue(this.Status);
            Int32 _requestId = context.GetValue(this.RequestId);

            using (var unitOfWork = new UnitOfWork())
            {
                
                var _status = unitOfWork.RequestRepository.Get(_requestId).Status;
                context.SetValue(this.Status, _status);
                // unitOfWork.Complete();
            }

        }
    }
}
