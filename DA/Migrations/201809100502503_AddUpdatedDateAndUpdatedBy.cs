namespace DA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUpdatedDateAndUpdatedBy : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AdditionalFacility", "UpdatedDate", c => c.DateTime());
            AddColumn("dbo.AdditionalFacility", "UpdatedBy", c => c.String());
            AddColumn("dbo.Request", "UpdatedDate", c => c.DateTime());
            AddColumn("dbo.Request", "UpdatedBy", c => c.String());
            AddColumn("dbo.POSRequest", "UpdatedDate", c => c.DateTime());
            AddColumn("dbo.POSRequest", "UpdatedBy", c => c.String());
            AddColumn("dbo.FileMaintenance", "UpdatedDate", c => c.DateTime());
            AddColumn("dbo.FileMaintenance", "UpdatedBy", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.FileMaintenance", "UpdatedBy");
            DropColumn("dbo.FileMaintenance", "UpdatedDate");
            DropColumn("dbo.POSRequest", "UpdatedBy");
            DropColumn("dbo.POSRequest", "UpdatedDate");
            DropColumn("dbo.Request", "UpdatedBy");
            DropColumn("dbo.Request", "UpdatedDate");
            DropColumn("dbo.AdditionalFacility", "UpdatedBy");
            DropColumn("dbo.AdditionalFacility", "UpdatedDate");
        }
    }
}
