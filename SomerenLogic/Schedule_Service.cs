using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenLogic
{
    public class Schedule_Service
    {
        Schedule_DAO schedule_db = new Schedule_DAO();

        public List<Schedule> GetSchedule()
        {
            try
            {
                List<Schedule> schedule = schedule_db.Db_Get_Schedule();
                return schedule;
            }
            catch (Exception e)
            {
                //something went wrong connecting to the database, so we will add a fake schedule to the list to make sure the rest of the application continues working!
                System.Windows.Forms.MessageBox.Show(e.Message);
                List<Schedule> schedule = new List<Schedule>();
                Schedule s = new Schedule();
                s.Activity = "Test Activity";
                s.TeacherName = "Test Teacher";
                s.Date = "1/1/1970";
                s.StartTime = "00:00:00";
                s.EndTime = "00:00:00";

                //throw new Exception("Someren couldn't connect to the database");
                System.Windows.Forms.MessageBox.Show("Someren couldn't connect to the database");
                schedule.Add(s);
                return schedule;
            }

        }
    }
}
