namespace DA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateMAEF : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.MAEF", "Request_Id", "dbo.Request");
            DropIndex("dbo.MAEF", new[] { "Request_Id" });
            AddColumn("dbo.Request", "MAEF_Id", c => c.Int());
            CreateIndex("dbo.Request", "MAEF_Id");
            AddForeignKey("dbo.Request", "MAEF_Id", "dbo.MAEF", "Id");
            DropColumn("dbo.MAEF", "Request_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MAEF", "Request_Id", c => c.Int());
            DropForeignKey("dbo.Request", "MAEF_Id", "dbo.MAEF");
            DropIndex("dbo.Request", new[] { "MAEF_Id" });
            DropColumn("dbo.Request", "MAEF_Id");
            CreateIndex("dbo.MAEF", "Request_Id");
            AddForeignKey("dbo.MAEF", "Request_Id", "dbo.Request", "Id");
        }
    }
}
