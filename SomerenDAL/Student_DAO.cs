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
    public class Student_DAO : Base
    {
      
        public List<Student> Db_Get_All_Students()
        {
            string query = "SELECT student_id, student_name, birth_date FROM [Students]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public int DB_Get_Total_Customers(int Id)
        {
            string query = "";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            List<Student> students = ReadTables(ExecuteSelectQuery(query, sqlParameters));
            return students.Count();
        }

        private List<Student> ReadTables(DataTable dataTable)
        {
            List<Student> students = new List<Student>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Student student = new Student()
                {
                    Number = (int)dr["student_id"],
                    Name = (String)(dr["student_name"].ToString()),
                    BirthDate = (DateTime)(dr["birth_date"])
                };
                students.Add(student);
            }
            return students;
        }

    }
}
