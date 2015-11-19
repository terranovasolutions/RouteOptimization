using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RouteOptimization.Infrastructure;

namespace RouteOptimizationUI.Controllers
{     
    public class ProductController : Controller
    {
        private RouteOptimizationDBEntities db = new RouteOptimizationDBEntities();
        // GET: /Products/
        public ActionResult Index(ProductViewModel product)
        {
            ProductDAL pd = new ProductDAL();
            product.AllProducts = pd.ListProducts();
            return View(product);
        }

        
        public ActionResult GetProductList()
        {
            ProductViewModel product = new ProductViewModel();
            ProductDAL pd = new ProductDAL();
            product.AllProducts = pd.ListProducts();
            return PartialView("_Product",product.AllProducts.ToList());
        }


        //public ActionResult Create()
        //{
        //    ProductViewModel product = new ProductViewModel();
        //    ProductDAL create = new ProductDAL();
        //    create.AddorUpdate(prod);
        //    product.AllProducts = create.ListProducts();
        //    return PartialView("_Product",product);
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "ProductID,Name,ProductNumber,ListPrice,Size,Weight")] Product product)
        //{
        //    ProductDAL create = new ProductDAL();
        //    create.AddorUpdate(product);
        //    return RedirectToAction("Index");
        //}

        public ActionResult Edit(String ProductID)
        {
            ProductDAL data = new ProductDAL();
            ProductViewModel prod = new ProductViewModel();
            prod.Product = data.GetProductById(Convert.ToInt32(ProductID));
            if(Request.IsAjaxRequest())
            {
                return PartialView("_ProductForm", prod.Product);
            }
            else
            {
                return PartialView("_ProductForm", prod.Product);
            }
            
        }
        //public ActionResult Edit([Bind(Include = "ProductID,Name,ProductNumber,ListPrice,Size,Weight")] Product product)
        //{
        //    ProductViewModel prod = new ProductViewModel();
        //    ProductDAL pd = new ProductDAL();
        //    prod.AllProducts = pd.ListProducts();
        //    prod.Product = product;
        //    return PartialView("Index",prod);
        //}

        // GET: /Products/Delete
        public ActionResult Delete(int id)
        {
            ProductDAL product = new ProductDAL();
            product.Delete(id);
            return RedirectToAction("Index");
        }

        public void Save(String ProductID, String Name, String ProductNumber, String ListPrice, String Size, String Weight)
        {
            ProductViewModel product = new ProductViewModel();
            ProductDAL create = new ProductDAL();
            Product prod = new Product();
            if (ProductID != null)
            {
                prod.ProductID = Convert.ToInt32(ProductID);
            }
            prod.Name = Name;
            prod.ProductNumber = ProductNumber;
            prod.ListPrice = Convert.ToDecimal(ListPrice);
            prod.Size = Size;
            prod.Weight = Weight;
            create.AddorUpdate(prod);
            product.Product = prod;

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
