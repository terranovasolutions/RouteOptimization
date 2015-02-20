using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RouteOptimization.Infrastructure;
using RouteOptimizationUI.Models;

namespace RouteOptimizationUI.Controllers
{
    public class RetailerstryController : Controller
    {
        private RouteOptimizationUIContext db = new RouteOptimizationUIContext();

        // GET: Retailerstry
        public ActionResult Index()
        {
            var retailers = db.Retailers.Include(r => r.Address);
            return View(retailers.ToList());
        }

        // GET: Retailerstry/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Retailer retailer = db.Retailers.Find(id);
            if (retailer == null)
            {
                return HttpNotFound();
            }
            return View(retailer);
        }

        // GET: Retailerstry/Create
        public ActionResult Create()
        {
            ViewBag.AddressID = new SelectList(db.Addresses, "AddressID", "Address1");
            return View();
        }

        // POST: Retailerstry/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RetailerID,Name,RetailerNumber,EmailID,Phone,AddressID")] Retailer retailer)
        {
            if (ModelState.IsValid)
            {
                db.Retailers.Add(retailer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.AddressID = new SelectList(db.Addresses, "AddressID", "Address1", retailer.AddressID);
            return View(retailer);
        }

        // GET: Retailerstry/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Retailer retailer = db.Retailers.Find(id);
            if (retailer == null)
            {
                return HttpNotFound();
            }
            ViewBag.AddressID = new SelectList(db.Addresses, "AddressID", "Address1", retailer.AddressID);
            return View(retailer);
        }

        // POST: Retailerstry/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RetailerID,Name,RetailerNumber,EmailID,Phone,AddressID")] Retailer retailer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(retailer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AddressID = new SelectList(db.Addresses, "AddressID", "Address1", retailer.AddressID);
            return View(retailer);
        }

        // GET: Retailerstry/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Retailer retailer = db.Retailers.Find(id);
            if (retailer == null)
            {
                return HttpNotFound();
            }
            return View(retailer);
        }

        // POST: Retailerstry/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Retailer retailer = db.Retailers.Find(id);
            db.Retailers.Remove(retailer);
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
