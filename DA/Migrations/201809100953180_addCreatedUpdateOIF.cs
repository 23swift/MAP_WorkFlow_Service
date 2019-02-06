namespace DA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addCreatedUpdateOIF : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.OcularInspectionForm", "CreatedDate", c => c.DateTime());
            AddColumn("dbo.OcularInspectionForm", "CreatedBy", c => c.String());
            AddColumn("dbo.OcularInspectionForm", "UpdatedDate", c => c.DateTime());
            AddColumn("dbo.OcularInspectionForm", "UpdatedBy", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.OcularInspectionForm", "UpdatedBy");
            DropColumn("dbo.OcularInspectionForm", "UpdatedDate");
            DropColumn("dbo.OcularInspectionForm", "CreatedBy");
            DropColumn("dbo.OcularInspectionForm", "CreatedDate");
        }
    }
}
