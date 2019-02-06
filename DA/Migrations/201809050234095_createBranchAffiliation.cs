namespace DA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createBranchAffiliation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BranchAffiliation",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        WithRequirements = c.Boolean(nullable: false),
                        WithException = c.Boolean(nullable: false),
                        eMail = c.String(),
                        Business_Id = c.Int(),
                        Customer_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Business", t => t.Business_Id)
                .ForeignKey("dbo.Customer", t => t.Customer_Id)
                .ForeignKey("dbo.Request", t => t.Id)
                .Index(t => t.Id)
                .Index(t => t.Business_Id)
                .Index(t => t.Customer_Id);
            
            AddColumn("dbo.Branch", "BranchAffiliation_Id", c => c.Int());
            CreateIndex("dbo.Branch", "BranchAffiliation_Id");
            AddForeignKey("dbo.Branch", "BranchAffiliation_Id", "dbo.BranchAffiliation", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BranchAffiliation", "Id", "dbo.Request");
            DropForeignKey("dbo.BranchAffiliation", "Customer_Id", "dbo.Customer");
            DropForeignKey("dbo.BranchAffiliation", "Business_Id", "dbo.Business");
            DropForeignKey("dbo.Branch", "BranchAffiliation_Id", "dbo.BranchAffiliation");
            DropIndex("dbo.Branch", new[] { "BranchAffiliation_Id" });
            DropIndex("dbo.BranchAffiliation", new[] { "Customer_Id" });
            DropIndex("dbo.BranchAffiliation", new[] { "Business_Id" });
            DropIndex("dbo.BranchAffiliation", new[] { "Id" });
            DropColumn("dbo.Branch", "BranchAffiliation_Id");
            DropTable("dbo.BranchAffiliation");
        }
    }
}
