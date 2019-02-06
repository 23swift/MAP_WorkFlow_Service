using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.Entity.Core.Objects;

namespace MAS_Test
{
    [TestClass]
    public class AffiliationTest
    {
        [TestMethod]
        public void CreateNewAffiliationRequest()
        {
            using (var db = new DA.MAS_DB())
            {
                db.Configuration.AutoDetectChangesEnabled = true;
                var affiliation = new DA.Models.NewAffiliation();
                affiliation.Customer = new DA.Models.Customer
                {
                    DtiSecDate  = DateTime.Now,
                    LegalName = "Business"

                };
                var request = new DA.Models.Request
                {

                    NewAffiliation = affiliation
                };
                db.Request.Add(request);

                db.SaveChanges();
               
            
            }
        }
        [TestMethod]
        public void CreatePOSRequest() {
            using (var db = new DA.MAS_DB())
            {
                var request = new DA.Models.Request();
                request.TrackingNo = "0000001";
                request.RequestDescription = "NLogTEst";
                request.CreatedBy = "Arnold Costamero";
                request.CreatedDate = DateTime.Now;
                var pos = new DA.Models.POSRequest {
                    CreatedBy="Arnold",Status=1,RequestDescription="New InstallATION",
                    CreatedDate=DateTime.Now,WorkflowInstanceId=Guid.NewGuid()
                    
                };
                request.POSRequest = pos;

                db.Request.Add(request);
                db.SaveChanges();

            }

        }
        [TestMethod]
        public void UpdatePOSRequest()
        {
            using (var db = new DA.MAS_DB())
            {
                var pos= db.POSRequest.Find(57);


                pos.UpdatedBy = "Arnold";
                pos.UpdatedDate = DateTime.Now;
                pos.Status = 3;
                pos.RequestDescription = "New Installation Updated";
                db.SaveChanges();

                

            }

        }


    }
}
