using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LoginUpdate
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=localhost;Initial Catalog=orin;Integrated Security=True;TrustServerCertificate=True";
            con.Open();
            string userid = textBox1.Text; string password = textBox2.Text;
            SqlCommand cmd = new SqlCommand(
                "SELECT userid, password FROM user_table WHERE userid=@userid AND password=@password", con);
            cmd.Parameters.AddWithValue("@userid", userid); cmd.Parameters.AddWithValue("@password", password);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                //MessageBox.Show("Login Success! Welcome"); // cutlam jeno direct crud e niye jay 

                Form1 f = new Form1();  // after login crud e niye jabe 
                f.FormClosed += (s, args) =>
                {
                    Application.Exit();
                };
                f.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Login. Please check userid and password");
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            regi rg= new regi();
            rg.Show();
            this.Hide();
        }
    }
}
