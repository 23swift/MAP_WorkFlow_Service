namespace DA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addWaivedOIF : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.OcularInspectionForm", "waived", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.OcularInspectionForm", "waived");
        }
    }
}
