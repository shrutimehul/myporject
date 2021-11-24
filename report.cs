using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ShopBridge
{
    public partial class report : Form
    {
        public report()
        {
            InitializeComponent();
        }

        private void report_Load(object sender, EventArgs e)
        {
            SqlConnection con2 = new SqlConnection(@"Data Source=.;Initial Catalog=ShopBridge;Integrated Security=True");
            con2.Open();
            SqlDataAdapter adpt = new SqlDataAdapter("select *from inventory", con2);
            DataTable dtb = new DataTable();
            adpt.Fill(dtb);
            dataGridView1.DataSource = dtb;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            inventory inven = new inventory();
            inven.Show();
        }
    }
}
