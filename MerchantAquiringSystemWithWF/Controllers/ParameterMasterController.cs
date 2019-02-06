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
    public class ParameterMasterController : Controller
    {
        private MAS_DB db = new MAS_DB();

        // GET: /ParameterMaster/
        public ActionResult Index()
        {
            return View(db.MaintenanceMaster.Include(x=>x.MaintenanceDetails).ToList());
        }

        // GET: /ParameterMaster/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MaintenanceMaster maintenanceMaster = db.MaintenanceMaster.Find(id);
            if (maintenanceMaster == null)
            {
                return HttpNotFound();
            }
            return View(maintenanceMaster);
        }

        // GET: /ParameterMaster/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /ParameterMaster/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="Id,Description,Code")] MaintenanceMaster maintenanceMaster)
        {
            if (ModelState.IsValid)
            {
                db.MaintenanceMaster.Add(maintenanceMaster);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(maintenanceMaster);
        }

        // GET: /ParameterMaster/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MaintenanceMaster maintenanceMaster = db.MaintenanceMaster.Find(id);
            if (maintenanceMaster == null)
            {
                return HttpNotFound();
            }
            return View(maintenanceMaster);
        }

        // POST: /ParameterMaster/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="Id,Description,Code")] MaintenanceMaster maintenanceMaster)
        {
            if (ModelState.IsValid)
            {
                db.Entry(maintenanceMaster).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(maintenanceMaster);
        }

        // GET: /ParameterMaster/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MaintenanceMaster maintenanceMaster = db.MaintenanceMaster.Find(id);
            if (maintenanceMaster == null)
            {
                return HttpNotFound();
            }
            return View(maintenanceMaster);
        }

        // POST: /ParameterMaster/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MaintenanceMaster maintenanceMaster = db.MaintenanceMaster.Find(id);
            db.MaintenanceMaster.Remove(maintenanceMaster);
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
