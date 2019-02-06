namespace DA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class variousChanges09102018 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DocumentList", "CreatedDate", c => c.DateTime());
            AddColumn("dbo.DocumentList", "CreatedBy", c => c.String());
            AddColumn("dbo.DocumentList", "UpdatedDate", c => c.DateTime());
            AddColumn("dbo.DocumentList", "UpdatedBy", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.DocumentList", "UpdatedBy");
            DropColumn("dbo.DocumentList", "UpdatedDate");
            DropColumn("dbo.DocumentList", "CreatedBy");
            DropColumn("dbo.DocumentList", "CreatedDate");
        }
    }
}
