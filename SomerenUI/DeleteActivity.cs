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
    public partial class DeleteActivity : Form
    {
        private SqlConnection _con;
        private SqlCommand _cmd;

        public DeleteActivity()
        {
            InitializeComponent();
        }

        private void btn_UpdateAct_Click(object sender, EventArgs e)
        {
            _con = new SqlConnection(ConfigurationManager.ConnectionStrings["SomerenDatabase"].ConnectionString);
            _con.Open();
            _cmd = new SqlCommand("DELETE FROM Activity WHERE activity_id=@a13", _con);
            _cmd.Parameters.AddWithValue("a13", txtb_Id.Text);
            _cmd.ExecuteNonQuery();

            this.Hide();
        }
    }
}
