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
    public class Activities_DAO : Base
    {
        public List<Activity> Db_Get_All_Activities()
        {
            string query = "SELECT Activity_id, description, students_ammount, guidance_ammount FROM [Activity]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        
        private List<Activity> ReadTables(DataTable dataTable)
        {
            List<Activity> activities = new List<Activity>();

            foreach (DataRow dr in dataTable.Rows)
            {

                Activity activity = new Activity()
                {
                    Id = (int)(dr["activity_id"]),
                    Description = (String)(dr["description"].ToString()),
                    Students_Ammount = (int)(dr["students_ammount"]),
                    Guidance_Ammount = (int)(dr["guidance_ammount"]),
                    
                };
                
                activities.Add(activity);
            }
            return activities;
        }
    }
}
