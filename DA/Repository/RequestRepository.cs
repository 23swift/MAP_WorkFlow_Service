using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DA.Models;

namespace DA
{
    public class RequestRepository:Repository<Models.Request,Int32>,IRequestRepository
    {
        public RequestRepository(MAS_DB context) 
            :base(context)
        { 

        }

        public IEnumerable<Request> GetRequestWithBranches(int pageIndex, int pageSize = 10)
        {
            return MAS_DBContext.Request.Skip(pageIndex).Take(pageSize).ToList();
        }
        public MAS_DB MAS_DBContext {

            get { return Context as MAS_DB; }

        }
    }
    public class POSRepository : Repository<Models.Request, Int32>
    {
        public POSRepository(MAS_DB context)
            : base(context)
        {

        }

        //public IEnumerable<Request> GetRequestWithBranches(int pageIndex, int pageSize = 10)
        //{
        //    return MAS_DBContext.Request.Skip(pageIndex).Take(pageSize).ToList();
        //}
        public MAS_DB MAS_DBContext
        {

            get { return Context as MAS_DB; }

        }
    }
    public class MAEFRepository : Repository<Models.MAEF, Int32>,IMAEFRepository
    {
        public MAEFRepository(MAS_DB context)
            : base(context)
        {

        }

        //public IEnumerable<Request> GetRequestWithBranches(int pageIndex, int pageSize = 10)
        //{
        //    return MAS_DBContext.Request.Skip(pageIndex).Take(pageSize).ToList();
        //}
        public MAS_DB MAS_DBContext
        {

            get { return Context as MAS_DB; }

        }
    }
    public class NewAffiliationRepository : Repository<Models.NewAffiliation, Int32>, INewAffliationRepository
    {
        public NewAffiliationRepository(MAS_DB context)
             : base(context)
        {

        }
    }
    public class BranchRepository : Repository<Models.Branch, Int32>, IBranchRepository
    {
        public BranchRepository(MAS_DB context)
             : base(context)
        {

        }
    }
}