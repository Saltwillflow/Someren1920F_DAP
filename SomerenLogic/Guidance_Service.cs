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
   public class Guidance_Service
    {        
        Guidance_DAO guidance_db = new Guidance_DAO();

        public List<Guidance> GetGuidances()
        {
            try
            {
                List<Guidance> guidance = guidance_db.Db_Get_All_Guidances();
                return guidance;
            }
            catch (Exception)
            {
                //something went wrong connecting to the database, so we will add a fake student to the list to make sure the rest of the application continues working!

                List<Guidance> guidance = new List<Guidance>();
                Guidance a = new Guidance();
                a.TeacherId = 3;

                guidance.Add(a);
                Guidance b = new Guidance();
                b.TeacherId = 2;

                //throw new Exception("Someren couldn't connect to the database");
                System.Windows.Forms.MessageBox.Show("Someren couldn't connect to the database");
                guidance.Add(a);
                return guidance;
            }
        }

        public List<Guidance> GetNotGuidance()
        {
            try
            {
                List<Guidance> teacher = guidance_db.DB_GET_ALL_NOT_Guidance();
                return teacher;
            }

            catch (Exception)
            {
                List<Guidance> guidance = new List<Guidance>();
                Guidance a = new Guidance();
                a.TeacherId = 3;

                guidance.Add(a);
                Guidance b = new Guidance();
                b.TeacherId = 2;

                //throw new Exception("Someren couldn't connect to the database");
                System.Windows.Forms.MessageBox.Show("Someren couldn't connect to the database");
                guidance.Add(a);
                return guidance;
            }
        }
    }
}