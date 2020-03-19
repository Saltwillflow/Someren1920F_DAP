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
    public partial class SomerenUpdate : Form
    {
        private SqlConnection _con;
        private SqlCommand _cmd;

        public SomerenUpdate()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void rdb_AlcoholicTrue_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Id_Click(object sender, EventArgs e)
        {

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            _con = new SqlConnection(ConfigurationManager.ConnectionStrings["SomerenDatabase"].ConnectionString);
            _con.Open();
            _cmd = new SqlCommand("UPDATE Beverages SET beverage_name=@a2 , price=@a3 , stock=@a4 , alcoholic=@a5 , total_sold=@a6 , revenue=@a7 , total_tax=@a8 WHERE beverage_id=@a1",_con);
            _cmd.Parameters.Add("a1", txt_Id.Text);
            _cmd.Parameters.Add("a2",txt_Name.Text);
            _cmd.Parameters.Add("a3", txt_Price.Text);
            _cmd.Parameters.Add("a4", txt_Stock.Text);
            if (rdb_AlcoholicTrue.Checked)
            {
                _cmd.Parameters.Add("a5", true);
            }

            else //(rdb_AlcoholicFalse.Checked)
            {
                _cmd.Parameters.Add("a5", false);
            }
            _cmd.Parameters.Add("a6", txt_TotalSold.Text);
            _cmd.Parameters.Add("a7", txt_Revenue.Text);
            _cmd.Parameters.Add("a8", txt_TotalTax.Text);
            _cmd.ExecuteNonQuery();

            this.Hide();
           


        }
    }
}
