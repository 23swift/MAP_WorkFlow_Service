namespace DA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateBusiness : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Business", "DTIRegDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Business", "DTIRegDate");
        }
    }
}
