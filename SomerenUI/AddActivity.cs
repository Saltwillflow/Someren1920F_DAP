using System;
using System.Collections.Generic;
using SomerenLogic;
using SomerenModel;
using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SomerenUI
{
    public partial class AddActivity : Form
    {
        private SqlConnection _con;
        private SqlCommand _cmd;
        

        public AddActivity()
        {
            InitializeComponent();
        }

        private void btn_UpdateAct_Click(object sender, EventArgs e)
        {
            _con = new SqlConnection(ConfigurationManager.ConnectionStrings["SomerenDatabase"].ConnectionString);
            _con.Open();
            _cmd = new SqlCommand("INSERT INTO Activity (description, students_ammount, guidance_ammount) VALUES (@a9 ,@a10 ,@a11)", _con);
            _cmd.Parameters.AddWithValue("a9", txtb_Description.Text);
            _cmd.Parameters.AddWithValue("a10", txtb_StudentsAmmount.Text);
            _cmd.Parameters.AddWithValue("a11", txtb_GuidanceAmmount.Text);
            _cmd.ExecuteNonQuery();

            this.Hide();
        }
    }
}
