using DA;
using MAS_WorkFlowService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MerchantAquiringSystemWithWF.Controllers
{
    public class NewAffiliationController : Controller
    {
        //
        // GET: /NewAffiliation/
        private UnitOfWork unitOfWork = new UnitOfWork();

        // GET: Requests
        public ActionResult Index()
        {
            List<Models.RequestViewModel> list = new List<Models.RequestViewModel>();
            int requestType = RequestConfigHelper.GetRequestType("NEW_AFFILIATION").Value;
            unitOfWork.RequestRepository.Find(x => x.RequestType.Equals(requestType), x => x.NewAffiliation).ToList().ForEach(x => list.Add(new Models.RequestViewModel
            {
                Id = x.Id,
                RequestDescription = x.RequestDescription,
                CreatedBy = x.CreatedBy,
                CreatedDate = x.CreatedDate,
                //Status = x.Status==1 || x.Status == 11 || x.Status == 12 || x.Status == 25 ?  RequestConfigHelper.GetStatusDisplayName(x.Status): "FOR " + RequestConfigHelper.GetStatusDisplayName(x.Status),
                Status = RequestConfigHelper.GetStatusDisplayName(x.Status),
                View = RequestConfigHelper.GetStatusConfig(x.Status).view,
                RequestType = RequestConfigHelper.GetRequestTypeDisplayName(x.RequestType)


            }));


            return View(list);
        }
        [HttpGet]
        public ActionResult GetRequestList()
        {
            List<Models.RequestViewModel> list = new List<Models.RequestViewModel>();
            int requestType = RequestConfigHelper.GetRequestType("NEW_AFFILIATION").Value;
            unitOfWork.RequestRepository.Find(x => x.RequestType.Equals(requestType), x => x.NewAffiliation).ToList().ForEach(x => list.Add(new Models.RequestViewModel
            {
                Id = x.Id,
                RequestDescription = x.RequestDescription,
                CreatedBy = x.CreatedBy,
                CreatedDate = x.CreatedDate,
                //Status = x.Status==1 || x.Status == 11 || x.Status == 12 || x.Status == 25 ?  RequestConfigHelper.GetStatusDisplayName(x.Status): "FOR " + RequestConfigHelper.GetStatusDisplayName(x.Status),
                Status = RequestConfigHelper.GetStatusDisplayName(x.Status),
                View = RequestConfigHelper.GetStatusConfig(x.Status).view,
                RequestType = RequestConfigHelper.GetRequestTypeDisplayName(x.RequestType)


            }));


            //return View(list);
            return Json(list,
               JsonRequestBehavior.AllowGet);
        }
        public ActionResult Create()
        {

            var ownershipTypeList = new List<SelectListItem>();
            var dd = new DropDownValues(unitOfWork.Context);
            dd.GetAll("OW").ToList().ForEach(x =>
                ownershipTypeList.Add(new SelectListItem { Text = x.Value, Value = x.Id.ToString() })

                );

            ViewBag.ownershipTypeList = ownershipTypeList;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(DA.Models.Customer customer)
        {
           
            var request = new DA.Models.Request {
                RequestType = RequestConfigHelper.GetRequestType(RequestTypeConstants.NEW_AFFILIATION).Value,
                Status = RequestState.DRAFT.Value,
                CreatedBy ="User",
                CreatedDate=DateTime.Now,
                RequestDescription="New Affilation",
                NewAffiliation = new DA.Models.NewAffiliation {
                    Customer = customer
                }

            };
            //unitOfWork.BusinessRepository.Add(business);
            unitOfWork.RequestRepository.Add(request);
            unitOfWork.Complete();
            
            return RedirectToAction("Draft", "RequestUIFlow", new { Id = request.Id });
        }
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