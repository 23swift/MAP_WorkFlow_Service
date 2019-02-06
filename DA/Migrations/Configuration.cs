namespace DA.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DA.MAS_DB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            SetSqlGenerator("System.Data.SqlClient",
            new CustomSqlServerMigrationSqlViewGenerator());
        }

        protected override void Seed(DA.MAS_DB context)
        {
            IList<DA.Models.MaintenanceDetails> MaintenanceDetailsToClear = context.MaintenanceDetails.ToList();
            if (MaintenanceDetailsToClear != null)
            {

                context.MaintenanceDetails.RemoveRange(MaintenanceDetailsToClear);
                context.SaveChanges();

                //"DBCC CHECKIDENT(tblPerson, RESEED, 0)"
                // context.Database.ExecuteSqlCommand("DBCC CHECKIDENT(MaintenanceMaster, RESEED, 0)");
                context.Database.ExecuteSqlCommand("DBCC CHECKIDENT(MaintenanceDetails, RESEED, 0)");

            }
            IList<DA.Models.MaintenanceMaster> MaintenanceMasterToClear = context.MaintenanceMaster.ToList();
            if (MaintenanceMasterToClear != null)
            {

                context.MaintenanceMaster.RemoveRange(MaintenanceMasterToClear);
                context.SaveChanges();

                //"DBCC CHECKIDENT(tblPerson, RESEED, 0)"
                context.Database.ExecuteSqlCommand("DBCC CHECKIDENT(MaintenanceMaster, RESEED, 0)");
                //context.Database.ExecuteSqlCommand("DBCC CHECKIDENT(MaintenanceDetails, RESEED, 0)");

            }

            IList<DA.Models.MaintenanceMaster> MaintenanceMaster = new List<DA.Models.MaintenanceMaster>();
            MaintenanceMaster.Add(new DA.Models.MaintenanceMaster { Code = "CU", Description = "CURRENCY CODE" });
            MaintenanceMaster.Add(new DA.Models.MaintenanceMaster { Code = "MC", Description = "MONITOR CODE" });
            MaintenanceMaster.Add(new DA.Models.MaintenanceMaster { Code = "SU", Description = "SUB MONITOR CODE" });
            MaintenanceMaster.Add(new DA.Models.MaintenanceMaster { Code = "MID", Description = "MID Type" });
            MaintenanceMaster.Add(new DA.Models.MaintenanceMaster { Code = "OW", Description = "BUSINESS OWNERSHIP" });
            MaintenanceMaster.Add(new DA.Models.MaintenanceMaster { Code = "CY", Description = "CITY" });
            //Added By: Kin A. Quiambao 06/01/2017
            MaintenanceMaster.Add(new DA.Models.MaintenanceMaster { Code = "REO", Description = "REQUIREMENT EXCEPTION OPTION" });
            //Added By: Kin A. Quiambao 06/01/2017
            MaintenanceMaster.Add(new DA.Models.MaintenanceMaster { Code = "AOC", Description = "AO CODE" });
            MaintenanceMaster.Add(new DA.Models.MaintenanceMaster { Code = "CS", Description = "CIVIL STATUS" });
            MaintenanceMaster.Add(new DA.Models.MaintenanceMaster { Code = "ZC", Description = "ZIP CODE" });
            MaintenanceMaster.Add(new DA.Models.MaintenanceMaster { Code = "RO", Description = "RESIDENCE OWNERSHIP" });
            MaintenanceMaster.Add(new DA.Models.MaintenanceMaster { Code = "SZC", Description = "SPOUSE ZIP CODE" });
            MaintenanceMaster.Add(new DA.Models.MaintenanceMaster { Code = "NR", Description = "NATURE OF REQUEST" });
            MaintenanceMaster.Add(new DA.Models.MaintenanceMaster { Code = "AR", Description = "AREA" });
            MaintenanceMaster.Add(new DA.Models.MaintenanceMaster { Code = "TA", Description = "TYPE OF ACCOUNT" });
            MaintenanceMaster.Add(new DA.Models.MaintenanceMaster { Code = "TBTM", Description = "TERMINAL BRAND TYPE MODEL" });
            MaintenanceMaster.Add(new DA.Models.MaintenanceMaster { Code = "RTSP", Description = "REASON FOR THREE SLIP PRINTING" });
            MaintenanceMaster.Add(new DA.Models.MaintenanceMaster { Code = "PS", Description = "PREMISE STATUS" });
            MaintenanceMaster.Add(new DA.Models.MaintenanceMaster { Code = "TP", Description = "TYPE OF PREMISE" });
            MaintenanceMaster.Add(new DA.Models.MaintenanceMaster { Code = "LOC", Description = "LOCATION" });
            MaintenanceMaster.Add(new DA.Models.MaintenanceMaster { Code = "IA", Description = "INTERIOR APPEARANCE" });
            MaintenanceMaster.Add(new DA.Models.MaintenanceMaster { Code = "EA", Description = "EXTERIOR APPEARANCE" });
            MaintenanceMaster.Add(new DA.Models.MaintenanceMaster { Code = "SI", Description = "STOCKS INVENTORY" });
            MaintenanceMaster.Add(new DA.Models.MaintenanceMaster { Code = "EQ", Description = "EQUIPMENT" });
            MaintenanceMaster.Add(new DA.Models.MaintenanceMaster { Code = "TE", Description = "TYPE OF EVENT" });
            MaintenanceMaster.Add(new DA.Models.MaintenanceMaster { Code = "OR", Description = "OVERALL RATING" });
            MaintenanceMaster.Add(new DA.Models.MaintenanceMaster { Code = "CP", Description = "CARD PLANS" });
            MaintenanceMaster.Add(new DA.Models.MaintenanceMaster { Code = "CC", Description = "CLASS CODE" });
            MaintenanceMaster.Add(new DA.Models.MaintenanceMaster { Code = "SSH", Description = "SALES SLIP HANDLING" });
            MaintenanceMaster.Add(new DA.Models.MaintenanceMaster { Code = "JRR", Description = "JCB REVISION RSN" });
            MaintenanceMaster.Add(new DA.Models.MaintenanceMaster { Code = "ARC", Description = "AMEX ROLE CODE" });
            MaintenanceMaster.Add(new DA.Models.MaintenanceMaster { Code = "JSCR", Description = "JCB SCHEME CLOSE REASON" });
            MaintenanceMaster.Add(new DA.Models.MaintenanceMaster { Code = "SAC1", Description = "SCHEME AREA CODE 1" });
            MaintenanceMaster.Add(new DA.Models.MaintenanceMaster { Code = "SAC2", Description = "SCHEME AREA CODE 2" });
            MaintenanceMaster.Add(new DA.Models.MaintenanceMaster { Code = "AAR", Description = "AMEX ACTIVATION REASON" });
            MaintenanceMaster.Add(new DA.Models.MaintenanceMaster { Code = "JSRR", Description = "JCB SCHEME REVISION REASON" });
            MaintenanceMaster.Add(new DA.Models.MaintenanceMaster { Code = "ACR", Description = "AMEX CANCELED REASON" });
            MaintenanceMaster.Add(new DA.Models.MaintenanceMaster { Code = "PD", Description = "PAY DELAY" });
            MaintenanceMaster.Add(new DA.Models.MaintenanceMaster { Code = "CTC", Description = "CUP TAX CODE" });
            MaintenanceMaster.Add(new DA.Models.MaintenanceMaster { Code = "MGC", Description = "MERCHANT GROUP CODE" });
            MaintenanceMaster.Add(new DA.Models.MaintenanceMaster { Code = "RT", Description = "REQUEST TYPE" });
            MaintenanceMaster.Add(new DA.Models.MaintenanceMaster { Code = "RSV", Description = "REQUEST STATUS" });
            MaintenanceMaster.Add(new DA.Models.MaintenanceMaster { Code = "CCH", Description = "CREDIT CHECKING" });
            MaintenanceMaster.Add(new DA.Models.MaintenanceMaster { Code = "BUM", Description = "BU MAINTENANCE" });
            MaintenanceMaster.Add(new DA.Models.MaintenanceMaster { Code = "AMC", Description = "AREA MALL CODE" });
            MaintenanceMaster.Add(new DA.Models.MaintenanceMaster { Code = "AV", Description = "APPEARANCE" });

            // 11.17.2017
            MaintenanceMaster.Add(new DA.Models.MaintenanceMaster { Code = "AWR", Description = "APPROVED WITH REQUIREMENTS" });
            //12.13.2017
            MaintenanceMaster.Add(new DA.Models.MaintenanceMaster { Code = "WEX", Description = "WITH EXCEPTIONS" });
            // 01/22/2018
            MaintenanceMaster.Add(new DA.Models.MaintenanceMaster { Code = "BU", Description = "BUSINESS UNIT" });
            MaintenanceMaster.Add(new DA.Models.MaintenanceMaster { Code = "SEG", Description = "SEGMENT" });
            // 02/05/2018
            MaintenanceMaster.Add(new DA.Models.MaintenanceMaster { Code = "MCC", Description = "MERCHANT CATEGORY CODE" });

            //03272018
            MaintenanceMaster.Add(new DA.Models.MaintenanceMaster { Code = "TC", Description = "TAX CODE" });
            MaintenanceMaster.Add(new DA.Models.MaintenanceMaster { Code = "TECI", Description = "TAX EXEMPTION CERTIFICATE ISSUED BY" });
            MaintenanceMaster.Add(new DA.Models.MaintenanceMaster { Code = "TEC", Description = "TAX EXEMPTION CLASSIFICATION" });
            MaintenanceMaster.Add(new DA.Models.MaintenanceMaster { Code = "RNS", Description = "REQUIRED NUMBER OF SIGNATORIES" });
            MaintenanceMaster.Add(new DA.Models.MaintenanceMaster { Code = "MG", Description = "MERCHANT GRADE" });
            MaintenanceMaster.Add(new DA.Models.MaintenanceMaster { Code = "BPR", Description = "BDO PAY RATING" });
            MaintenanceMaster.Add(new DA.Models.MaintenanceMaster { Code = "BPS", Description = "BDO PAY SEGMENT" });

            MaintenanceMaster.Add(new DA.Models.MaintenanceMaster { Code = "HO", Description = "HOME OWNERSHIP" });

            foreach (DA.Models.MaintenanceMaster maintenanceMaster in MaintenanceMaster)
            {
                maintenanceMaster.MaintenanceDetails = new Collection<DA.Models.MaintenanceDetails>();
                if (maintenanceMaster.Code.Equals("AMC"))
                {
                    Console.Write(maintenanceMaster.Code);
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "AREA MALL CODE 1", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "AREA MALL CODE 2", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "AREA MALL CODE 3", CreatedBy = "AO", CreatedDate = DateTime.Now });
                }

                if (maintenanceMaster.Code.Equals("RT"))
                {

                    Console.Write(maintenanceMaster.Code);
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "DRAFT", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "PRE SCREENED", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "FOR APPROVA WITH REQUIREMENTS", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "FOR APPROVAL", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "APPROVED", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "FOR CADENCIE PROCESSING", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "COMPLETED", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "CLOSED", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "DELETED", CreatedBy = "AO", CreatedDate = DateTime.Now });
                }

                if (maintenanceMaster.Code.Equals("AV"))
                {
                    Console.Write(maintenanceMaster.Code);
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "APPEARANCE 1", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "APPEARANCE 2", CreatedBy = "AO", CreatedDate = DateTime.Now });
                }

                if (maintenanceMaster.Code.Equals("RSV"))
                {


                    Console.Write(maintenanceMaster.Code);
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "NEW AFFILIATION", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "BRANCH AFFILIATION", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "ADDITIONAL FACILITY", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "POS", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "FILE_MAINTENANCE", CreatedBy = "AO", CreatedDate = DateTime.Now });


                }
                if (maintenanceMaster.Code.Equals("CU"))
                {
                    Console.Write(maintenanceMaster.Code);
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "PHP", Code = "PHP", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "USD", Code = "USD", CreatedBy = "AO", CreatedDate = DateTime.Now });
                }

                if (maintenanceMaster.Code.Equals("MC"))
                {
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "OTC", CreatedBy = "AO", Code = "OTC", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "EVENT", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "MOTO", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "DIRECT ECOM", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "TPP ECOM", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "RPS", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "DIRECT EMOTO", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "TPP MOTO", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "ERPS", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "MOB/GPRS", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "REGULAR INSTALLMENT", Code = "RI", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "BNPL", CreatedBy = "AO", Code = "BR", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "0%", CreatedBy = "AO", Code = "0%", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "0% BNPL", CreatedBy = "AO", Code = "B0", CreatedDate = DateTime.Now });

                }
                if (maintenanceMaster.Code.Equals("SU"))
                {
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "TPP-ASIAPAY", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "TPP-AURUMPAY", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "TPP-", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "WITH KEY-IN", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "WITH OUT KEY-IN", CreatedBy = "AO", CreatedDate = DateTime.Now });
                }
                if (maintenanceMaster.Code.Equals("MID"))
                {
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "STRAIGHT", Code = "OTC", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "REGULAR INSTALLMENT", Code = "RI", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "ZERO % INSTALLMENT", Code = "0%", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "BNPL", CreatedBy = "AO", Code = "BR", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "BNPL ZERO %", Code = "B0", CreatedBy = "AO", CreatedDate = DateTime.Now });
                }
                if (maintenanceMaster.Code.Equals("OW"))
                {
                    Console.Write(maintenanceMaster.Code);
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "SINGLE PROPRIETORSHIP", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "CORPORATION", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "PARTNERSHIP", CreatedBy = "AO", CreatedDate = DateTime.Now });
                }
                if (maintenanceMaster.Code.Equals("CY"))
                {
                    Console.Write(maintenanceMaster.Code);
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "PASIG", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "MAKATI", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "MANDALUYONG", CreatedBy = "AO", CreatedDate = DateTime.Now });
                }
                //Added By: Kin A. Quiambao 06/01/2017
                if (maintenanceMaster.Code.Equals("REO"))
                {
                    Console.Write(maintenanceMaster.Code);
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "REVISION OF MDR ADDON RATES", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "INC. INSTALL DETAILS", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "INC. PHOTOS", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "INC. DOCUMENTS", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "INC. SECRETARY CERT.", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "INC. SIGNATURE MATCH", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "UNCLEAR DOCUMENTS", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "INC. ID OF SIGNATORY", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "NO BUH APPROVAL", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "EXPIRED DOCUMENTS", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "INC. AUDITED FINANCIAL STATEMENT", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "INVALID CASA DETAILS", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "INC. DETAILS IN INFO SHEET", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "INC. FUNDS AT RISK", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "CHANGE MODE OF PAYMENT", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "INC. DETAILS IN MERCHANT AGREEMENT", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "INC. IN OIF", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "COMPARED WITH ORIGINAL COPY", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "NO DEED OF ASSIGNMENT", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "NO HOLD OUT DEPOSITS", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "OTHERS", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "THREE DAYS PAY DELAY", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "TANGENT GUIDELINES", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "SETTLEMENT OUTSTANDING BALANCE", CreatedBy = "AO", CreatedDate = DateTime.Now });
                }

                if (maintenanceMaster.Code.Equals("AOC"))
                {
                    Console.Write(maintenanceMaster.Code);
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "AOCODE - 1", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "AOCODE - 2", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "AOCODE - 3", CreatedBy = "AO", CreatedDate = DateTime.Now });
                }

                if (maintenanceMaster.Code.Equals("CS"))
                {
                    Console.Write(maintenanceMaster.Code);
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "SINGLE", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "MARRIED", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "SEPARATED", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "WIDOWED", CreatedBy = "AO", CreatedDate = DateTime.Now });
                }

                if (maintenanceMaster.Code.Equals("ZC"))
                {
                    Console.Write(maintenanceMaster.Code);
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "ZIPCODE - 1", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "ZIPCODE - 2", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "ZIPCODE - 3", CreatedBy = "AO", CreatedDate = DateTime.Now });
                }

                if (maintenanceMaster.Code.Equals("RO"))
                {
                    Console.Write(maintenanceMaster.Code);
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "RENTAL", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "OWNED", CreatedBy = "AO", CreatedDate = DateTime.Now });
                }

                if (maintenanceMaster.Code.Equals("SZC"))
                {
                    Console.Write(maintenanceMaster.Code);
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "SPOUSEZIPCODE - 1", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "SPOUSEZIPCODE - 2", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "SPOUSEZIPCODE - 3", CreatedBy = "AO", CreatedDate = DateTime.Now });
                }

                if (maintenanceMaster.Code.Equals("NR"))
                {
                    Console.Write(maintenanceMaster.Code);
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "New Installation", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "Reprogramming - DCC Setup", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "Reprogramming - TIP Adjust", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "Reprogramming - Slips Printing", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "Reprogramming - Logo", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "Reprogramming - Counter No.", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "Pull - Out", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "Swapping", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "TID Issuance", CreatedBy = "AO", CreatedDate = DateTime.Now });
                }

                if (maintenanceMaster.Code.Equals("AR"))
                {
                    Console.Write(maintenanceMaster.Code);
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "AREAVIEW - 1", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "AREAVIEW - 2", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "AREAVIEW - 3", CreatedBy = "AO", CreatedDate = DateTime.Now });
                }

                if (maintenanceMaster.Code.Equals("TA"))
                {
                    Console.Write(maintenanceMaster.Code);
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "TYPEACCOUNT - 1", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "TYPEACCOUNT - 2", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "TYPEACCOUNT - 3", CreatedBy = "AO", CreatedDate = DateTime.Now });
                }

                if (maintenanceMaster.Code.Equals("TBTM"))
                {
                    Console.Write(maintenanceMaster.Code);
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "TERMINALBRANDTYPEMODEL - 1", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "TERMINALBRANDTYPEMODEL - 2", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "TERMINALBRANDTYPEMODEL - 3", CreatedBy = "AO", CreatedDate = DateTime.Now });
                }

                if (maintenanceMaster.Code.Equals("RTSP"))
                {
                    Console.Write(maintenanceMaster.Code);
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "REASONFORTHREESLIPPRINTING - 1", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "REASONFORTHREESLIPPRINTING - 2", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "REASONFORTHREESLIPPRINTING - 3", CreatedBy = "AO", CreatedDate = DateTime.Now });
                }

                if (maintenanceMaster.Code.Equals("PS"))
                {
                    Console.Write(maintenanceMaster.Code);
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "PREMISESTATUS - 1", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "PREMISESTATUS - 2", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "PREMISESTATUS - 3", CreatedBy = "AO", CreatedDate = DateTime.Now });
                }

                if (maintenanceMaster.Code.Equals("TP"))
                {
                    Console.Write(maintenanceMaster.Code);
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "TYPEOFPREMISE - 1", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "TYPEOFPREMISE - 2", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "TYPEOFPREMISE - 3", CreatedBy = "AO", CreatedDate = DateTime.Now });
                }

                if (maintenanceMaster.Code.Equals("LOC"))
                {
                    Console.Write(maintenanceMaster.Code);
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "OUTSKIRT", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "NON - OUTSKIRT", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "HGA", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "HPA", CreatedBy = "AO", CreatedDate = DateTime.Now });
                }

                if (maintenanceMaster.Code.Equals("IA"))
                {
                    Console.Write(maintenanceMaster.Code);
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "INTERIORAPPEARANCE - 1", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "INTERIORAPPEARANCE - 2", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "INTERIORAPPEARANCE - 3", CreatedBy = "AO", CreatedDate = DateTime.Now });
                }

                if (maintenanceMaster.Code.Equals("EA"))
                {
                    Console.Write(maintenanceMaster.Code);
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "EXTERIORAPPEARANCE - 1", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "EXTERIORAPPEARANCE - 2", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "EXTERIORAPPEARANCE - 3", CreatedBy = "AO", CreatedDate = DateTime.Now });
                }

                if (maintenanceMaster.Code.Equals("SI"))
                {
                    Console.Write(maintenanceMaster.Code);
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "STOCKSINVENTORY - 1", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "STOCKSINVENTORY - 2", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "STOCKSINVENTORY - 3", CreatedBy = "AO", CreatedDate = DateTime.Now });
                }

                if (maintenanceMaster.Code.Equals("EQ"))
                {
                    Console.Write(maintenanceMaster.Code);
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "EQUIPMENT - 1", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "EQUIPMENT - 2", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "EQUIPMENT - 3", CreatedBy = "AO", CreatedDate = DateTime.Now });
                }

                if (maintenanceMaster.Code.Equals("TE"))
                {
                    Console.Write(maintenanceMaster.Code);
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "TYPEOFEVENT - 1", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "TYPEOFEVENT - 2", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "TYPEOFEVENT - 3", CreatedBy = "AO", CreatedDate = DateTime.Now });
                }

                if (maintenanceMaster.Code.Equals("OR"))
                {
                    Console.Write(maintenanceMaster.Code);
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "OVERALLRATING - 1", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "OVERALLRATING - 2", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "OVERALLRATING - 3", CreatedBy = "AO", CreatedDate = DateTime.Now });
                }
                if (maintenanceMaster.Code.Equals("CP"))
                {
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "MCVCJCACCC - 1", CreatedBy = "CP", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "JC - 2", CreatedBy = "CP", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "AC - 3", CreatedBy = "CP", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "PC - 4", CreatedBy = "CP", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "VC - 5", CreatedBy = "CP", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "MC - 6", CreatedBy = "CP", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "CC - 7", CreatedBy = "CP", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "DINERS - 8", CreatedBy = "CP", CreatedDate = DateTime.Now });

                }
                context.MaintenanceMaster.Add(maintenanceMaster);
                //Added by: Kin Quiambao 07/18/2017
                if (maintenanceMaster.Code.Equals("CC"))
                {
                    Console.Write(maintenanceMaster.Code);
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "CLASSCODE - 1", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "CLASSCODE - 2", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "CLASSCODE - 3", CreatedBy = "AO", CreatedDate = DateTime.Now });
                }

                if (maintenanceMaster.Code.Equals("SSH"))
                {
                    Console.Write(maintenanceMaster.Code);
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "SALESSLIPHANDLING - 1", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "SALESSLIPHANDLING - 2", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "SALESSLIPHANDLING - 3", CreatedBy = "AO", CreatedDate = DateTime.Now });
                }

                if (maintenanceMaster.Code.Equals("JRR"))
                {
                    Console.Write(maintenanceMaster.Code);
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "JCBREVISIONRSN - 1", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "JCBREVISIONRSN - 2", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "JCBREVISIONRSN - 3", CreatedBy = "AO", CreatedDate = DateTime.Now });
                }

                if (maintenanceMaster.Code.Equals("ARC"))
                {
                    Console.Write(maintenanceMaster.Code);
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "AMEXROLECODE - 1", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "AMEXROLECODE - 2", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "AMEXROLECODE - 3", CreatedBy = "AO", CreatedDate = DateTime.Now });
                }

                if (maintenanceMaster.Code.Equals("JSCR"))
                {
                    Console.Write(maintenanceMaster.Code);
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "JCBSCHEMECLOSEREASON - 1", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "JCBSCHEMECLOSEREASON - 2", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "JCBSCHEMECLOSEREASON - 3", CreatedBy = "AO", CreatedDate = DateTime.Now });
                }

                if (maintenanceMaster.Code.Equals("SAC1"))
                {
                    Console.Write(maintenanceMaster.Code);
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "SCHEMEAREACODE1 - 1", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "SCHEMEAREACODE1 - 2", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "SCHEMEAREACODE1 - 3", CreatedBy = "AO", CreatedDate = DateTime.Now });
                }

                if (maintenanceMaster.Code.Equals("SAC2"))
                {
                    Console.Write(maintenanceMaster.Code);
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "SCHEMEAREACODE2 - 1", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "SCHEMEAREACODE2 - 2", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "SCHEMEAREACODE2 - 3", CreatedBy = "AO", CreatedDate = DateTime.Now });
                }

                if (maintenanceMaster.Code.Equals("AAR"))
                {
                    Console.Write(maintenanceMaster.Code);
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "AMEXACTIVATIONREASON - 1", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "AMEXACTIVATIONREASON - 2", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "AMEXACTIVATIONREASON - 3", CreatedBy = "AO", CreatedDate = DateTime.Now });
                }

                if (maintenanceMaster.Code.Equals("JSRR"))
                {
                    Console.Write(maintenanceMaster.Code);
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "JCBSCHEMEREVISIONREASON - 1", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "JCBSCHEMEREVISIONREASON - 2", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "JCBSCHEMEREVISIONREASON - 3", CreatedBy = "AO", CreatedDate = DateTime.Now });
                }

                if (maintenanceMaster.Code.Equals("ACR"))
                {
                    Console.Write(maintenanceMaster.Code);
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "AMEXCANCELEDREASON - 1", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "AMEXCANCELEDREASON - 2", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "AMEXCANCELEDREASON - 3", CreatedBy = "AO", CreatedDate = DateTime.Now });
                }

                if (maintenanceMaster.Code.Equals("PD"))
                {
                    Console.Write(maintenanceMaster.Code);
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "PAYDELAY - 1", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "PAYDELAY - 2", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "PAYDELAY - 3", CreatedBy = "AO", CreatedDate = DateTime.Now });
                }

                if (maintenanceMaster.Code.Equals("CTC"))
                {
                    Console.Write(maintenanceMaster.Code);
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "CUPTAXCODE - 1", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "CUPTAXCODE - 2", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "CUPTAXCODE - 3", CreatedBy = "AO", CreatedDate = DateTime.Now });
                }
                if (maintenanceMaster.Code.Equals("MGC"))
                {
                    Console.Write(maintenanceMaster.Code);
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "MerchGrp4", Code = "4", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "MerchGrp1Z", Code = "1Z", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    //  maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "MERCHANT GROUP CODE - 3", Code = "MGC2", CreatedBy = "AO", CreatedDate = DateTime.Now });
                }
                if (maintenanceMaster.Code.Equals("CCH"))
                {
                    Console.Write(maintenanceMaster.Code);
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "BNP NFIS", Code = "NFIS", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "NLDS", Code = "NLDS", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "MATCH", Code = "MATCH", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "VTMS", Code = "VTMS", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "FRAUD", Code = "FRAUD", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "PEP", Code = "PEP", CreatedBy = "AO", CreatedDate = DateTime.Now });
                }

                // 11.17.2017

                if (maintenanceMaster.Code.Equals("AWR"))
                {
                    Console.Write(maintenanceMaster.Code);
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "Revision of MDR / ADD-ON / Subsidy Rates", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "Incomplete Installment Details", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "Incomplete Photos", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "Incomplete Documents", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "Incomplete Secretary Certificate Details", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "Inconsistent Signature Match", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "Unclear Documents", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "Incomplete ID of Signatory", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "No BUH Approval on GPRS Terminal", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "Expired Documents", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "Incomplete Audited Financial Statements", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "Invalid CASA Details", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "Incomplete Details in Info Sheet", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "Incomplete Funds at Risk (FAR)", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "Change Mode of Payment", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "Incomplete Details in Merchant Agreement", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "Incomplete Details in OIF", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "Document Without \"Compared with Original Copy\" Stamp", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "No Deed of Assignment Submitted", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "No Holdout of Deposit in ICBS", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "Others", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "3 Days Pay Delay", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "Fulfillment of Tangent Guidelines / Payment", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "Settlement of Outstanding Balance / Pass Due", CreatedBy = "AO", CreatedDate = DateTime.Now });
                }


                if (maintenanceMaster.Code.Equals("WEX"))
                {
                    Console.Write(maintenanceMaster.Code);
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "Deferment of Supplemental Agreement", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "Deferment of Merchant Agreement (MA)", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "Established fraud finding on owner/stockholders/signatory (perpetuated by the merchant)", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "Fails holdout amount requirement for E-Commerce or MOTO based on grid", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "Fails potential sales volume requirement", CreatedBy = "AO", CreatedDate = DateTime.Now });
                }

                if (maintenanceMaster.Code.Equals("BU"))
                {
                    Console.Write(maintenanceMaster.Code);
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "INSTITUTIONAL UNIT", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "SM OWNED UNIT", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "METRO MANILA ACQUIRING - East Manila Pasay Unit", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "METRO MANILA ACQUIRING - North South Unit", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "METRO MANILA ACQUIRING - Makati Taguig Unit", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "ALTERNATIVE CHANNELS UNIT", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "E-COMMERCE UNIT – Ecom Accts - SM Group / Airlines / PBC Area", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "E-COMMERCE UNIT – Head Office MM", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "PROVINCIAL BUSINESS CENTER UNIT", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "KEY ACCOUNTS", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "COMMERCIAL CARDS UNIT", CreatedBy = "AO", CreatedDate = DateTime.Now });
                }

                if (maintenanceMaster.Code.Equals("SEG"))
                {
                    Console.Write(maintenanceMaster.Code);
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "Ecom & BDO Pay", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "Luzon-Metro Manila", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "Ecom Accts - Hotels / Travel Agencies / Group Buying / Call Center / Retail / Freight / Foundation / Services / Subscription", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "Head Office - MM", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "Chain Retail Accounts", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "Chain Retail Accounts, RM Chinese /Developer Acct / Auto / Oil", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "Deliveries and Events", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "Dept Stores, Supermarkets, Hospitals", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "Hotels, Airlines", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "RPS, Autocharge, MOTO & Enterprise", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "Telecom and Chain Retail Accounts, Schools, Appliance", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "Key Accounts", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "Chain Accounts - Restaurants", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "Manila, Pasay", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "Ortigas Area/Greenhills/ San Juan", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "Pasig/Marikina/Cainta/Antipolo/Shaw/Mandaluyong", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "Rob Ermita, SM Manila, SM San Lazaro", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "Robinsons Galleria/Greenhills Shopping Center/San Juan outskirts/Wilson/Annapolis", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "SM MOA, Macapagal Ave, Roxas Blvd", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "Makati Taguig 1: BGC / Taguig", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "Makati Taguig 1: BGC / Taguig / Makati Area 1 / Hotel 1 / Makati Area 2 / Hotels 2", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "Makati Taguig 1: Makati Area 1 / Hotel 1", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "Makati Taguig 1: Makati Area 2 / Hotel 2", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "Makati Taguig 2: Makati Area 3", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "Makati Taguig 2: Makati Area 3 & 4", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "Makati Taguig 2: Makati Area 4", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "CAMANAVA, Visayas Ave., Congressional, Mindanao Ave, SM Valenzuela", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "Paranaque, Las Pinas, Muntinlupa, Festival", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "Trinoma, Tomas Morato, Timog, West Ave, New Manila, Quezon Ave, E. rod Sr, Banawe, Araneta Ave", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "ANGELES / TARLAC", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "BACOLOD", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "BAGUIO", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "BAGUIO / CAGAYAN VALLEY", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "BATANGAS", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "BICOL", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "CAVITE", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "CDO", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "CDO / CAMIGUIN", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "CEBU", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "DAGUPAN", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "DAVAO", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "DUMAGUETE", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "GENSAN", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "ILOILO", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "LAGUNA", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "PALAWAN", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "PAMPANGA", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "TACLOBAN", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "ZAMBOANGA", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "SM Owned & Affiliates", CreatedBy = "AO", CreatedDate = DateTime.Now });
                }

                if (maintenanceMaster.Code.Equals("BUM"))
                {
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "Merchant Acquiring Unit", Code = "mau", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "Merchant Data Control and Support", Code = "mdcs", CreatedDate = DateTime.Now });
                }

                if (maintenanceMaster.Code.Equals("MCC"))
                {
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "5421 - Department Store", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "5422 - Food Store", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "5423 - Gaming", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "5424 - Software Industry", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "5425 - Apparel Industry", CreatedBy = "AO", CreatedDate = DateTime.Now });
                }

                if (maintenanceMaster.Code.Equals("MCC"))
                {
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "5421 - Department Store", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "5422 - Food Store", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "5423 - Gaming", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "5424 - Software Industry", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "5425 - Apparel Industry", CreatedBy = "AO", CreatedDate = DateTime.Now });
                }

                //03272018
                if (maintenanceMaster.Code.Equals("TC"))
                {
                    Console.Write(maintenanceMaster.Code);
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "TAX RATE", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "NO TAX TYPE REQUIRED", CreatedBy = "AO", CreatedDate = DateTime.Now });
                }
                if (maintenanceMaster.Code.Equals("TECI"))
                {
                    Console.Write(maintenanceMaster.Code);
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "BIR", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "BOI", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "PEZA", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "CDC", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "SBMA", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "SPECIAL LAW", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "ETC.", CreatedBy = "AO", CreatedDate = DateTime.Now });
                }
                if (maintenanceMaster.Code.Equals("TEC"))
                {
                    Console.Write(maintenanceMaster.Code);
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "NSNP EDUCATIONAL INSTITUTION", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "NSNP CORP, ASSOC. FOUNDN,CHARITABLE INSTITUTION", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "COOPERATIVE", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "INTERNATIONAL AIR CARRIER", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "PEZZA ENTERPRISE", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "CDC ENTERPRISE", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "SBMA ENTERPRISE", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "BOI ENTERPRISE", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "PD,RA,AGREEMENT WITH RP", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "ETC.", CreatedBy = "AO", CreatedDate = DateTime.Now });
                }
                if (maintenanceMaster.Code.Equals("RNS"))
                {
                    Console.Write(maintenanceMaster.Code);
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "SINGLY", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "JOINTLY", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "ANY 2", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "ANY 1 FROM A & 1 FROM B", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "ETC.", CreatedBy = "AO", CreatedDate = DateTime.Now });
                }
                if (maintenanceMaster.Code.Equals("MG"))
                {
                    Console.Write(maintenanceMaster.Code);
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "H", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "N", CreatedBy = "AO", CreatedDate = DateTime.Now });
                }
                if (maintenanceMaster.Code.Equals("BPR"))
                {
                    Console.Write(maintenanceMaster.Code);
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "LOW RISK", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "MEDIUM RISK", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "HIGH RISK", CreatedBy = "AO", CreatedDate = DateTime.Now });
                }
                if (maintenanceMaster.Code.Equals("BPS"))
                {
                    Console.Write(maintenanceMaster.Code);
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "TRADITIONAL MERCHANT", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "PERSONAL MERCHANT", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "SMALL BUSINESS/ENTREPRENEUR", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "INFORMAL SELLER", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "ETC.", CreatedBy = "AO", CreatedDate = DateTime.Now });
                }
                if (maintenanceMaster.Code.Equals("HO"))
                {
                    Console.Write(maintenanceMaster.Code);
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "OWNED", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "RENTED", CreatedBy = "AO", CreatedDate = DateTime.Now });
                    maintenanceMaster.MaintenanceDetails.Add(new DA.Models.MaintenanceDetails { Value = "LIVING WITH PARENTS", CreatedBy = "AO", CreatedDate = DateTime.Now });
                }
                //documentList.Add(new DA.Models.DocumentList { Description = "" });             
                context.MaintenanceMaster.Add(maintenanceMaster);
            }


            IList<DA.Models.DocumentList> documentListToClear = context.DocumentList.ToList();
            if (documentListToClear != null)
            {

                context.DocumentList.RemoveRange(documentListToClear);
                context.SaveChanges();

                //"DBCC CHECKIDENT(tblPerson, RESEED, 0)"
                context.Database.ExecuteSqlCommand("DBCC CHECKIDENT(DocumentList, RESEED, 0)");
                //context.Database.ExecuteSqlCommand("DBCC CHECKIDENT(MaintenanceDetails, RESEED, 0)");

            }

            IList<DA.Models.DocumentList> documentList = new List<DA.Models.DocumentList>();
            documentList.Add(new DA.Models.DocumentList { Description = "Signed Merchant Information Sheet (MIS)" });
            documentList.Add(new DA.Models.DocumentList { Description = "Two(2) copies of Merchant Aggreement (MA)" });
            documentList.Add(new DA.Models.DocumentList { Description = "POS Installation / Reprogramming Form" });
            documentList.Add(new DA.Models.DocumentList { Description = "Ocular Inspection Form (OIF)" });
            documentList.Add(new DA.Models.DocumentList { Description = "BIR Certificate of Registration(Form 2303)" });
            documentList.Add(new DA.Models.DocumentList { Description = "Copy of Valid ID of Owner / All Signatory/ies" });
            documentList.Add(new DA.Models.DocumentList { Description = "DTI Business Registration Certificate" });
            documentList.Add(new DA.Models.DocumentList { Description = "Articles of Partnership with SEC Filing Certificate" });
            documentList.Add(new DA.Models.DocumentList { Description = "Latest Amended Articles of Incorporation & By - laws with SEC Filing Certificate" });
            documentList.Add(new DA.Models.DocumentList { Description = "Special Power of Attorney" });
            documentList.Add(new DA.Models.DocumentList { Description = "Notarized Partnership Resolution authorizing the signatory to enter into an agreement with BDO" });
            documentList.Add(new DA.Models.DocumentList { Description = "Notarized Board Resolution or Secretary's Certificate authorizing the signatory to enter into an agreement with BDO" });

            documentList.Add(new DA.Models.DocumentList { Description = "Proof of DBA Name (e.g., DTI Business Reg. Cert., Local Business Permits, BIT-COR, OR, Dealership / Franchise / Consignment Agreement)" });
            documentList.Add(new DA.Models.DocumentList { Description = "Latest Travel Association Certificate" });
            documentList.Add(new DA.Models.DocumentList { Description = "Deed of Assignment / Holdout Deposit" });
            documentList.Add(new DA.Models.DocumentList { Description = "Audited Financial Statment or latest 6 mos. Bank Statements" });
            documentList.Add(new DA.Models.DocumentList { Description = "Merchant Agreement for MOTO" });
            documentList.Add(new DA.Models.DocumentList { Description = "Merchant Agreement for E-Commerce" });
            documentList.Add(new DA.Models.DocumentList { Description = "Merchant Agreement for E-Commerce with Third Party Processor" });
            documentList.Add(new DA.Models.DocumentList { Description = "Merchant Agreement for E-MOTO" });
            documentList.Add(new DA.Models.DocumentList { Description = "Merchant Agreement of RPS" });
            documentList.Add(new DA.Models.DocumentList { Description = "Merchant Agreement for E-RPS" });
            documentList.Add(new DA.Models.DocumentList { Description = "Signed Installment Conforme" });
            documentList.Add(new DA.Models.DocumentList { Description = "Signed BNPL Installment Conforme" });
            documentList.Add(new DA.Models.DocumentList { Description = "Secretary's Certificate with 3rd Party CASA Assignmeent (to be issued by the merchant)" });
            documentList.Add(new DA.Models.DocumentList { Description = "Partnership Resolution with 3rd Party CASA Assignment (to be issued by the merchant)" });
            documentList.Add(new DA.Models.DocumentList { Description = "Third Party Secretary's Certificate (to be issued by third party casa owner)" });
            //documentList.Add(new DA.Models.DocumentList { Description = "Third Party Secretary's Certificate (to be issued by third party casa owner)" });
            documentList.Add(new DA.Models.DocumentList { Description = "Signed Designated 3rd Party CASA (to be signed both by the merchant and the third party casa owner)" });
            documentList.Add(new DA.Models.DocumentList { Description = "Merchant's Request Letter / Email" });
            documentList.Add(new DA.Models.DocumentList { Description = "Signed Installment Conforme" });
            documentList.Add(new DA.Models.DocumentList { Description = "Tax Exemption Certificate" });
            documentList.Add(new DA.Models.DocumentList { Description = "Secretary's Certificate" });
            documentList.Add(new DA.Models.DocumentList { Description = "MDCF" });
            documentList.Add(new DA.Models.DocumentList { Description = "Signed MA" });
            documentList.Add(new DA.Models.DocumentList { Description = "Signed CNP MA / Supplement" });
            documentList.Add(new DA.Models.DocumentList { Description = "Amended SEC Certificate of Inc." });
            documentList.Add(new DA.Models.DocumentList { Description = "Preferred, Exclusively Arrangement" });
            documentList.Add(new DA.Models.DocumentList { Description = "BIR Certificate of Registration" });
            // documentList.Add(OIF)
            // documentList.Add(DBA Trade Name);

            foreach (var docs in documentList)
            {
                context.DocumentList.Add(docs);
            }

            //context.Dispose();
            base.Seed(context);
        }
    }
}
