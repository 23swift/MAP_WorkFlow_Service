namespace DA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateAuditLogOldValuesNewValues : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AuditLog", "OldValues", c => c.String());
            AddColumn("dbo.AuditLog", "NewValues", c => c.String());
            DropColumn("dbo.AuditLog", "OldValue");
            DropColumn("dbo.AuditLog", "NewValue");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AuditLog", "NewValue", c => c.String());
            AddColumn("dbo.AuditLog", "OldValue", c => c.String());
            DropColumn("dbo.AuditLog", "NewValues");
            DropColumn("dbo.AuditLog", "OldValues");
        }
    }
}
