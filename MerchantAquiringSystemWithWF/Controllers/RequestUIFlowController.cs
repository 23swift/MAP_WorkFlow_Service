using DA;
using DA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MAS_WorkFlowService;
namespace MerchantAquiringSystemWithWF.Controllers
{
    public class RequestUIFlowController : Controller
    {
         MAS_MainFlow.ServiceClient MasMainflow= new MAS_MainFlow.ServiceClient();
        private UnitOfWork unitOfWork = new UnitOfWork();
        // GET: RequestUIFlow
        public ActionResult DRAFT(Int32? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            // Request request = unitOfWork.RequestRepository.Get((int)Id, x => x.NewAffiliation, x => x.NewAffiliation.Branches);

            // Request request = unitOfWork.RequestRepository.Get((Int32)Id, x => x.NewAffiliation, x => x.NewAffiliation.Business.Branches);
            Request request = null;

            var requestForm = new Models.RequestFormViewModel
            {
                Id = request.Id,
                CreatedBy = request.CreatedBy,
                CreatedDate = (DateTime)request.CreatedDate
                ,
                //LegalName = request.NewAffiliation.Business.LegalName,
               // Ownership = 
                RequestDescription = request.RequestDescription,
                eMail = request.NewAffiliation.eMail

            };
            ViewBag.view= "LoadRequestToWorkflow";
            ViewBag.Title = RequestConfigHelper.GetRequestTypeDisplayName(request.RequestType);
            ViewBag.status = RequestConfigHelper.GetStatusConfig(request.Status).Name;
          //  ViewBag.brnachList = request.NewAffiliation.Business.Branches.ToList();

           
            if (request == null)
            {
                return HttpNotFound();
            }
            ViewBag.msg = "";
            var seg = Request.UrlReferrer.Segments.Where(x => !x.Equals("/")).ToList();

            if (Request.UrlReferrer.AbsolutePath.Contains("Create") || Request.UrlReferrer.AbsolutePath.Contains("Edit"))
            {
                ViewBag.msg = "Record Saved.";
            }


            return View(requestForm);
        }
        public ActionResult LoadRequestToWorkflow(Int32 Id)
        {
           var msg= MasMainflow.LoadRequest(Id);
            ViewBag.msg = msg;
            return View("SuccessView");
        }
        public ActionResult AO_CHECKING(Int32? Id)
        {
            ViewBag.Id = Id;
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Request request = unitOfWork.RequestRepository.Get((Int32)Id);
           

            var requestForm = new Models.RequestFormViewModel
            {
                Id = request.Id,
                CreatedBy = request.CreatedBy,
                CreatedDate = (DateTime)request.CreatedDate
               ,
                RequestDescription = request.RequestDescription,
                eMail = request.NewAffiliation.eMail

            };
            ViewBag.returnAction = "ReturnToMaker";
            ViewBag.submitAction = "SubmitForPreScreen";
            ViewBag.actionName = RequestConfigHelper.GetStatusConfig(request.Status).view;
            ViewBag.status = RequestConfigHelper.GetStatusConfig(request.Status).Name;
            ViewBag.Title = RequestConfigHelper.GetRequestTypeDisplayName(request.RequestType);
            
            //ViewBag.brnachList = request.NewAffiliation.Business.Branches.ToList();
            if (request == null)
            {
                return HttpNotFound();
            }
            return View(requestForm);
        }
        public ActionResult SubmitForPreScreen(Int32 Id)
        {
           var msg = MasMainflow.AOChecking(Id,true);
            ViewBag.msg = msg;
            return View("SuccessView");
        }
        public ActionResult RETURN_TO_MAKER(Int32 Id)
        {
            var msg = MasMainflow.AOChecking(Id, false);
            ViewBag.msg = msg;
            return View("SuccessView");
        }


        public ActionResult MAU_SCREENING(Int32? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Request request = unitOfWork.RequestRepository.Get((Int32)Id);
            //ViewBag.returnAction = "ReturnToMaker";
            ViewBag.actionName = RequestConfigHelper.GetStatusConfig(request.Status).view;
            ViewBag.status = RequestConfigHelper.GetStatusConfig(request.Status).Name;
            ViewBag.submitAction = "MAUPreScreenDecission";
            if (request == null)
            {
                return HttpNotFound();
            }
            return View(request);
        }
        public ActionResult MAUPreScreenDecission(Int32 Id)
        {
            var msg = MasMainflow.PreScreenDecission (Id, true);
            ViewBag.msg = msg;
            return View("SuccessView");
        }
        public ActionResult FOR_APPROVAL(Int32? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Request request = unitOfWork.RequestRepository.Get((Int32)Id);
            ViewBag.status = RequestConfigHelper.GetStatusConfig(request.Status).Name;
            //ViewBag.returnAction = "ReturnToMaker";
            ViewBag.ApproveAction = "Approve";
            ViewBag.DeclineAction = "Decline";
            if (request == null)
            {
                return HttpNotFound();
            }
            return View(request);
        }
        public ActionResult Approval2(Int32? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Request request = unitOfWork.RequestRepository.Get((Int32)Id);
            //ViewBag.returnAction = "ReturnToMaker";
            ViewBag.ApproveAction = "Approve2";
            ViewBag.DeclineAction = "Decline2";
            if (request == null)
            {
                return HttpNotFound();
            }
            return View(request);
        }
        public ActionResult Approve(Int32 Id)
        {
            var msg = MasMainflow.RequestApproval(Id, true,"Arnold Costamero","C2");
            ViewBag.msg = msg;
            return View("SuccessView");
        }
        //public ActionResult Approve2(Int32 Id)
        //{
        //    var msg = MasMainflow.RequestApproval2(Id, true, "Arnold Costamero", "C2");
        //    ViewBag.msg = msg;
        //    return View("SuccessView");
        //}
        public ActionResult Decline(Int32 Id)
        {
            var msg = MasMainflow.RequestApproval(Id, false, "Arnold Costamero", "C2");
            ViewBag.msg = msg;
            return View("SuccessView");
        }
        //public ActionResult Decline2(Int32 Id)
        //{
        //    var msg = MasMainflow.RequestApproval2(Id, false, "Arnold Costamero", "C2");
        //    ViewBag.msg = msg;
        //    return View("SuccessView");
        //}
        public ActionResult PickRequestForMDCSProcessing(Int32 Id)
        {
            var msg = MasMainflow.PickRequestForMDCSProcessing(Id);
            ViewBag.msg = msg;
            return RedirectToAction("MDCSProcessing", new { Id = Id });
        }
        public ActionResult MDCS_PROCESSING(Int32 Id)
            {
           
            Request request = unitOfWork.RequestRepository.Get((Int32)Id);
            ViewBag.submitToPOS = "SubmitForPOSProcessing";
            ViewBag.status = RequestConfigHelper.GetStatusConfig(request.Status).Name;

            if (request == null)
            {
                return HttpNotFound();
            }
            return View(request);
        }
        public ActionResult SubmitForPOSProcessing(Int32 Id)
        {
            var msg = MasMainflow.SubmitForPOSProcessing(Id);
            ViewBag.msg = msg;
            return View("SuccessView");
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                MasMainflow=null;
            }
            base.Dispose(disposing);
        }
    }
}