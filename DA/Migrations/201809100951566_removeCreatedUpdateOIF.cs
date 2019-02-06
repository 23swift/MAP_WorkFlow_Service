namespace DA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removeCreatedUpdateOIF : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.OcularInspectionForm", "updatedBy");
            DropColumn("dbo.OcularInspectionForm", "updatedDate");
            DropColumn("dbo.OcularInspectionForm", "createdBy");
            DropColumn("dbo.OcularInspectionForm", "createdDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.OcularInspectionForm", "createdDate", c => c.DateTime());
            AddColumn("dbo.OcularInspectionForm", "createdBy", c => c.String());
            AddColumn("dbo.OcularInspectionForm", "updatedDate", c => c.DateTime());
            AddColumn("dbo.OcularInspectionForm", "updatedBy", c => c.String());
        }
    }
}
