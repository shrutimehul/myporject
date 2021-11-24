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
    public partial class inventory : Form
    {
        public inventory()
        {
            InitializeComponent();
        }

        private void inventory_Load(object sender, EventArgs e)
        {
            
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=ShopBridge;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into inventory (inum,iname,qty,prz)values(@inum,@iname,@qty,@prz)", con);
                cmd.Parameters.AddWithValue("@inum", textBox1.Text);
                cmd.Parameters.AddWithValue("@iname", textBox2.Text);
                cmd.Parameters.AddWithValue("@qty", textBox3.Text);
                cmd.Parameters.AddWithValue("@prz", textBox4.Text);
                
                int i = cmd.ExecuteNonQuery();
                con.Close();
                if (i != 0)
                {
                    MessageBox.Show(i + "Record Save Successfully");
                }
            }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=ShopBridge;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("update inventory set iname='"+textBox2.Text+"' where inum='" + textBox1.Text + "'", con);

            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (i != 0)
            {
                MessageBox.Show(i + "Record Upated Successfully");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=ShopBridge;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from inventory where inum='"+textBox1.Text+"'" ,con);
            
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (i != 0)
            {
                MessageBox.Show(i + "Record Deleted Successfully");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            report frm = new report();
            frm.Show();

           

           
           
        }
            
        }

}
