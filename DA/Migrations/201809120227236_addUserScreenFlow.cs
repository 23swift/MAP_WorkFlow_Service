namespace DA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addUserScreenFlow : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AdditionalFacility", "userScreenFlow", c => c.String());
            AddColumn("dbo.BranchAffiliation", "userScreenFlow", c => c.String());
            AddColumn("dbo.POSRequest", "userScreenFlow", c => c.String());
            AddColumn("dbo.FileMaintenance", "userScreenFlow", c => c.String());
            AddColumn("dbo.NewAffiliation", "userScreenFlow", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.NewAffiliation", "userScreenFlow");
            DropColumn("dbo.FileMaintenance", "userScreenFlow");
            DropColumn("dbo.POSRequest", "userScreenFlow");
            DropColumn("dbo.BranchAffiliation", "userScreenFlow");
            DropColumn("dbo.AdditionalFacility", "userScreenFlow");
        }
    }
}
