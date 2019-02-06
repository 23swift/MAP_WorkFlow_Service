using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities;
using DA;
namespace MAS_WorkFlowService
{

    public sealed class CreateRequiredApprovals : CodeActivity
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

                var approvals = unitOfWork.ApprovalSetupRepository.Find(x => x.RequestType.Equals(currentRequest.RequestType)
                
                &&( x.WithRequirements.Equals(currentRequest.MAEF.withRequirements) || x.WithException.Equals(currentRequest.MAEF.withException))).ToList();

                currentRequest.RequiredApprovals= new List<DA.Models.RequiredApproval>();
                approvals.ForEach(x => {

                    for (int i = 0; i < x.ApprovalCount; i++)
                    {
                        currentRequest.RequiredApprovals.Add(new DA.Models.RequiredApproval
                        {

                            Rank = x.Rank,
                        });
                    }
                    

                }
               

                );
                unitOfWork.RequestRepository.Update(currentRequest);
                unitOfWork.Complete();
            }

        }
    }
}
