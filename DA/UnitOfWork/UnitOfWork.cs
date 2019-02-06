using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace DA
{
    public class UnitOfWork:IUnitOfWork
    {
        private  MAS_DB _context= new MAS_DB();
        public UnitOfWork() {

            RequestRepository = new RequestRepository(_context);
            RequiredApprovalRepository= new RequiredApprovalRepository(_context);
            ApprovalSetupRepository=new ApprovalSetupRepository(_context);
            MAEFRepository = new MAEFRepository(_context);
           NewAffliationRepository= new NewAffiliationRepository(_context);
            BranchRepository=new BranchRepository(_context);
            LegalRepository = new LegalRepository(_context);
          
        }

        public MAS_DB Context
        {
            get
            {
                //if (_context == null)
                //{

                //    _context = new MAS_DB();
                //}
                return _context;
            }
        }

        public IRequestRepository RequestRepository
        {
            get; private set;
            
        }
        public INewAffliationRepository NewAffliationRepository
        {
            get; private set;

        }
        public IRequiredApprovalRepository RequiredApprovalRepository
        {
            get; private set;

        }
        public IApprovalSetupRepository ApprovalSetupRepository
        {
            get; private set;

        }
        public IPOSRepository POSRepository
        {
            get; private set;

        }
        public IMAEFRepository MAEFRepository
        {
            get; private set;

        }
        public IBranchRepository BranchRepository
        {
            get; private set;

        }



         public ILegalRepository LegalRepository
        {
            get; private set;



        }
       
        public int Complete()
        {

            return _context.SaveChanges();
        }

        public void Dispose(bool disposing)
        {
            if (disposing)
            {

                if (_context != null)
                {
                    _context.Dispose();
                    _context = null;
                }
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }

   
}