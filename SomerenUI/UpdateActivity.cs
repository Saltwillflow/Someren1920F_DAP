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
    public partial class UpdateActivity : Form
    {
        private SqlConnection _con;
        private SqlCommand _cmd;

        public UpdateActivity()
        {
            InitializeComponent();
        }

        private void btn_AddAct_Click(object sender, EventArgs e)
        {
            _con = new SqlConnection(ConfigurationManager.ConnectionStrings["SomerenDatabase"].ConnectionString);
            _con.Open();
            _cmd = new SqlCommand("UPDATE Activity SET description=@a13 , students_ammount=@a14 , guidance_ammount=@a15 WHERE activity_id=@a12", _con);
            _cmd.Parameters.AddWithValue("a12", txtb_Id.Text);
            _cmd.Parameters.AddWithValue("a13", txtb_Description.Text);
            _cmd.Parameters.AddWithValue("a14", txtb_StudentsAmmount.Text);
            _cmd.Parameters.AddWithValue("a15", txtb_GuidanceAmmount.Text);
            _cmd.ExecuteNonQuery();

            this.Hide();
        }

        private void txtb_Description_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtb_StudentsAmmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtb_GuidanceAmmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtb_Id_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_GuidanceAmmount_Click(object sender, EventArgs e)
        {

        }

        private void lbl_StudentAmmount_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Description_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Id_Click(object sender, EventArgs e)
        {

        }
    }
}
