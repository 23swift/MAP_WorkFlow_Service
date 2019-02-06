namespace DA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateAuditLog : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AuditLog", "Entity", c => c.String());
            DropColumn("dbo.AuditLog", "Field");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AuditLog", "Field", c => c.String());
            DropColumn("dbo.AuditLog", "Entity");
        }
    }
}
