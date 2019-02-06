using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DA;
using DA.Models;

namespace MerchantAquiringSystemWithWF.Controllers
{
    public class BranchController : Controller
    {
        private UnitOfWork unitOfWork = new UnitOfWork();

       

        // GET: Branche/Details/5
        //public ActionResult Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Branch branch = db.Branch.Find(id);
        //    if (branch == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(branch);
        //}

        // GET: Branche/Create
        public ActionResult Create(Int32 requestId)
        {
            ViewBag.RequestId = requestId;
            return View();
        }

        // POST: Branche/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,dbaAddress1,dbaAddress2,dbaAddress3,City_Id,DBAName,legalName")] Branch branch,Int32? requestId)
        {
            //if (ModelState.IsValid)
            //{
               
            //    Request request = unitOfWork.RequestRepository.Get((Int32)requestId,x=>x.NewAffiliation,y=>y.NewAffiliation.Business);
            //   // request.NewAffiliation.Customer.Branches.Add(branch);
            //    unitOfWork.RequestRepository.Update(request);
            //    unitOfWork.Complete();
            //    return RedirectToAction("DRAFT", "RequestUIFlow",new { Id=request.Id});
            //}

            return View(branch);
        }

        //GET: Branche/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Branch branch = unitOfWork.BranchRepository.Get((int)id);
            if (branch == null)
            {
                return HttpNotFound();
            }
            return View(branch);
        }

        //// POST: Branche/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "Id,dbaAddress1,dbaAddress2,dbaAddress3,City_Id,DBAName,areaMallCode,payDelayDays,dateClosed,closedreason,owningMerchant,JCBAcceptorId,JCBSchemeClosereason,JCBSchemeRevisionReason,JCBRevisionRSN,schemeAreaCode1,schemeAreaCode2,AMEXCardAcceptorId,AMEXActivationReason,AMEXCanceledReason,AMEXRoleCode,AMEXRiskIND,AMEXKeyAcctIND,CUPCardAcceptorId,CUPTaxCode,CUPTaxNumber,CUPTaxExemptExpiryDate,imprinterPlateName,imprinterPlateNumbers,imprinterAMEX,imprinterDC,imprinterJCB,imprinterOthers,principalName1,principalName2,principalName3,principalName4,principalName5,adminContactperson,goodsServices,phoneNo,mobileNo,emailAddress,mailingAddress1,withECR,merchantGrade,serviceProvider,website,cardHolderData,cardHolderDataTobeStored,MCC_Id,branchCode,imprinterTotal,dbaZipCode,regionCode,checkDeliveryCode,paymentMode,settlementAcctNo,merchantGroupCode,TIN,withTax,cardPlan,isActive,isAffiliated,dbaAddress4,principalFirstName,principalLastName,principalMiddleName,mailingAddress2,mailingAddress3,mailingAddress4,mailingCity,mailingAddressZipCode,dbaCity,taxExemptFrom,taxExemptTo,taxExemptIssuedBy,registeredBusinessNo,DTIBusinessRegDate,SECRegDate,withAcquirer,acquirerInstitutionName,ecrForInstallation,isSwipingCardWithoutInstalledECR,isSwipingCardWithInstalledECR,debitSettlementAcctNo,payeesName,emailAddressForReport,SOARecipients,SOAEmailAddress,reportDistributionperCompany,reportPerBranch,principalFbName,principalDateOfBirth,principalCivilStatus,principalPhoneNo,principalPermanentAddress,principalCity,principalZipCode,principalHomeOwnership,spouseAddress,spouseCity,spouseFirstName,spouseLastName,spouseMiddleName,spousePhoneNo,spouseZipCode,financialInstitution,accountFacility,acctLoanNo,loanTerm,noOfPos,discountDebitRate,storeId,reportPerCompanysBranch,ftpDir,genPayment,computeCWT,settlementPerBranch,customerNo,amexRating,bdoPayRating,bdoPaySegment,aoCode,feeAccount,forMoto,strategicMerchant,tranSource,holdOutAcctNo,holdOutAmount,remarks,preparedBy,preparedDate,notedBy,notedDate,controlNo,smsSending,withDependency,custr,postMaintReview,postMaintReviewDate,currentDate,midCount,midDateTimeCreated,tidCount,tidDateTimeCreated,mdf,mdfChecker,mdfDateTimeChecked,mdfMaker,mcId,debitMailingAddressCity,debitMailingAddressZipCode,sendBdo030114,branch,tradeCustomerName,tradeContactNo,debitMerchantNo,isSingleProp,isPartnershipCorp,mdfDateTimeCreated,legalName")] Branch branch)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(branch).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(branch);
        //}

        //// GET: Branche/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Branch branch = db.Branch.Find(id);
        //    if (branch == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(branch);
        //}

        //// POST: Branche/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    Branch branch = db.Branch.Find(id);
        //    db.Branch.Remove(branch);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                unitOfWork.Dispose();
                
            }
            base.Dispose(disposing);
        }
    }
}
