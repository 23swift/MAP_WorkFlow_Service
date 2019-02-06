namespace DA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createOIF : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OcularInspectionForm",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        outletAddress = c.String(),
                        outletContactPerson = c.String(),
                        outletContactPosition = c.String(),
                        outletTelephoneNo = c.String(),
                        outletMobileNo = c.String(),
                        outletTypeOfBusiness = c.Int(),
                        natureOfBusiness = c.String(),
                        noOfYearsOperating = c.String(),
                        businessHours = c.String(),
                        noOfEmployeesFullTime = c.Int(),
                        noOfEmployeesContractual = c.Int(),
                        premiseStatus = c.Int(),
                        lengthOfStay = c.String(),
                        location = c.Int(),
                        businessSignage = c.String(),
                        premiseType = c.Int(),
                        interiorAppearance = c.String(),
                        exteriorAppearance = c.String(),
                        stocks = c.String(),
                        equipment = c.String(),
                        floorArea = c.String(),
                        withHighTraffic = c.Boolean(),
                        establishments = c.String(),
                        motoMarketingChannel = c.String(),
                        averageTransactions = c.Int(),
                        nameOfEvent = c.String(),
                        venue = c.String(),
                        typeOfEvent = c.Int(),
                        expectedNoOfBuyers = c.Int(),
                        products = c.String(),
                        priceRange = c.String(),
                        noOfParticipants = c.Int(),
                        averageRegistration = c.String(),
                        inclusiveDateOfEvent = c.String(),
                        nameOfLastEvent = c.String(),
                        venueOfLastEvent = c.String(),
                        dateOfLastEvent = c.DateTime(),
                        totalSales = c.String(),
                        nameOfLastAcquirer = c.String(),
                        adverseFindings = c.String(),
                        incompleteReport = c.String(),
                        remarks = c.String(),
                        updatedBy = c.String(),
                        updatedDate = c.DateTime(),
                        createdBy = c.String(),
                        createdDate = c.DateTime(),
                        outskirt = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Branch", "OcularInspectionForm_Id", c => c.Int());
            AddColumn("dbo.Branch", "POSRequest_Id", c => c.Int());
            CreateIndex("dbo.Branch", "OcularInspectionForm_Id");
            CreateIndex("dbo.Branch", "POSRequest_Id");
            AddForeignKey("dbo.Branch", "OcularInspectionForm_Id", "dbo.OcularInspectionForm", "Id");
            AddForeignKey("dbo.Branch", "POSRequest_Id", "dbo.POSRequest", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Branch", "POSRequest_Id", "dbo.POSRequest");
            DropForeignKey("dbo.Branch", "OcularInspectionForm_Id", "dbo.OcularInspectionForm");
            DropIndex("dbo.Branch", new[] { "POSRequest_Id" });
            DropIndex("dbo.Branch", new[] { "OcularInspectionForm_Id" });
            DropColumn("dbo.Branch", "POSRequest_Id");
            DropColumn("dbo.Branch", "OcularInspectionForm_Id");
            DropTable("dbo.OcularInspectionForm");
        }
    }
}
