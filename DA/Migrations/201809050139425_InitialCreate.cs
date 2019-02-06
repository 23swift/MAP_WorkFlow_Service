namespace DA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ApprovalSetup",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ApprovalCount = c.Int(nullable: false),
                        Rank = c.String(),
                        WithRequirements = c.Boolean(nullable: false),
                        WithException = c.Boolean(nullable: false),
                        RequestType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Branch",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        dbaAddress1 = c.String(),
                        dbaAddress2 = c.String(),
                        dbaAddress3 = c.String(),
                        City_Id = c.Int(nullable: false),
                        DBAName = c.String(),
                        areaMallCode = c.Int(),
                        payDelayDays = c.Int(),
                        dateClosed = c.DateTime(),
                        closedreason = c.Int(),
                        owningMerchant = c.String(),
                        JCBAcceptorId = c.String(),
                        JCBSchemeClosereason = c.Int(),
                        JCBSchemeRevisionReason = c.Int(),
                        JCBRevisionRSN = c.Int(),
                        schemeAreaCode1 = c.Int(),
                        schemeAreaCode2 = c.Int(),
                        AMEXCardAcceptorId = c.String(),
                        AMEXActivationReason = c.Int(),
                        AMEXCanceledReason = c.Int(),
                        AMEXRoleCode = c.Int(),
                        AMEXRiskIND = c.String(),
                        AMEXKeyAcctIND = c.String(),
                        CUPCardAcceptorId = c.String(),
                        CUPTaxCode = c.Int(),
                        CUPTaxNumber = c.String(),
                        CUPTaxExemptExpiryDate = c.DateTime(),
                        imprinterPlateName = c.String(),
                        imprinterPlateNumbers = c.String(),
                        imprinterAMEX = c.String(),
                        imprinterDC = c.String(),
                        imprinterJCB = c.String(),
                        imprinterOthers = c.String(),
                        principalName1 = c.String(),
                        principalName2 = c.String(),
                        principalName3 = c.String(),
                        principalName4 = c.String(),
                        principalName5 = c.String(),
                        adminContactperson = c.String(),
                        goodsServices = c.String(),
                        phoneNo = c.String(),
                        mobileNo = c.String(),
                        emailAddress = c.String(),
                        mailingAddress1 = c.String(),
                        withECR = c.Boolean(nullable: false),
                        merchantGrade = c.Int(),
                        serviceProvider = c.String(),
                        website = c.String(),
                        cardHolderData = c.Boolean(nullable: false),
                        cardHolderDataTobeStored = c.String(),
                        MCC_Id = c.Int(nullable: false),
                        branchCode = c.String(),
                        imprinterTotal = c.Int(),
                        dbaZipCode = c.Int(nullable: false),
                        regionCode = c.Int(),
                        checkDeliveryCode = c.Int(),
                        paymentMode = c.String(),
                        settlementAcctNo = c.String(),
                        merchantGroupCode = c.String(),
                        TIN = c.String(),
                        withTax = c.Boolean(nullable: false),
                        cardPlan = c.Int(),
                        isActive = c.Boolean(nullable: false),
                        isAffiliated = c.Boolean(nullable: false),
                        dbaAddress4 = c.String(),
                        principalFirstName = c.String(),
                        principalLastName = c.String(),
                        principalMiddleName = c.String(),
                        mailingAddress2 = c.String(),
                        mailingAddress3 = c.String(),
                        mailingAddress4 = c.String(),
                        mailingCity = c.Int(nullable: false),
                        mailingAddressZipCode = c.Int(nullable: false),
                        dbaCity = c.Int(),
                        taxExemptFrom = c.DateTime(),
                        taxExemptTo = c.DateTime(),
                        taxExemptIssuedBy = c.Int(nullable: false),
                        registeredBusinessNo = c.String(),
                        DTIBusinessRegDate = c.DateTime(),
                        SECRegDate = c.DateTime(),
                        withAcquirer = c.Boolean(nullable: false),
                        acquirerInstitutionName = c.String(),
                        ecrForInstallation = c.Boolean(nullable: false),
                        isSwipingCardWithoutInstalledECR = c.Boolean(nullable: false),
                        isSwipingCardWithInstalledECR = c.Boolean(nullable: false),
                        debitSettlementAcctNo = c.String(),
                        payeesName = c.String(),
                        emailAddressForReport = c.String(),
                        SOARecipients = c.String(),
                        SOAEmailAddress = c.String(),
                        reportDistributionperCompany = c.Boolean(nullable: false),
                        reportPerBranch = c.Boolean(nullable: false),
                        principalFbName = c.String(),
                        principalDateOfBirth = c.DateTime(),
                        principalCivilStatus = c.Int(nullable: false),
                        principalPhoneNo = c.String(),
                        principalPermanentAddress = c.String(),
                        principalCity = c.Int(nullable: false),
                        principalZipCode = c.Int(nullable: false),
                        principalHomeOwnership = c.Int(nullable: false),
                        spouseAddress = c.String(),
                        spouseCity = c.Int(nullable: false),
                        spouseFirstName = c.String(),
                        spouseLastName = c.String(),
                        spouseMiddleName = c.String(),
                        spousePhoneNo = c.String(),
                        spouseZipCode = c.Int(nullable: false),
                        financialInstitution = c.String(),
                        accountFacility = c.String(),
                        acctLoanNo = c.String(),
                        loanTerm = c.String(),
                        noOfPos = c.Int(nullable: false),
                        discountDebitRate = c.Decimal(nullable: false, precision: 18, scale: 2),
                        storeId = c.String(),
                        reportPerCompanysBranch = c.String(),
                        ftpDir = c.String(),
                        genPayment = c.Boolean(nullable: false),
                        computeCWT = c.Boolean(nullable: false),
                        settlementPerBranch = c.Boolean(nullable: false),
                        customerNo = c.String(),
                        amexRating = c.Int(nullable: false),
                        bdoPayRating = c.Int(nullable: false),
                        bdoPaySegment = c.Int(nullable: false),
                        aoCode = c.String(),
                        feeAccount = c.String(),
                        forMoto = c.String(),
                        strategicMerchant = c.Int(nullable: false),
                        tranSource = c.Int(nullable: false),
                        holdOutAcctNo = c.String(),
                        holdOutAmount = c.String(),
                        remarks = c.String(),
                        preparedBy = c.String(),
                        preparedDate = c.DateTime(),
                        notedBy = c.String(),
                        notedDate = c.String(),
                        controlNo = c.String(),
                        smsSending = c.Boolean(nullable: false),
                        withDependency = c.Boolean(nullable: false),
                        custr = c.Boolean(nullable: false),
                        postMaintReview = c.Boolean(nullable: false),
                        postMaintReviewDate = c.DateTime(),
                        currentDate = c.DateTime(),
                        midCount = c.String(),
                        midDateTimeCreated = c.DateTime(),
                        tidCount = c.String(),
                        tidDateTimeCreated = c.DateTime(),
                        mdf = c.String(),
                        mdfChecker = c.String(),
                        mdfDateTimeChecked = c.DateTime(),
                        mdfMaker = c.String(),
                        mcId = c.Int(nullable: false),
                        debitMailingAddressCity = c.Int(nullable: false),
                        debitMailingAddressZipCode = c.Int(nullable: false),
                        sendBdo030114 = c.Int(nullable: false),
                        branch = c.String(),
                        tradeCustomerName = c.String(),
                        tradeContactNo = c.String(),
                        debitMerchantNo = c.String(),
                        isSingleProp = c.Boolean(nullable: false),
                        isPartnershipCorp = c.Boolean(nullable: false),
                        mdfDateTimeCreated = c.DateTime(),
                        legalName = c.String(),
                        Business_Id = c.Int(),
                        NewAffiliation_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Business", t => t.Business_Id)
                .ForeignKey("dbo.NewAffiliation", t => t.NewAffiliation_Id)
                .Index(t => t.Business_Id)
                .Index(t => t.NewAffiliation_Id);
            
            CreateTable(
                "dbo.Business",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Group_Id = c.Int(nullable: false),
                        SubGroup_Id = c.Int(nullable: false),
                        LegalName = c.String(),
                        Ownership_Id = c.Int(nullable: false),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Customer",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LegalName = c.String(),
                        DtiSecDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MAEF",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        affiliation = c.Int(),
                        tangent = c.String(),
                        requestType = c.Int(),
                        simulInstallment = c.Boolean(),
                        simulDebit = c.Boolean(),
                        currency = c.String(),
                        creditMidCount = c.Int(),
                        debitTidCount = c.Int(),
                        pepList = c.String(),
                        pepListRemarks = c.String(),
                        isDeclined = c.Boolean(),
                        declinedRemarks = c.String(),
                        location = c.Int(),
                        appearance = c.String(),
                        withTelephone = c.Boolean(),
                        isLargeAccount = c.Boolean(),
                        natureOfBusiness = c.String(),
                        mccCorrect = c.Boolean(),
                        personalAccountNo = c.String(),
                        isBdoAccountNo = c.String(),
                        psv = c.String(),
                        isSignatureVerified = c.Boolean(),
                        withRequirementsReview = c.Boolean(),
                        withException = c.Boolean(),
                        midCap = c.String(),
                        payDelay = c.String(),
                        holdoutAmt = c.String(),
                        processedBy = c.String(),
                        approvedBy = c.String(),
                        Request_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Request", t => t.Request_Id)
                .Index(t => t.Request_Id);
            
            CreateTable(
                "dbo.Request",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RequestType = c.Int(nullable: false),
                        RequestDescription = c.String(),
                        Status = c.Int(nullable: false),
                        WorkflowInstanceId = c.Guid(nullable: false),
                        BookMark = c.String(),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RequestApproval",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Approver = c.String(),
                        Date = c.DateTime(),
                        Approved = c.Boolean(nullable: false),
                        Rank = c.String(),
                        Request_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Request", t => t.Request_Id)
                .Index(t => t.Request_Id);
            
            CreateTable(
                "dbo.FileMaintenance",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(),
                        LegalEntity_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.LegalEntity", t => t.LegalEntity_Id)
                .ForeignKey("dbo.Request", t => t.Id)
                .Index(t => t.Id)
                .Index(t => t.LegalEntity_Id);
            
            CreateTable(
                "dbo.LegalEntity",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Business_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Business", t => t.Business_Id)
                .Index(t => t.Business_Id);
            
            CreateTable(
                "dbo.NewAffiliation",
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
            
            CreateTable(
                "dbo.POSRequest",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        RequestDescription = c.String(),
                        Status = c.Int(nullable: false),
                        WorkflowInstanceId = c.Guid(nullable: false),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Request", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.RequiredApproval",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Rank = c.String(),
                        User = c.String(),
                        isApproved = c.Boolean(nullable: false),
                        Request_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Request", t => t.Request_Id)
                .Index(t => t.Request_Id);
            
            CreateTable(
                "dbo.MaintenanceMaster",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MaintenanceDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Value = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        isDeleted = c.Boolean(nullable: false),
                        Code = c.String(),
                        SubCategoryId = c.Int(nullable: false),
                        MaintenanceMaster_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MaintenanceMaster", t => t.MaintenanceMaster_Id)
                .Index(t => t.MaintenanceMaster_Id);
            
            CreateTable(
                "dbo.MerchantGroupView",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OwnershipTypeView",
                c => new
                    {
                        OwnershipType_Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        description = c.String(),
                    })
                .PrimaryKey(t => t.OwnershipType_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MaintenanceDetails", "MaintenanceMaster_Id", "dbo.MaintenanceMaster");
            DropForeignKey("dbo.MAEF", "Request_Id", "dbo.Request");
            DropForeignKey("dbo.RequiredApproval", "Request_Id", "dbo.Request");
            DropForeignKey("dbo.POSRequest", "Id", "dbo.Request");
            DropForeignKey("dbo.NewAffiliation", "Id", "dbo.Request");
            DropForeignKey("dbo.NewAffiliation", "Customer_Id", "dbo.Customer");
            DropForeignKey("dbo.NewAffiliation", "Business_Id", "dbo.Business");
            DropForeignKey("dbo.Branch", "NewAffiliation_Id", "dbo.NewAffiliation");
            DropForeignKey("dbo.FileMaintenance", "Id", "dbo.Request");
            DropForeignKey("dbo.FileMaintenance", "LegalEntity_Id", "dbo.LegalEntity");
            DropForeignKey("dbo.LegalEntity", "Business_Id", "dbo.Business");
            DropForeignKey("dbo.RequestApproval", "Request_Id", "dbo.Request");
            DropForeignKey("dbo.Branch", "Business_Id", "dbo.Business");
            DropIndex("dbo.MaintenanceDetails", new[] { "MaintenanceMaster_Id" });
            DropIndex("dbo.RequiredApproval", new[] { "Request_Id" });
            DropIndex("dbo.POSRequest", new[] { "Id" });
            DropIndex("dbo.NewAffiliation", new[] { "Customer_Id" });
            DropIndex("dbo.NewAffiliation", new[] { "Business_Id" });
            DropIndex("dbo.NewAffiliation", new[] { "Id" });
            DropIndex("dbo.LegalEntity", new[] { "Business_Id" });
            DropIndex("dbo.FileMaintenance", new[] { "LegalEntity_Id" });
            DropIndex("dbo.FileMaintenance", new[] { "Id" });
            DropIndex("dbo.RequestApproval", new[] { "Request_Id" });
            DropIndex("dbo.MAEF", new[] { "Request_Id" });
            DropIndex("dbo.Branch", new[] { "NewAffiliation_Id" });
            DropIndex("dbo.Branch", new[] { "Business_Id" });
            DropTable("dbo.OwnershipTypeView");
            DropTable("dbo.MerchantGroupView");
            DropTable("dbo.MaintenanceDetails");
            DropTable("dbo.MaintenanceMaster");
            DropTable("dbo.RequiredApproval");
            DropTable("dbo.POSRequest");
            DropTable("dbo.NewAffiliation");
            DropTable("dbo.LegalEntity");
            DropTable("dbo.FileMaintenance");
            DropTable("dbo.RequestApproval");
            DropTable("dbo.Request");
            DropTable("dbo.MAEF");
            DropTable("dbo.Customer");
            DropTable("dbo.Business");
            DropTable("dbo.Branch");
            DropTable("dbo.ApprovalSetup");
        }
    }
}
