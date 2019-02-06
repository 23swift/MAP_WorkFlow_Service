namespace DA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addTrackingNoToRequest : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Request", "TrackingNo", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Request", "TrackingNo");
        }
    }
}
