namespace DA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removeBusinessFromBranch : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Branch", "Business_Id", "dbo.Business");
            DropForeignKey("dbo.BranchAffiliation", "Business_Id", "dbo.Business");
            DropForeignKey("dbo.LegalEntity", "Business_Id", "dbo.Business");
            DropForeignKey("dbo.NewAffiliation", "Business_Id", "dbo.Business");
            DropIndex("dbo.BranchAffiliation", new[] { "Business_Id" });
            DropIndex("dbo.Branch", new[] { "Business_Id" });
            DropIndex("dbo.LegalEntity", new[] { "Business_Id" });
            DropIndex("dbo.NewAffiliation", new[] { "Business_Id" });
            AddColumn("dbo.LegalEntity", "Customer_Id", c => c.Int());
            CreateIndex("dbo.LegalEntity", "Customer_Id");
            AddForeignKey("dbo.LegalEntity", "Customer_Id", "dbo.Customer", "Id");
            DropColumn("dbo.BranchAffiliation", "Business_Id");
            DropColumn("dbo.Branch", "Business_Id");
            DropColumn("dbo.LegalEntity", "Business_Id");
            DropColumn("dbo.NewAffiliation", "Business_Id");
            DropTable("dbo.Business");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Business",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Group_Id = c.Int(nullable: false),
                        SubGroup_Id = c.Int(nullable: false),
                        LegalName = c.String(),
                        Ownership_Id = c.Int(nullable: false),
                        DTIRegDate = c.DateTime(nullable: false),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.NewAffiliation", "Business_Id", c => c.Int());
            AddColumn("dbo.LegalEntity", "Business_Id", c => c.Int());
            AddColumn("dbo.Branch", "Business_Id", c => c.Int());
            AddColumn("dbo.BranchAffiliation", "Business_Id", c => c.Int());
            DropForeignKey("dbo.LegalEntity", "Customer_Id", "dbo.Customer");
            DropIndex("dbo.LegalEntity", new[] { "Customer_Id" });
            DropColumn("dbo.LegalEntity", "Customer_Id");
            CreateIndex("dbo.NewAffiliation", "Business_Id");
            CreateIndex("dbo.LegalEntity", "Business_Id");
            CreateIndex("dbo.Branch", "Business_Id");
            CreateIndex("dbo.BranchAffiliation", "Business_Id");
            AddForeignKey("dbo.NewAffiliation", "Business_Id", "dbo.Business", "Id");
            AddForeignKey("dbo.LegalEntity", "Business_Id", "dbo.Business", "Id");
            AddForeignKey("dbo.BranchAffiliation", "Business_Id", "dbo.Business", "Id");
            AddForeignKey("dbo.Branch", "Business_Id", "dbo.Business", "Id");
        }
    }
}
