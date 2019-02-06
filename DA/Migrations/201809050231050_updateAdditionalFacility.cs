namespace DA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateAdditionalFacility : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AdditionalFacility", "CreatedDate", c => c.DateTime());
            AddColumn("dbo.AdditionalFacility", "CreatedBy", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AdditionalFacility", "CreatedBy");
            DropColumn("dbo.AdditionalFacility", "CreatedDate");
        }
    }
}
