using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace stock_tracking_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-LRMEISB\SQLEXPRESS;Initial Catalog=Stock-Tracking;Integrated Security=True");

        void priceList()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from TBLBENZIN", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
