using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RouteOptimizationUI.Models;

namespace RouteOptimizationUI.Controllers
{
    public class StoresController : Controller
    {
        // GET: Stores
        
        
        public ActionResult Index(Store st)
        {
            //Store st = new Store();

            //st.Name = Request["storename"];
            //st.Contact = Request["contactperson"];
            //st.Phone = Request["phone"];
            
            _storeslist.Add(st);

   
            var model =
                from r in _storeslist
               
                select r;

            return View(model);
        }

        // GET: Stores/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Stores/Create
        public ActionResult Create()
        {

            // index page ( using ajax and partial view )

            return View();
        }

        // POST: Stores/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Stores/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Stores/Edit/5
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

        // GET: Stores/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Stores/Delete/5
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

        

        static List<Store> _storeslist = new List<Store>
        {
            new Store{
                StoreID = 1, 
                Name = "Walmart1"
                       
            },
             new Store{
                   StoreID = 2, 
                Name = "LobLaws"
              
        
            },
             new Store{
                   StoreID = 3, 
                Name = "Asian"
                
        
            }


        };
    }
}
