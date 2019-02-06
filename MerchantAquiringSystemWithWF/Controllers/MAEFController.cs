using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DA;
using DA.Models;
using MAS_WorkFlowService;
namespace MerchantAquiringSystemWithWF.Controllers
{
  
    public class MAEFController : Controller
    {
        private UnitOfWork unitOfWork = new UnitOfWork();
        // GET: MAEF
        public ActionResult Index()
        {
            return View();
        }

            public ActionResult MAEFDetails(Int32? Id)
        {
            Request request = unitOfWork.RequestRepository.Get((Int32)Id);
            ViewBag.returnAction = "ReturnToMaker";
            ViewBag.submitAction = "SubmitForPreScreen";
            ViewBag.actionName = RequestConfigHelper.GetStatusConfig(request.Status).view;
            ViewBag.status = RequestConfigHelper.GetStatusConfig(request.Status).Name;
            ViewBag.Id = Id;
            return View();
        }

        public ActionResult Create(Int32? Id)
        {
            return View();
        }
    }
}