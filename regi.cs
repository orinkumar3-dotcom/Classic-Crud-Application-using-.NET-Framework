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
    public partial class regi : Form
    {
        public regi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constring = "Data Source=localhost;Initial Catalog=orin;Integrated Security=True;TrustServerCertificate=True;";
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Please fill all fields");
                return;
            }
            if (textBox2.Text != textBox3.Text)
            {
                MessageBox.Show("Passwords do not match");
                return;
            }
            SqlConnection con = new SqlConnection(constring);
            string query = "INSERT INTO user_table(userid, password) VALUES (@userid, @password)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@userid", textBox1.Text); cmd.Parameters.AddWithValue("@password", textBox2.Text);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registration successful");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            login ty= new login();
            ty.Show();
            ty.Hide();
        }
    }
}
