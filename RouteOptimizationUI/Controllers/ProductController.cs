using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RouteOptimization.Infrastructure;

namespace RouteOptimizationUI.Controllers
{   
    public class ProductController : Controller
    {

        public ActionResult Index(ProductDAL repository)
        {
            return View(repository.ListProducts());
        }



        
        // GET: Product
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index([Bind(Include = "ProductID,Name,ProductNumber,ListPrice,Size,Weight")] Product product)
        {
            if (ModelState.IsValid)
            {
                ProductDAL create = new ProductDAL();
                create.AddorUpdate(product);
                return View("Index", create.ListProducts());
            }

            return View(product);
            
            
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Product/Create
        public ActionResult Create(ProductDAL product)
        {
            return View(product.ListProducts());
        }

        // POST: Product/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="ProductID,Name,ProductNumber,ListPrice,Size,Weight")] Product product)
        {
            if (ModelState.IsValid)
            {
                ProductDAL create = new ProductDAL();
                create.AddorUpdate(product);
                return RedirectToAction("Index");
            }

            return View(product);
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
