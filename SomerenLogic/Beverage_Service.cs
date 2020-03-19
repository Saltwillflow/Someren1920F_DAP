using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SomerenLogic
{
   public class Beverage_Service
    {
        Beverage_DAO beverage_db = new Beverage_DAO();

        public List<Beverage> GetBeverages()
        {
            try
            {
                List<Beverage> beverage = beverage_db.Db_Get_All_Beverages();
                return beverage;
            }
            catch (Exception)
            {
                //something went wrong connecting to the database, so we will add a fake student to the list to make sure the rest of the application continues working!

                List<Beverage>beverage = new List<Beverage>();
                Beverage a = new Beverage();
                a.Id = 1;
                a.Name = "Test Drank 1";
                a.Price = 4.99M;
                a.TotalSold = 42;
                a.Revenue = 1000;
                a.TotalTax = 100.99M;
                a.Stock = 100;
                beverage.Add(a);
                Beverage b = new Beverage();
                a.Id = 2;
                a.Name = "Test Drank 2";
                a.Price = 5.99M;
                a.TotalSold = 13;
                a.Revenue = 2000;
                a.TotalTax = 222.99M;
                a.Stock = 200;

                //throw new Exception("Someren couldn't connect to the database");
                System.Windows.Forms.MessageBox.Show("Someren couldn't connect to the database");
                beverage.Add(a);
                return beverage;
            }

        }
    }
}