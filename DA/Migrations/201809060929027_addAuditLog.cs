namespace DA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addAuditLog : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AuditLog",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        TrackingNo = c.String(),
                        Field = c.String(),
                        OldValue = c.String(),
                        NewValue = c.String(),
                        DateLoged = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.AuditLog");
        }
    }
}
