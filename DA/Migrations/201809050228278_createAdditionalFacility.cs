namespace DA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createAdditionalFacility : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AdditionalFacility",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        RequestDesc = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Request", t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AdditionalFacility", "Id", "dbo.Request");
            DropIndex("dbo.AdditionalFacility", new[] { "Id" });
            DropTable("dbo.AdditionalFacility");
        }
    }
}
