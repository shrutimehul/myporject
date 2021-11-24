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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=ShopBridge;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select *from login where uname=@uname and password=@password", con);
            cmd.Parameters.AddWithValue("@uname", textBox1.Text);
            cmd.Parameters.AddWithValue("@password", textBox2.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            inventory frm2 = new inventory();
            if (dt.Rows.Count > 0)
            {
                
                frm2.Show();
            }
            else
            {
                label5.Text = "Please Check Your username or password";
                label5.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
