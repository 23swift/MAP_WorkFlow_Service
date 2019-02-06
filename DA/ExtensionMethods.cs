using System.Data.Entity.Migrations;
using System.Data.Entity.Migrations.Infrastructure;

namespace DA.Migrations
{
  public static class Extensions
  {
    public static void CreateView(this DbMigration migration, string viewName, string viewqueryString)
    {
      ((IDbMigration) migration)
        .AddOperation(new CreateViewOperation(viewName, viewqueryString));
    }
        public static void CreateMaintananceView(this DbMigration migration, string viewName, string code)
        {
            ((IDbMigration)migration)
              .AddOperation(new CreateMaintananceViewOperation(viewName, code));
        }

        public static void RemoveView(this DbMigration migration, string viewName)
        {
            ((IDbMigration)migration)
              .AddOperation(new RemoveViewOperation(viewName));
        }
    }
}