using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA
{
  public interface IUnitOfWork:IDisposable
    {
       IRequestRepository RequestRepository { get;}
        IMAEFRepository MAEFRepository { get; }
        // DbContext Context { get; }

        int Complete();
    }
}
