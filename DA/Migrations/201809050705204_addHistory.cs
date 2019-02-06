namespace DA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addHistory : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.History",
                c => new
                    {
                        HistoryId = c.Int(nullable: false, identity: true),
                        date = c.DateTime(nullable: false),
                        remarks = c.String(),
                        action = c.String(),
                        user = c.String(),
                        groupCode = c.String(),
                    })
                .PrimaryKey(t => t.HistoryId);
            
            AddColumn("dbo.Request", "History_HistoryId", c => c.Int());
            CreateIndex("dbo.Request", "History_HistoryId");
            AddForeignKey("dbo.Request", "History_HistoryId", "dbo.History", "HistoryId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Request", "History_HistoryId", "dbo.History");
            DropIndex("dbo.Request", new[] { "History_HistoryId" });
            DropColumn("dbo.Request", "History_HistoryId");
            DropTable("dbo.History");
        }
    }
}
