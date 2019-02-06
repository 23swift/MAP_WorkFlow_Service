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
using MAS_WorkFlowService;
namespace MerchantAquiringSystemWithWF.Controllers
{
    public class ApprovalSetupController : Controller
    {
        private MAS_DB db = new MAS_DB();

        // GET: ApprovalSetup
        public ActionResult Index()
        {
            var matrix = new List<Models.ApprovalSetupViewModel>();
          
            
            db.ApprovalSetup.ToList().ForEach(x => {
                matrix.Add(new  Models.ApprovalSetupViewModel
                {
                    Id = x.Id, Rank = x.Rank, WithException = x.WithException,
                    WithRequirements = x.WithRequirements, RequestType = RequestConfigHelper.GetRequestTypeDisplayName(x.RequestType),
                    ApprovalCount=x.ApprovalCount

                });
            });
            return View(matrix);
        }

        // GET: ApprovalSetup/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ApprovalSetup approvalSetup = db.ApprovalSetup.Find(id);
            if (approvalSetup == null)
            {
                return HttpNotFound();
            }
            return View(approvalSetup);
        }

        // GET: ApprovalSetup/Create
        public ActionResult Create()
        {
            var requestTypeList = new List<SelectListItem>();
            RequestConfigHelper.GetAllRequestType().ForEach(x =>
                requestTypeList.Add(new SelectListItem { Text = x.DisplayName, Value = x.Value.ToString() })

                );
            ViewBag.requestTypeList = requestTypeList;
           
            return View();
        }

        // POST: ApprovalSetup/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,ApprovalCount,Rank,WithRequirements,WithException,RequestType")] ApprovalSetup approvalSetup)
        {
            if (ModelState.IsValid)
            {
                db.ApprovalSetup.Add(approvalSetup);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(approvalSetup);
        }

        // GET: ApprovalSetup/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ApprovalSetup approvalSetup = db.ApprovalSetup.Find(id);
            if (approvalSetup == null)
            {
                return HttpNotFound();
            }
            return View(approvalSetup);
        }

        // POST: ApprovalSetup/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ApprovalCount,Rank,WithRequirements,WithException,RequestType")] ApprovalSetup approvalSetup)
        {
            if (ModelState.IsValid)
            {
                db.Entry(approvalSetup).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(approvalSetup);
        }

        // GET: ApprovalSetup/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ApprovalSetup approvalSetup = db.ApprovalSetup.Find(id);
            if (approvalSetup == null)
            {
                return HttpNotFound();
            }
            return View(approvalSetup);
        }

        // POST: ApprovalSetup/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ApprovalSetup approvalSetup = db.ApprovalSetup.Find(id);
            db.ApprovalSetup.Remove(approvalSetup);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
