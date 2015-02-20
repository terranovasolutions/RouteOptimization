using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteOptimization.Infrastructure
{
   public class RetailerDAL
    {
        RouteOptimizationDBEntities db = new RouteOptimizationDBEntities();

        public IEnumerable<Retailer> ListRetailers()
        {
            return db.Retailers.ToList();
        }


        public Retailer GetProductById(int retailerId)
        {
            var result = (from retailer in db.Retailers
                          where retailer.RetailerID == retailerId
                          select retailer).FirstOrDefault<Retailer>();
            if (result != null)
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        public IEnumerable<Retailer> AddorUpdate(Retailer retailer)
        {
            if (retailer.RetailerID > 0)
            {
                Retailer pid = this.GetProductById(retailer.RetailerID);
                db.Entry(pid).CurrentValues.SetValues(retailer);
            }
            else
            {
                db.Retailers.Add(retailer);
            }
            db.SaveChanges();
            return db.Retailers.ToList();
        }

        public void Delete(int id)
        {
            var temp = (from x in db.Retailers
                        where x.RetailerID == id
                        select x).FirstOrDefault();
            db.Retailers.Remove(temp);
            db.SaveChanges();
        }
    }
}
