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
            string query = "SELECT guidance_id, activity, teacher_id FROM Guidance";
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
                    GuidanceId = (int)dr["guidance_id"],
                    Activity = (String)dr["activity"],
                    TeacherId = (int)(dr["teacher_id"])
                };
                guidances.Add(guidance);
            }
            return guidances;

        }

        public void Db_Delete_Guidance(Guidance g)
        {
            //Query Delete guidance voor table Guidance
            string query = "DELETE FROM Guidance WHERE guidance_id = @GuidanceId";
            SqlParameter[] sqlParameters =
            {
                 new SqlParameter("GuidanceId" , g.GuidanceId),                 
            };
            //Uitvoering van de query
            ExecuteEditQuery(query, sqlParameters);
        }

        public void Db_Add_Guidance(Guidance g)
        {
            string query = "INSERT INTO Guidance(guidance_id, activity, teacher_id) VALUES (@GuidanceId, @Activity, @TeacherId)";
            SqlParameter[] sqlParameters =
            {
                 new SqlParameter("GuidanceId" , g.GuidanceId),
                 new SqlParameter("Activity" , g.Activity),
                 new SqlParameter("TeacherId" , g.TeacherId),
            };
            //Uitvoering van de query
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}