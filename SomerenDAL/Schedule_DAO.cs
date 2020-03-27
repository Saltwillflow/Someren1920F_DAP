using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenDAL
{
    public class Schedule_DAO : Base
    {
        public List<Schedule> Db_Get_Schedule()
        {
            string query = "SELECT T.teacher_id AS A, T.teacher_name AS B, AC.[description] AS C, [date] AS D, start_time AS E, end_time AS F " + 
                "FROM Schedule AS S " +
                "JOIN Activity AS AC ON S.activity = AC.activity_id " +
                "JOIN Guidance AS G ON S.guidance = G.teacher_id " +
                "JOIN Teachers as T ON G.teacher_id = T.teacher_id " +
                "ORDER BY [date], start_time";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Schedule> ReadTables(DataTable dataTable)
        {
            List<Schedule> schedule = new List<Schedule>();

            foreach (DataRow dr in dataTable.Rows)
            {
                string teacherName;
                if (int.Parse((dr["A"]).ToString()) == 0)
                {
                    teacherName = "Onbegeleid";
                } else teacherName = (dr["B"]).ToString();

                Schedule scheduleItem = new Schedule()
                {
                    TeacherName = teacherName,
                    Activity = (string)(dr["C"]),
                    Date = (dr["D"]).ToString(),
                    StartTime = (dr["E"]).ToString(),
                    EndTime = (dr["F"]).ToString()
                };
                schedule.Add(scheduleItem);
            }
            return schedule;
        }
    }
}
