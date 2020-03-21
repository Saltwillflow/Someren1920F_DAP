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
    public class Register_DAO : Base
    {
        //Query update voor table Beverages
        public void Db_Update_Beverages(Beverage b)
        {
            string query = "UPDATE Beverages SET stock = stock -1, total_sold = total_sold +1 WHERE beverage_id =@Id; UPDATE beverages SET revenue = price * total_sold WHERE beverage_id =@Id";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("Id", b.Id)
            };
            //Uitvoering van de query
            ExecuteEditQuery(query, sqlParameters);
        }

        public void Db_Update_Beverages_Orders(Student s, Beverage b)
        {
            //Query update voor table BeverageOrders
            string query = "INSERT INTO  BeverageOrders(student_id, [date time], beverage_id) VALUES (@StudentId, @DateTime, @BeverageId) ";
            SqlParameter[] sqlParameters =
            {
                 new SqlParameter("StudentId" , s.Number),
                 new SqlParameter("DateTime", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:fff")),
                 new SqlParameter("BeverageId", b.Id)
            };
            //Uitvoering van de query
            ExecuteEditQuery(query, sqlParameters);
        }

    }
}