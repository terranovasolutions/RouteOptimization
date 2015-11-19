using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RouteOptimization.Infrastructure;


namespace RouteOptimizationUI.Controllers
{
    public class RetailerController : Controller
    {
        //        // GET: Retailer
        //        //public ActionResult Index(RetailerDAL repository)
        //        //{
        //        //    return View(repository.ListRetailers());
        //        //}

        //        [HttpPost]
        //        [ValidateAntiForgeryToken]
        //        public ActionResult Index([Bind(Include = "RetailerID,Name,RetailerNumber,EmailID,Phone,AddressID")] Retailer retailer)
        //        {
        //            if (ModelState.IsValid)
        //            {
        //                //RetailerDAL create = new RetailerDAL();
        //                create.AddorUpdate(retailer);

        //                return View(create.ListRetailers());
        //            }

        //            //     ViewBag.AddressID = new SelectList(db.Addresses, "AddressID", "Address1", retailer.AddressID);
        //            return View(retailer);
        //        }

        //        [HttpPost]
        //        [ValidateAntiForgeryToken]
        //        public ActionResult Create([Bind(Include = "RetailerID,Name,RetailerNumber,EmailID,Phone,AddressID")] Retailer retailer)
        //        {
        //            if (ModelState.IsValid)
        //            {
        //                //RetailerDAL create = new RetailerDAL();
        //                create.AddorUpdate(retailer);
        //                return RedirectToAction("Index");
        //            }

        //            //      ViewBag.AddressID = new SelectList(db.Addresses, "AddressID", "Address1", retailer.AddressID);
        //            return View(retailer);

        //        }
        //    }
    }
}