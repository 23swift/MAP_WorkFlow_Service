
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA
{
    public class DropDownValues
    {
        protected MAS_DB Context;
        //protected DbSet<T> DbSet { get; set; }
        public DropDownValues(MAS_DB MAS_DbContext)
        {
            Context = MAS_DbContext;

            //DbSet = Context.Set<T>();
            //DbSet.AsNoTracking();
        }
        //public IEnumerable<T> GetAll()
        // {
        //     return DbSet.ToList();
        // }

        public IEnumerable<DA.Models.MaintenanceDetails> GetAll(string code)
        {
            return Context.MaintenanceMaster.Where(x => x.Code.Equals(code)).FirstOrDefault().MaintenanceDetails;
        }
    }
}
