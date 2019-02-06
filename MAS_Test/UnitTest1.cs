using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MerchantAquiringSystemWithWF;
using System.Linq;

using System.Configuration;
using System.Collections.Generic;

namespace MAS_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DA.UnitOfWork unit = new DA.UnitOfWork();
            var request = new DA.Models.Request
            {

                CreatedBy = "user1"
                ,
                CreatedDate = DateTime.Now
                ,
                RequestDescription = "Test Request7",
                Status = 1
                //RequiredApprovals.


            };

            unit.RequestRepository.Add(request);
            unit.Complete();


            var createdRequest = unit.RequestRepository.Find(x => x.CreatedBy.Equals("user1")).FirstOrDefault();

            Assert.AreNotEqual(createdRequest, null);
            unit.Dispose();


        }

        [TestMethod]
        public void TestMethod2()
        {
            DA.UnitOfWork unit = new DA.UnitOfWork();
            var request = new DA.Models.Request
            {

                CreatedBy = "user1"
                ,
                CreatedDate = DateTime.Now
                ,
                RequestDescription = "Test Request7",
                Status = 1
                //RequiredApprovals.


            };
            var neAff = new DA.Models.NewAffiliation {
                eMail="afds@ddsfdf.com"

            };

            request.NewAffiliation = neAff;
            unit.RequestRepository.Add(request);
            unit.Complete();


            var createdRequest = unit.RequestRepository.Find(x => x.CreatedBy.Equals("user1")).FirstOrDefault();

            Assert.AreNotEqual(createdRequest, null);
            unit.Dispose();


        }

    }
}
