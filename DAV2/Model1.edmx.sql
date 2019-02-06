
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 07/11/2018 18:13:31
-- Generated from EDMX file: D:\TFS_MAS_WorkFlowService\MerchantAquiringSystemWithWF\DAV2\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [MAP_DB_V2];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_AdditionalFacility_MasterBranches]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AdditionalFacility] DROP CONSTRAINT [FK_AdditionalFacility_MasterBranches];
GO
IF OBJECT_ID(N'[dbo].[FK_AdditionalFacility_Request]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AdditionalFacility] DROP CONSTRAINT [FK_AdditionalFacility_Request];
GO
IF OBJECT_ID(N'[MAP_DB_V2ModelStoreContainer].[FK_AdditionalMID_AdditionalFacility]', 'F') IS NOT NULL
    ALTER TABLE [MAP_DB_V2ModelStoreContainer].[AdditionalMID] DROP CONSTRAINT [FK_AdditionalMID_AdditionalFacility];
GO
IF OBJECT_ID(N'[dbo].[FK_Affiliation_Business]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Affiliation] DROP CONSTRAINT [FK_Affiliation_Business];
GO
IF OBJECT_ID(N'[dbo].[FK_Affiliation_Request]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Affiliation] DROP CONSTRAINT [FK_Affiliation_Request];
GO
IF OBJECT_ID(N'[MAP_DB_V2ModelStoreContainer].[FK_BranchAffiliation_Affiliation]', 'F') IS NOT NULL
    ALTER TABLE [MAP_DB_V2ModelStoreContainer].[BranchAffiliation] DROP CONSTRAINT [FK_BranchAffiliation_Affiliation];
GO
IF OBJECT_ID(N'[MAP_DB_V2ModelStoreContainer].[FK_BranchAffiliation_Branches]', 'F') IS NOT NULL
    ALTER TABLE [MAP_DB_V2ModelStoreContainer].[BranchAffiliation] DROP CONSTRAINT [FK_BranchAffiliation_Branches];
GO
IF OBJECT_ID(N'[dbo].[FK_Branches_Business1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Branches] DROP CONSTRAINT [FK_Branches_Business1];
GO
IF OBJECT_ID(N'[dbo].[FK_DetailsMaintenance_MasterMaintenance]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DetailsMaintenance] DROP CONSTRAINT [FK_DetailsMaintenance_MasterMaintenance];
GO
IF OBJECT_ID(N'[dbo].[FK_FileMaintenance_MasterBusiness]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FileMaintenance] DROP CONSTRAINT [FK_FileMaintenance_MasterBusiness];
GO
IF OBJECT_ID(N'[dbo].[FK_MaintenanceFields_FileMaintenance]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MaintenanceFields] DROP CONSTRAINT [FK_MaintenanceFields_FileMaintenance];
GO
IF OBJECT_ID(N'[dbo].[FK_MaintenanceMID_FileMaintenance]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MaintenanceMID] DROP CONSTRAINT [FK_MaintenanceMID_FileMaintenance];
GO
IF OBJECT_ID(N'[dbo].[FK_MasterBranches_MasterBusiness]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MasterBranches] DROP CONSTRAINT [FK_MasterBranches_MasterBusiness];
GO
IF OBJECT_ID(N'[dbo].[FK_MasterMID_MasterBranches]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MasterMID] DROP CONSTRAINT [FK_MasterMID_MasterBranches];
GO
IF OBJECT_ID(N'[dbo].[FK_MasterTID_MasterBranches]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MasterTID] DROP CONSTRAINT [FK_MasterTID_MasterBranches];
GO
IF OBJECT_ID(N'[dbo].[FK_MID_Branches1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MID] DROP CONSTRAINT [FK_MID_Branches1];
GO
IF OBJECT_ID(N'[dbo].[FK_POS_Request]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[POS] DROP CONSTRAINT [FK_POS_Request];
GO
IF OBJECT_ID(N'[dbo].[FK_TID_Branches]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TID] DROP CONSTRAINT [FK_TID_Branches];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[AdditionalFacility]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AdditionalFacility];
GO
IF OBJECT_ID(N'[dbo].[Affiliation]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Affiliation];
GO
IF OBJECT_ID(N'[dbo].[Branches]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Branches];
GO
IF OBJECT_ID(N'[dbo].[Business]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Business];
GO
IF OBJECT_ID(N'[dbo].[DetailsMaintenance]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DetailsMaintenance];
GO
IF OBJECT_ID(N'[dbo].[FileMaintenance]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FileMaintenance];
GO
IF OBJECT_ID(N'[dbo].[MaintenanceFields]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MaintenanceFields];
GO
IF OBJECT_ID(N'[dbo].[MaintenanceMID]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MaintenanceMID];
GO
IF OBJECT_ID(N'[dbo].[MasterBranches]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MasterBranches];
GO
IF OBJECT_ID(N'[dbo].[MasterBusiness]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MasterBusiness];
GO
IF OBJECT_ID(N'[dbo].[MasterMaintenance]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MasterMaintenance];
GO
IF OBJECT_ID(N'[dbo].[MasterMID]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MasterMID];
GO
IF OBJECT_ID(N'[dbo].[MasterTID]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MasterTID];
GO
IF OBJECT_ID(N'[dbo].[MID]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MID];
GO
IF OBJECT_ID(N'[dbo].[POS]', 'U') IS NOT NULL
    DROP TABLE [dbo].[POS];
GO
IF OBJECT_ID(N'[dbo].[Request]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Request];
GO
IF OBJECT_ID(N'[dbo].[TID]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TID];
GO
IF OBJECT_ID(N'[MAP_DB_V2ModelStoreContainer].[AdditionalMID]', 'U') IS NOT NULL
    DROP TABLE [MAP_DB_V2ModelStoreContainer].[AdditionalMID];
GO
IF OBJECT_ID(N'[MAP_DB_V2ModelStoreContainer].[BranchAffiliation]', 'U') IS NOT NULL
    DROP TABLE [MAP_DB_V2ModelStoreContainer].[BranchAffiliation];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'AdditionalFacility'
CREATE TABLE [dbo].[AdditionalFacility] (
    [Id] int  NOT NULL,
    [Branch_Id] int  NULL
);
GO

-- Creating table 'Affiliation'
CREATE TABLE [dbo].[Affiliation] (
    [Id] int  NOT NULL,
    [Business_Id] int  NULL
);
GO

-- Creating table 'Branches'
CREATE TABLE [dbo].[Branches] (
    [Id] int  NOT NULL,
    [Business_Id] int  NULL,
    [AddFacility_Id] int  NULL,
    [Code] uniqueidentifier  NULL,
    [BranchCode] nchar(10)  NULL
);
GO

-- Creating table 'Business'
CREATE TABLE [dbo].[Business] (
    [Id] int  NOT NULL,
    [LegalName] nvarchar(50)  NULL,
    [Ownership_Id] int  NULL,
    [DTIRegDate] datetime  NULL,
    [Code] uniqueidentifier  NULL
);
GO

-- Creating table 'FileMaintenance'
CREATE TABLE [dbo].[FileMaintenance] (
    [Id] int  NOT NULL,
    [Business_Id] int  NULL
);
GO

-- Creating table 'MaintenanceMID'
CREATE TABLE [dbo].[MaintenanceMID] (
    [Id] int  NOT NULL,
    [MonitorCode_Id] int  NULL,
    [CardPlans_Id] int  NULL,
    [CurrencyId] int  NULL,
    [MaintenanceMID1] nvarchar(50)  NULL,
    [MaintenanceMID11] nvarchar(50)  NULL,
    [MaintenanceMID12] nvarchar(50)  NULL,
    [MaintenanceMID13] nvarchar(50)  NULL
);
GO

-- Creating table 'MasterBranches'
CREATE TABLE [dbo].[MasterBranches] (
    [Id] int  NOT NULL,
    [Business_Id] int  NULL,
    [AddFacility_Id] int  NULL,
    [Code] uniqueidentifier  NULL
);
GO

-- Creating table 'MasterBusiness'
CREATE TABLE [dbo].[MasterBusiness] (
    [Id] int  NOT NULL,
    [LegalName] nvarchar(50)  NULL,
    [Code] uniqueidentifier  NULL
);
GO

-- Creating table 'MasterMaintenance'
CREATE TABLE [dbo].[MasterMaintenance] (
    [Id] bigint  NOT NULL,
    [Code] nchar(10)  NULL,
    [Description] nvarchar(50)  NULL
);
GO

-- Creating table 'MasterMID'
CREATE TABLE [dbo].[MasterMID] (
    [Id] bigint  NOT NULL,
    [MonitorCode_Id] int  NULL,
    [CardPlans_Id] int  NULL,
    [MID] nvarchar(50)  NULL,
    [Branch_Id] int  NULL
);
GO

-- Creating table 'MasterTID'
CREATE TABLE [dbo].[MasterTID] (
    [Id] int  NOT NULL,
    [Branch_Id] int  NULL,
    [TID] nvarchar(50)  NULL
);
GO

-- Creating table 'MID'
CREATE TABLE [dbo].[MID] (
    [Id] bigint  NOT NULL,
    [MonitorCode_Id] int  NULL,
    [CardPlans_Id] int  NULL,
    [MID1] nvarchar(50)  NULL,
    [Branch_Id] int  NULL,
    [MID11] nvarchar(50)  NULL,
    [MID12] nvarchar(50)  NULL,
    [MID13] nvarchar(50)  NULL
);
GO

-- Creating table 'POS'
CREATE TABLE [dbo].[POS] (
    [Id] int  NOT NULL,
    [Branch_Id] int  NOT NULL,
    [Code] uniqueidentifier  NULL
);
GO

-- Creating table 'Request'
CREATE TABLE [dbo].[Request] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [RequestType] int  NOT NULL,
    [Status] int  NOT NULL,
    [DateCreated] datetime  NULL,
    [Createdby] nvarchar(50)  NULL
);
GO

-- Creating table 'TID'
CREATE TABLE [dbo].[TID] (
    [Id] int  NOT NULL,
    [Branch_Id] int  NULL,
    [TID1] nvarchar(50)  NULL,
    [TID11] nvarchar(50)  NULL,
    [TID12] nvarchar(50)  NULL,
    [TID13] nvarchar(50)  NULL
);
GO

-- Creating table 'AdditionalMID'
CREATE TABLE [dbo].[AdditionalMID] (
    [Id] int  NOT NULL,
    [MonitorCode_Id] int  NULL,
    [CardPlans_Id] int  NULL,
    [CurrencyId] int  NULL,
    [AdditionalMID1] nvarchar(50)  NULL,
    [AdditionalMID11] nvarchar(50)  NULL,
    [AdditionalMID12] nvarchar(50)  NULL,
    [AdditionalMID13] nvarchar(50)  NULL
);
GO

-- Creating table 'BranchAffiliation'
CREATE TABLE [dbo].[BranchAffiliation] (
    [Id] int  NOT NULL,
    [Branch_Id] int  NULL
);
GO

-- Creating table 'DetailsMaintenance'
CREATE TABLE [dbo].[DetailsMaintenance] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Masted_Id] bigint  NULL,
    [Code] nchar(10)  NULL,
    [Description] nvarchar(50)  NULL
);
GO

-- Creating table 'MaintenanceFields'
CREATE TABLE [dbo].[MaintenanceFields] (
    [Id] int  NOT NULL,
    [DBA_TradeName] nvarchar(50)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'AdditionalFacility'
ALTER TABLE [dbo].[AdditionalFacility]
ADD CONSTRAINT [PK_AdditionalFacility]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Affiliation'
ALTER TABLE [dbo].[Affiliation]
ADD CONSTRAINT [PK_Affiliation]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Branches'
ALTER TABLE [dbo].[Branches]
ADD CONSTRAINT [PK_Branches]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Business'
ALTER TABLE [dbo].[Business]
ADD CONSTRAINT [PK_Business]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'FileMaintenance'
ALTER TABLE [dbo].[FileMaintenance]
ADD CONSTRAINT [PK_FileMaintenance]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MaintenanceMID'
ALTER TABLE [dbo].[MaintenanceMID]
ADD CONSTRAINT [PK_MaintenanceMID]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MasterBranches'
ALTER TABLE [dbo].[MasterBranches]
ADD CONSTRAINT [PK_MasterBranches]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MasterBusiness'
ALTER TABLE [dbo].[MasterBusiness]
ADD CONSTRAINT [PK_MasterBusiness]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MasterMaintenance'
ALTER TABLE [dbo].[MasterMaintenance]
ADD CONSTRAINT [PK_MasterMaintenance]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MasterMID'
ALTER TABLE [dbo].[MasterMID]
ADD CONSTRAINT [PK_MasterMID]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MasterTID'
ALTER TABLE [dbo].[MasterTID]
ADD CONSTRAINT [PK_MasterTID]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MID'
ALTER TABLE [dbo].[MID]
ADD CONSTRAINT [PK_MID]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'POS'
ALTER TABLE [dbo].[POS]
ADD CONSTRAINT [PK_POS]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Request'
ALTER TABLE [dbo].[Request]
ADD CONSTRAINT [PK_Request]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TID'
ALTER TABLE [dbo].[TID]
ADD CONSTRAINT [PK_TID]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'AdditionalMID'
ALTER TABLE [dbo].[AdditionalMID]
ADD CONSTRAINT [PK_AdditionalMID]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'BranchAffiliation'
ALTER TABLE [dbo].[BranchAffiliation]
ADD CONSTRAINT [PK_BranchAffiliation]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'DetailsMaintenance'
ALTER TABLE [dbo].[DetailsMaintenance]
ADD CONSTRAINT [PK_DetailsMaintenance]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MaintenanceFields'
ALTER TABLE [dbo].[MaintenanceFields]
ADD CONSTRAINT [PK_MaintenanceFields]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Branch_Id] in table 'AdditionalFacility'
ALTER TABLE [dbo].[AdditionalFacility]
ADD CONSTRAINT [FK_AdditionalFacility_MasterBranches]
    FOREIGN KEY ([Branch_Id])
    REFERENCES [dbo].[MasterBranches]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AdditionalFacility_MasterBranches'
CREATE INDEX [IX_FK_AdditionalFacility_MasterBranches]
ON [dbo].[AdditionalFacility]
    ([Branch_Id]);
GO

-- Creating foreign key on [Id] in table 'AdditionalFacility'
ALTER TABLE [dbo].[AdditionalFacility]
ADD CONSTRAINT [FK_AdditionalFacility_Request]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Request]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'AdditionalMID'
ALTER TABLE [dbo].[AdditionalMID]
ADD CONSTRAINT [FK_AdditionalMID_AdditionalFacility]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[AdditionalFacility]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Business_Id] in table 'Affiliation'
ALTER TABLE [dbo].[Affiliation]
ADD CONSTRAINT [FK_Affiliation_Business]
    FOREIGN KEY ([Business_Id])
    REFERENCES [dbo].[Business]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Affiliation_Business'
CREATE INDEX [IX_FK_Affiliation_Business]
ON [dbo].[Affiliation]
    ([Business_Id]);
GO

-- Creating foreign key on [Business_Id] in table 'Affiliation'
ALTER TABLE [dbo].[Affiliation]
ADD CONSTRAINT [FK_Affiliation_MasterBusiness]
    FOREIGN KEY ([Business_Id])
    REFERENCES [dbo].[MasterBusiness]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Affiliation_MasterBusiness'
CREATE INDEX [IX_FK_Affiliation_MasterBusiness]
ON [dbo].[Affiliation]
    ([Business_Id]);
GO

-- Creating foreign key on [Id] in table 'Affiliation'
ALTER TABLE [dbo].[Affiliation]
ADD CONSTRAINT [FK_Affiliation_Request1]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Request]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'BranchAffiliation'
ALTER TABLE [dbo].[BranchAffiliation]
ADD CONSTRAINT [FK_BranchAffiliation_Affiliation]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Affiliation]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Branch_Id] in table 'BranchAffiliation'
ALTER TABLE [dbo].[BranchAffiliation]
ADD CONSTRAINT [FK_BranchAffiliation_Branches]
    FOREIGN KEY ([Branch_Id])
    REFERENCES [dbo].[Branches]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_BranchAffiliation_Branches'
CREATE INDEX [IX_FK_BranchAffiliation_Branches]
ON [dbo].[BranchAffiliation]
    ([Branch_Id]);
GO

-- Creating foreign key on [Business_Id] in table 'Branches'
ALTER TABLE [dbo].[Branches]
ADD CONSTRAINT [FK_Branches_Business1]
    FOREIGN KEY ([Business_Id])
    REFERENCES [dbo].[Business]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Branches_Business1'
CREATE INDEX [IX_FK_Branches_Business1]
ON [dbo].[Branches]
    ([Business_Id]);
GO

-- Creating foreign key on [Branch_Id] in table 'MID'
ALTER TABLE [dbo].[MID]
ADD CONSTRAINT [FK_MID_Branches1]
    FOREIGN KEY ([Branch_Id])
    REFERENCES [dbo].[Branches]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MID_Branches1'
CREATE INDEX [IX_FK_MID_Branches1]
ON [dbo].[MID]
    ([Branch_Id]);
GO

-- Creating foreign key on [Branch_Id] in table 'TID'
ALTER TABLE [dbo].[TID]
ADD CONSTRAINT [FK_TID_Branches]
    FOREIGN KEY ([Branch_Id])
    REFERENCES [dbo].[Branches]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TID_Branches'
CREATE INDEX [IX_FK_TID_Branches]
ON [dbo].[TID]
    ([Branch_Id]);
GO

-- Creating foreign key on [Business_Id] in table 'FileMaintenance'
ALTER TABLE [dbo].[FileMaintenance]
ADD CONSTRAINT [FK_FileMaintenance_MasterBusiness]
    FOREIGN KEY ([Business_Id])
    REFERENCES [dbo].[MasterBusiness]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FileMaintenance_MasterBusiness'
CREATE INDEX [IX_FK_FileMaintenance_MasterBusiness]
ON [dbo].[FileMaintenance]
    ([Business_Id]);
GO

-- Creating foreign key on [Id] in table 'FileMaintenance'
ALTER TABLE [dbo].[FileMaintenance]
ADD CONSTRAINT [FK_FileMaintenance_Request]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Request]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'MaintenanceMID'
ALTER TABLE [dbo].[MaintenanceMID]
ADD CONSTRAINT [FK_MaintenanceMID_FileMaintenance]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[FileMaintenance]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Business_Id] in table 'MasterBranches'
ALTER TABLE [dbo].[MasterBranches]
ADD CONSTRAINT [FK_MasterBranches_MasterBusiness]
    FOREIGN KEY ([Business_Id])
    REFERENCES [dbo].[MasterBusiness]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MasterBranches_MasterBusiness'
CREATE INDEX [IX_FK_MasterBranches_MasterBusiness]
ON [dbo].[MasterBranches]
    ([Business_Id]);
GO

-- Creating foreign key on [Branch_Id] in table 'MasterMID'
ALTER TABLE [dbo].[MasterMID]
ADD CONSTRAINT [FK_MasterMID_MasterBranches]
    FOREIGN KEY ([Branch_Id])
    REFERENCES [dbo].[MasterBranches]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MasterMID_MasterBranches'
CREATE INDEX [IX_FK_MasterMID_MasterBranches]
ON [dbo].[MasterMID]
    ([Branch_Id]);
GO

-- Creating foreign key on [Branch_Id] in table 'MasterTID'
ALTER TABLE [dbo].[MasterTID]
ADD CONSTRAINT [FK_MasterTID_MasterBranches]
    FOREIGN KEY ([Branch_Id])
    REFERENCES [dbo].[MasterBranches]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MasterTID_MasterBranches'
CREATE INDEX [IX_FK_MasterTID_MasterBranches]
ON [dbo].[MasterTID]
    ([Branch_Id]);
GO

-- Creating foreign key on [Id] in table 'POS'
ALTER TABLE [dbo].[POS]
ADD CONSTRAINT [FK_POS_Request]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Request]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Masted_Id] in table 'DetailsMaintenance'
ALTER TABLE [dbo].[DetailsMaintenance]
ADD CONSTRAINT [FK_DetailsMaintenance_MasterMaintenance]
    FOREIGN KEY ([Masted_Id])
    REFERENCES [dbo].[MasterMaintenance]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DetailsMaintenance_MasterMaintenance'
CREATE INDEX [IX_FK_DetailsMaintenance_MasterMaintenance]
ON [dbo].[DetailsMaintenance]
    ([Masted_Id]);
GO

-- Creating foreign key on [Id] in table 'MaintenanceFields'
ALTER TABLE [dbo].[MaintenanceFields]
ADD CONSTRAINT [FK_MaintenanceFields_FileMaintenance]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[FileMaintenance]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------