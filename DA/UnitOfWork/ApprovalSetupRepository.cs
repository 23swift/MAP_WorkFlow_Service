namespace DA
{
    internal class ApprovalSetupRepository :Repository<DA.Models.ApprovalSetup,int>, IApprovalSetupRepository
    {
        

        public ApprovalSetupRepository(MAS_DB context)
            : base(context)
        {
        
        }
    }
}