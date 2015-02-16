using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RouteOptimization.Infrastructure;


namespace RouteOptimizationUI.Controllers
{
    public class StoreController : Controller
    {
        private RouteOptimizationDBEntities db = new RouteOptimizationDBEntities();

        // GET: Store

        public ActionResult Index( )
        {
            StoreDAL storeBO = new StoreDAL();
           
            List<Store> _storeslist = new List<Store> { };

            _storeslist.AddRange(storeBO.FillAll());

            var model =
                from r in _storeslist
                select r;

            return View(model);

            //var stores = db.Stores.Include(s => s.Address).Include(s => s.Retailer);
            //return View(stores.ToList());
        }

        // GET: Store/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Store store = db.Stores.Find(id);
            if (store == null)
            {
                return HttpNotFound();
            }
            return View(store);
        }

        // GET: Store/Create
        public ActionResult Create()
        {
            ViewBag.AddressID = new SelectList(db.Addresses, "AddressID", "Address1");
            ViewBag.RetailerID = new SelectList(db.Retailers, "RetailerID", "Name");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "StoreID,Name,StoreNumber,RetailerID,EmailID,Phone,AddressID")] Store store)
        {
            if (ModelState.IsValid)
            {
                StoreDAL storeBO = new StoreDAL();
                storeBO.AddorUpdate(store);
                return RedirectToAction("Index");
            }
            ViewBag.AddressID = new SelectList(db.Addresses, "AddressID", "Address1", store.AddressID);
             ViewBag.RetailerID = new SelectList(db.Retailers, "RetailerID", "Name", store.RetailerID);
             return View(store);
        }

        // POST: Store/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "StoreID,Name,StoreNumber,RetailerID,EmailID,Phone,AddressID")] Store store)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Stores.Add(store);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    ViewBag.AddressID = new SelectList(db.Addresses, "AddressID", "Address1", store.AddressID);
        //    ViewBag.RetailerID = new SelectList(db.Retailers, "RetailerID", "Name", store.RetailerID);
        //    return View(store);
        //}

        // GET: Store/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Store store = db.Stores.Find(id);
            if (store == null)
            {
                return HttpNotFound();
            }
            ViewBag.AddressID = new SelectList(db.Addresses, "AddressID", "Address1", store.AddressID);
            ViewBag.RetailerID = new SelectList(db.Retailers, "RetailerID", "Name", store.RetailerID);
            return View(store);
        }

        // POST: Store/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "StoreID,Name,StoreNumber,RetailerID,EmailID,Phone,AddressID")] Store store)
        {
            if (ModelState.IsValid)
            {

                StoreDAL storeBO = new StoreDAL();
                storeBO.AddorUpdate(store);
               // db.Entry(store).State = EntityState.Modified;
               // db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AddressID = new SelectList(db.Addresses, "AddressID", "Address1", store.AddressID);
            ViewBag.RetailerID = new SelectList(db.Retailers, "RetailerID", "Name", store.RetailerID);
            return View(store);
        }

        // GET: Store/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Store store = db.Stores.Find(id);
            if (store == null)
            {
                return HttpNotFound();
            }
            return View(store);
        }

        // POST: Store/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Store store = db.Stores.Find(id);

            StoreDAL storeBO = new StoreDAL();
            storeBO.DeleteP(store.StoreID);

            //db.Stores.Remove(store);
            //db.SaveChanges();
            return RedirectToAction("Index");
        }


        //public ActionResult ListStores(StoreDAL st)
        //{

        //    List<StoreDAL> _storeslist = new List<StoreDAL> { };

        //    _storeslist.Add(st);

        //    var model =
        //        from r in _storeslist

        //        select r;

        //    return View(model);

        //    //List<StoreDAL> _prodlist = new List<StoreDAL> { };
        //    //var model =
        //    //    from r in _prodlist
        //    //    select r;
        //    //return View("Index",model);
        //}

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
