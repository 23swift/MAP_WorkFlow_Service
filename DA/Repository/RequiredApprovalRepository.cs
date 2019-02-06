namespace DA
{
    internal class RequiredApprovalRepository : Repository<Models.RequiredApproval, int>, IRequiredApprovalRepository
    {
       

        public RequiredApprovalRepository(MAS_DB context)
              : base(context)
        {
            
        }
    }
}