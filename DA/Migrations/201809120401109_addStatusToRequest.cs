namespace DA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addStatusToRequest : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Request", "Status", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Request", "Status");
        }
    }
}
