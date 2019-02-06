using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA.Migrations
{
    public class CreateViewOperation : System.Data.Entity.Migrations.Model.MigrationOperation
    {
        public CreateViewOperation(string viewName, string viewQueryString)
          : base(null)
        {
            ViewName = viewName;
            ViewString = viewQueryString;
        }
        public string ViewName { get; private set; }
        public string ViewString { get; private set; }
        public override bool IsDestructiveChange
        {
            get { return false; }
        }
    }
    public class CreateMaintananceViewOperation : System.Data.Entity.Migrations.Model.MigrationOperation
    {
        public CreateMaintananceViewOperation(string viewName, string code)
          : base(null)
        {
            ViewName = viewName;
            Code = code;
        }
        public string ViewName { get; private set; }
        public string Code { get; private set; }
        public override bool IsDestructiveChange
        {
            get { return false; }
        }
    }
    public class RemoveViewOperation : System.Data.Entity.Migrations.Model.MigrationOperation
    {
        public RemoveViewOperation(string viewName)
          : base(null)
        {
           // ViewName = viewName;
            ViewString = @"DROP VIEW IF EXISTS " + viewName;
        }
        public string ViewName { get; private set; }
        public string ViewString { get; private set; }
        public override bool IsDestructiveChange
        {
            get { return false; }
        }
    }

   
}
