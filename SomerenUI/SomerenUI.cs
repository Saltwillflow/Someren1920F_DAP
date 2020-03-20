using SomerenLogic;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SomerenUI
{
    public partial class SomerenUI : Form
    {
        public SomerenUI()
        {
            InitializeComponent();
        }

        private void SomerenUI_Load(object sender, EventArgs e)
        {
            showPanel("Dashboard");
        }

        private void showPanel(string panelName)
        {

            if(panelName == "Dashboard")
            {

                // hide all other panels
                pnl_Students.Hide();
                pnl_Lecturers.Hide();
                pnl_Room.Hide();
                pnl_Beverage.Hide();
                pnl_Register.Hide();

                // show dashboard
                pnl_Dashboard.Show();
                img_Dashboard.Show();
            }
            else if(panelName == "Students")
            {
                // hide all other panels
                pnl_Dashboard.Hide();
                img_Dashboard.Hide();
                pnl_Lecturers.Hide();
                pnl_Room.Hide();
                pnl_Beverage.Hide();
                pnl_Register.Hide();

                // show students
                pnl_Students.Show();
                pnl_Students.BringToFront();
                

                

                // fill the students listview within the students panel with a list of students

                
                SomerenLogic.Student_Service studService = new SomerenLogic.Student_Service();
                List<Student> studentList = studService.GetStudents();

                // clear the listview before filling it again
                listViewStudents.View = View.Details;
                listViewStudents.Clear();

                listViewStudents.Columns.Add("Id");
                listViewStudents.Columns.Add("First Name");
                listViewStudents.Columns.Add("Last Name");
                listViewStudents.Columns.Add("Birthdate");

                foreach (SomerenModel.Student s in studentList)
                {
                    ListViewItem li = new ListViewItem(s.Number.ToString());
                    var names = s.Name.Split(' ');
                    string firstName = names[0];
                    string lastName = "";
                    if (names.Count() > 0 && names[1] != null)
                    {
                        lastName = names[1];
                    }
                    li.SubItems.Add(firstName);
                    li.SubItems.Add(lastName);
                    li.SubItems.Add(s.BirthDate.ToString("dd/MM/yyyy"));
                    listViewStudents.Items.Add(li);
                }
                
                
            }
            else if (panelName == "Lecturers")
            {
                
                pnl_Dashboard.Hide();
                img_Dashboard.Hide();
                pnl_Students.Hide();
                pnl_Room.Hide();
                pnl_Beverage.Hide();
                pnl_Register.Hide();

                pnl_Lecturers.Show();
               // pnl_Lecturers.BringToFront();
                
                        
                SomerenLogic.Teacher_Service teachService = new SomerenLogic.Teacher_Service();
                List<Teacher> teacherList = teachService.GetTeachers();

                listViewTeachers.View = View.Details;

                // clear the listview before filling it again

                listViewTeachers.Clear();

                // Maakt collums aan

                listViewTeachers.Columns.Add("Id");
                listViewTeachers.Columns.Add("First name");
                listViewTeachers.Columns.Add("Last name");
                listViewTeachers.Columns.Add("Guidance");


                foreach (SomerenModel.Teacher t in teacherList)
                {

                    ListViewItem li = new ListViewItem(t.Number.ToString());
                    
                    //De naam splitsen naar voor naam en achter naam
                    var names = t.Name.Split(' ');
                    string firstName = names[0];
                    string lastName = "";
                    if (names.Count() > 0 && names[1] != null)
                    {
                        lastName = names[1];
                    }
                    li.SubItems.Add(firstName);
                    li.SubItems.Add(lastName);

                    //Bit naar duidelijke tekst
                    if (t.Guide == true)
                    {
                        li.SubItems.Add("Yes");
                    }
                    else
                    {
                        li.SubItems.Add("No");
                    }

                   
                    listViewTeachers.Items.Add(li);
                }
            }

            else if (panelName == "Rooms")
            {
                // hide all other panels
                pnl_Dashboard.Hide();
                img_Dashboard.Hide();
                pnl_Lecturers.Hide();
                pnl_Students.Hide();
                pnl_Beverage.Hide();
                pnl_Register.Hide();

                // show rooms
                pnl_Room.Show();



                // fill the rooms listview within the rooms panel with a list of rooms
                SomerenLogic.Room_Service romService = new SomerenLogic.Room_Service();
                List<Room> roomList = romService.GetRooms();
                listViewRooms.View = View.Details;

                // clear the listview before filling it again
                listViewRooms.Clear();

                listViewRooms.Columns.Add("Nummer");
                listViewRooms.Columns.Add("Type");
                listViewRooms.Columns.Add("Capaciteit");

                foreach (SomerenModel.Room s in roomList)
                {

                    ListViewItem li = new ListViewItem(s.Number.ToString());

                    if (s.Type == true)
                    {
                        li.SubItems.Add("Teachers' room");
                    }
                    else
                    {
                        li.SubItems.Add("Students' room");
                    }

                    li.SubItems.Add(s.Capacity.ToString());
                    listViewRooms.Items.Add(li);
                }

            }

            else if (panelName == "Beverages")
            {
                // hide all other panels
                pnl_Dashboard.Hide();
                img_Dashboard.Hide();
                pnl_Lecturers.Hide();
                pnl_Students.Hide();
                pnl_Rooms.Hide();
                pnl_Register.Hide();

                // show rooms
                pnl_Beverage.Show();
                

                // fill the rooms listview within the rooms panel with a list of rooms
                SomerenLogic.Beverage_Service bevService = new SomerenLogic.Beverage_Service();
                List<Beverage> beverageList = bevService.GetBeverages();
                listViewBeverages.View = View.Details;

                // clear the listview before filling it again
                listViewBeverages.Clear();

                listViewBeverages.Columns.Add("Id");
                listViewBeverages.Columns.Add("Name");
                listViewBeverages.Columns.Add("Price");
                listViewBeverages.Columns.Add("Alcoholic");
                listViewBeverages.Columns.Add("Total Sold");
                listViewBeverages.Columns.Add("Revenue");
                listViewBeverages.Columns.Add("Total Tax");
                listViewBeverages.Columns.Add("Stock");

                foreach (SomerenModel.Beverage s in beverageList)
                {

                    ListViewItem li = new ListViewItem(s.Id.ToString());
                    li.SubItems.Add(s.Name);
                    li.SubItems.Add(s.Price.ToString());

                    if (s.Alcoholic == true)
                    {
                        li.SubItems.Add("Alcoholic Beverage");
                    }
                    else
                    {
                        li.SubItems.Add("Non Alcoholic Beverage");
                    }

                    li.SubItems.Add(s.TotalSold.ToString());
                    li.SubItems.Add(s.Revenue.ToString());
                    li.SubItems.Add(s.TotalTax.ToString());
                    li.SubItems.Add(s.Stock.ToString());
                    listViewBeverages.Items.Add(li);
                }

            }

            else if (panelName == "Register")
            {
                // hide all other panels
                pnl_Dashboard.Hide();
                img_Dashboard.Hide();
                pnl_Lecturers.Hide();
                pnl_Students.Hide();
                pnl_Rooms.Show();
                pnl_Beverage.Hide();

                // show rooms
                pnl_Register.Show();

                listViewRegisterB.View = View.Details;
                listViewRegisterB.Clear();
                listViewRegisterB.Columns.Add("Beverage ID");
                listViewRegisterB.Columns.Add("Name");
                listViewRegisterB.Columns.Add("Price");
                listViewRegisterB.Columns.Add("Stock");

                SomerenLogic.Beverage_Service becService = new SomerenLogic.Beverage_Service();
                List<Beverage> beverageList = becService.GetBeverages();

                foreach (SomerenModel.Beverage b in beverageList)
                {
                    ListViewItem li = new ListViewItem(b.Id.ToString());
                    li.Tag = b;
                    li.SubItems.Add(b.Name);
                    li.SubItems.Add(b.Price.ToString());
                    li.SubItems.Add(b.Stock.ToString());
                    listViewRegisterB.Items.Add(li);

                }

                listViewRegister.View = View.Details;

                // clear the listview before filling it again
                listViewRegister.Clear();

                listViewRegister.Columns.Add("Id");
                listViewRegister.Columns.Add("Student name");

                SomerenLogic.Student_Service studService = new SomerenLogic.Student_Service();
                List<Student> studentList = studService.GetStudents();


                foreach (SomerenModel.Student s in studentList)
                {
                    ListViewItem li = new ListViewItem(s.Number.ToString());
                    li.Tag = s;
                    li.SubItems.Add(s.Name);
                    listViewRegister.Items.Add(li);
                }

            }

        }

        

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
           //
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dashboardToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            showPanel("Dashboard");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void img_Dashboard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("What happens in Someren, stays in Someren!");
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            showPanel("Students");
        }

        private void LecturersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Lecturers");
           
        }


        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void RoomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Rooms");
        }

        private void Pnl_Room_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BeveragesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Beverages");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_UpdateDatabase_Click(object sender, EventArgs e)
        {
            
            SomerenUpdate f2 = new SomerenUpdate();
            f2.ShowDialog();
            showPanel("Beverages");
        }

        private void RegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Register");
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            double prijs = 0;
            int i = 0;
            if (listViewRegisterB.SelectedItems.Count == 0)
            {
                return;
            }
            

            //Gaat elk geselecteerde Item langs 
            foreach (object dranken in listViewRegisterB.SelectedItems)
            {
                SomerenModel.Beverage b = (SomerenModel.Beverage)listViewRegisterB.SelectedItems[i].Tag;
                SomerenModel.Student s = (SomerenModel.Student)listViewRegister.SelectedItems[0].Tag;
                prijs += (double)b.Price;
                i = +1;
                SomerenDAL.Register_DAO registerDaoS = new SomerenDAL.Register_DAO();
                SomerenDAL.Register_DAO registerDaob = new SomerenDAL.Register_DAO();
                registerDaob.Db_Update_Beverages(b);
                registerDaoS.Db_Update_Beverages_Orders(s, b);
            }
            //Berekent totaal prijs
            MessageBox.Show($"Total cost: {prijs.ToString("0.00")}");

        }
    }
}
