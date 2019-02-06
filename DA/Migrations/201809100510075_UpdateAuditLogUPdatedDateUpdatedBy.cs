namespace DA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateAuditLogUPdatedDateUpdatedBy : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AuditLog", "CreatedDate", c => c.DateTime());
            AddColumn("dbo.AuditLog", "CreatedBy", c => c.String());
            AddColumn("dbo.AuditLog", "UpdatedDate", c => c.DateTime());
            AddColumn("dbo.AuditLog", "UpdatedBy", c => c.String());
            DropColumn("dbo.AuditLog", "UserName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AuditLog", "UserName", c => c.String());
            DropColumn("dbo.AuditLog", "UpdatedBy");
            DropColumn("dbo.AuditLog", "UpdatedDate");
            DropColumn("dbo.AuditLog", "CreatedBy");
            DropColumn("dbo.AuditLog", "CreatedDate");
        }
    }
}
