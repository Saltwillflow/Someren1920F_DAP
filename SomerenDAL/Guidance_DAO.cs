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
    public class Guidance_DAO : Base
    {
        
        public List<Guidance> Db_Get_All_Guidances()
        {
            string query = "SELECT Guidance.teacher_id,Teachers.teacher_name FROM Guidance INNER JOIN Teachers ON Guidance.teacher_id = Teachers.teacher_id";
            //string query = "SELECT teacher_id from GUIDANCE";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Guidance> DB_GET_ALL_NOT_Guidance()
        {
            string query = "SELECT T.teacher_id, T.teacher_name FROM Teachers T WHERE NOT EXISTS(select null from Guidance G where g.teacher_id = t.teacher_id)";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Guidance> ReadTables(DataTable dataTable)
        {
            List<Guidance> guidances = new List<Guidance>();


            foreach (DataRow dr in dataTable.Rows)
            {

                Guidance guidance = new Guidance()
                {
                   
                    TeacherName = (String)dr["teacher_name"].ToString(),
                    TeacherId = (int)(dr["teacher_id"])
                };
                guidances.Add(guidance);
            }
            return guidances;

        }

        public void Db_Delete_Guidance(Guidance g)
        {
            //Query Delete guidance voor table Guidance
            string query = "DELETE FROM Guidance WHERE teacher_id = @GuidanceId";
            SqlParameter[] sqlParameters =
            {
                 new SqlParameter("GuidanceId" , g.TeacherId),                 
            };
            //Uitvoering van de query
            ExecuteEditQuery(query, sqlParameters);
        }

        public void Db_Add_Guidance(Guidance g)
        {
            string query = "INSERT INTO Guidance(teacher_id) VALUES (@TeacherId)";
            SqlParameter[] sqlParameters =
            {
                 new SqlParameter("TeacherId" , g.TeacherId),
            };
            //Uitvoering van de query
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}