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
    public class Activity_Service
    {
        Activities_DAO activity_db = new Activities_DAO();

        public List<Activity> GetActivities()
        {
            try
            {
                List<Activity> activity = activity_db.Db_Get_All_Activities();
                return activity;
            }
            catch (Exception)
            {
                //something went wrong connecting to the database, so we will add a fake student to the list to make sure the rest of the application continues working!

                List<Activity> activities = new List<Activity>();
                Activity a = new Activity();
                a.Id = 1;
                a.Description = "test 1";
                a.Students_Ammount = 30;
                a.Guidance_Ammount = 2;
                activities.Add(a);
                Activity b = new Activity();
                a.Id = 2;
                a.Description = "test 2";
                a.Students_Ammount = 30;
                a.Guidance_Ammount = 2;
                activities.Add(a);

                //throw new Exception("Someren couldn't connect to the database");
                System.Windows.Forms.MessageBox.Show("Someren couldn't connect to the database");
                activities.Add(a);
                return activities;
            }
        }
    }
}