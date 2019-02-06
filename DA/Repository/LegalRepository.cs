namespace DA
{
    internal class LegalRepository : Repository<Models.LegalEntity, int>, ILegalRepository
    {
        private MAS_DB _context;

        public LegalRepository(MAS_DB context)
             : base(context)
        {
           
        }
    }
}