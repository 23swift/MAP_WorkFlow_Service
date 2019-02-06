namespace DA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateVariousObjects : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DocumentList",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DocumentList");
        }
    }
}
