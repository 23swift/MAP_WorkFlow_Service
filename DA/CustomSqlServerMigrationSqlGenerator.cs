using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Model;
using System.Data.Entity.Migrations.Utilities;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA.Migrations
{
    public class CustomSqlServerMigrationSqlGenerator
  : SqlServerMigrationSqlGenerator
    {
        protected override void Generate(MigrationOperation migrationOperation)
        {
            var operation = migrationOperation as CreateViewOperation;
            if (operation != null)
            {
                using (IndentedTextWriter writer = Writer())
                {
                    writer.WriteLine("CREATE VIEW {0} AS {1}; ",
                                      operation.ViewName,
                                      operation.ViewString);
                    Statement(writer);
                }
            }
        }
    }
    public class CustomSqlServerMigrationSqlViewGenerator
: SqlServerMigrationSqlGenerator
    {
        protected override void Generate(MigrationOperation migrationOperation)
        {
            var operation = migrationOperation as CreateMaintananceViewOperation;
            if (operation != null)
            {
                using (IndentedTextWriter writer = Writer())
                {
                    //writer.WriteLine(@"DROP VIEW IF EXISTS "+ operation.ViewName+";");
                    writer.WriteLine(@"CREATE VIEW {0} AS
                        SELECT a.Id as {1}_Id, a.Value as Description, a.Code
                        FROM dbo.MaintenanceDetails a inner join [dbo].[MaintenanceMaster] b
				        ON a.MaintenanceMaster_Id=b.Id
                        WHERE b.Code='{2}' and a.isDeleted=0;",
                                     operation.ViewName, getViewKeyName(operation.ViewName), operation.Code);
                    Statement(writer);
                }
            }

            var operationRemoveView = migrationOperation as RemoveViewOperation;
            if (operationRemoveView != null)
            {
                using (IndentedTextWriter writer = Writer())
                {
                    writer.WriteLine(operationRemoveView.ViewString);
                    Statement(writer);
                }
            }

        }

        private string getViewKeyName(string ViewName) {
            const string shceme = "dbo.";
            const string postFix = "View";

            return ViewName.Replace(shceme, "").Replace(postFix, "");

        }
    }

    public class RemoveViewrMigrationSqlGenerator
: SqlServerMigrationSqlGenerator
    {
        protected override void Generate(MigrationOperation migrationOperation)
        {
            var operation = migrationOperation as RemoveViewOperation;
            if (operation != null)
            {
                using (IndentedTextWriter writer = Writer())
                {
                    writer.WriteLine(operation.ViewString);
                    Statement(writer);
                }
            }
        }
    }
}
