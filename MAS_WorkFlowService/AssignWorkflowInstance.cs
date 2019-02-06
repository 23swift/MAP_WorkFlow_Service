using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities;
using DA;
namespace MAS_WorkFlowService
{

    public sealed class AssignWorkflowInstance : CodeActivity
    {
        // Define an activity input argument of type string
        public InArgument<Int32> RequestId { get; set; }

        // If your activity returns a value, derive from CodeActivity<TResult>
        // and return the value from the Execute method.
        protected override void Execute(CodeActivityContext context)
        {
          
            Int32 _requestId = context.GetValue(this.RequestId);

            using (var unitOfWork = new UnitOfWork())
            {


                var currentRequest = unitOfWork.RequestRepository.Get(_requestId);
                currentRequest.WorkflowInstanceId = context.WorkflowInstanceId;
                currentRequest.Status = RequestState.AO_CHECKING.Value;
                unitOfWork.Complete();
            }

        }
    }
}
