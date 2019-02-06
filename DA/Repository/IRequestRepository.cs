using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA
{
  public  interface IRequestRepository:IRepository<Models.Request,Int32>
    {
        IEnumerable<Models.Request> GetRequestWithBranches(int pageIndex, int pageSize = 10);
    }
    public interface IMAEFRepository : IRepository<Models.MAEF, Int32>
    {
        //  IEnumerable<Models.MAEF> GetRequestWithBranches(int pageIndex, int pageSize = 10);
    }
    public interface IPOSRepository : IRepository<Models.POSRequest, Int32>
    {
       // IEnumerable<Models.Request> GetRequestWithBranches(int pageIndex, int pageSize = 10);
    }
}
