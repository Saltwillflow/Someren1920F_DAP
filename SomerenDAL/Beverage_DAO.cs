using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;
using SomerenModel;


namespace SomerenDAL
{
    public class Beverage_DAO : Base
    {
        public List<Beverage> Db_Get_All_Beverages()
        {
            string query = "SELECT * FROM [Beverages]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public int DB_Get_Total_Sold(int Id)
        {
            string query = "SELECT COUNT(*) AS [total sold] FROM BeverageOrders AS BO JOIN Beverages AS B ON BO.beverage_id = " + Id;
            SqlParameter[] sqlParameters = new SqlParameter[0];
            List<Beverage> order = ReadTables(ExecuteSelectQuery(query, sqlParameters));
            return 0;
        }

        private List<Beverage> ReadTables(DataTable dataTable)
        {
            List<Beverage> beverages = new List<Beverage>();

            foreach (DataRow dr in dataTable.Rows)
            {
                int totalSoldNullCheck = 0;
                if (!dr.IsNull("total_sold"))
                {
                    totalSoldNullCheck = (int)(dr["total_sold"]);
                }

                int stockNullCheck = 0;
                if (!dr.IsNull("total_sold"))
                {
                    stockNullCheck = (int)(dr["stock"]);
                }

                Beverage beverage = new Beverage()
                {
                    Id = (int)(dr["beverage_id"]),
                    Name = (String)(dr["beverage_name"].ToString()),
                    Price = (Decimal)(dr["price"]),
                    Alcoholic = (bool)(dr["alcoholic"]),
                    TotalSold = totalSoldNullCheck,
                    Stock = stockNullCheck
                };
                beverages.Add(beverage);
            }
            return beverages;
        }
    }
}
