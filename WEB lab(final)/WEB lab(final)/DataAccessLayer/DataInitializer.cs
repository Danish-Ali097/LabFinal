using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WEB_lab_final_.Models;

namespace WEB_lab_final_.DataAccessLayer
{
    public class DataInitializer:DropCreateDatabaseIfModelChanges<DBContext>
    {
        public DataInitializer()
        {
            this.Seed(new DBContext());
        }
        protected override void Seed(DBContext context)
        {
            base.Seed(context);
            Tyres t = new Tyres() { Brand = "Dunlop", Country = "Pakistan", Size = "123/12/12", Condition = "new", Quantity = 2, Purchase_Price = 1000.0, Selling_Price = 1500.0 };
            Sales s = new Sales() { TyreId = 1, Quantity = 2, CustomerName = "Ali", TransitionDateTime = DateTime.Now.ToString(), CashReceived= 500.0  };
            context.Tyres.Add(t);
            context.Sales.Add(s);
            context.SaveChanges();
        }

    }
}