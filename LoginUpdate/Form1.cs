using System;
using System.Data;
using System.Data.Common;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace LoginUpdate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        //connection string
        string constring = "Data Source=localhost;Initial Catalog=orin;Integrated Security=True;TrustServerCertificate=True";

        private void button1_Click(object sender, EventArgs e)   // insert/login
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO log_Table(id,name,age) VALUES(@id, @name,@age)", con);
            cmd.Parameters.AddWithValue("@id", int.Parse(IDtb.Text));
            cmd.Parameters.AddWithValue("@name", Nametb.Text);  //typecast korlam na, name string ee ache
            cmd.Parameters.AddWithValue("@age", double.Parse(Agetb.Text));
            cmd.ExecuteNonQuery(); //sob value ache kina eijonno
            con.Close();

            MessageBox.Show("Insert Successfully");
        }

        private void button2_Click(object sender, EventArgs e) // update
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE log_Table SET name=@name,age=@age WHERE id=@id", con);//id change hoina,tai (WHERE) bolte hobe kon id.
            cmd.Parameters.AddWithValue("@id", int.Parse(IDtb.Text));
            cmd.Parameters.AddWithValue("@name", Nametb.Text);
            cmd.Parameters.AddWithValue("@age", double.Parse(Agetb.Text));
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Update Successfully");
        }

        private void button3_Click(object sender, EventArgs e) // delete
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM log_Table WHERE id=@id", con);
            cmd.Parameters.AddWithValue("@id", int.Parse(IDtb.Text));
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Delete Successfully");
        }

        private void button4_Click(object sender, EventArgs e) // search
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM log_Table WHERE id=@id", con);
            cmd.Parameters.AddWithValue("@id", int.Parse(IDtb.Text));
            SqlDataAdapter adp = new SqlDataAdapter(cmd);  // for bridge between (search result) and our data table
            DataTable dt = new DataTable(); //data gula table theke nibo tai dilam
            adp.Fill(dt); // search result data table theke fillup hoi ejonno [ adp.fill(dt) ] (adp declare korechi bridge.)

            dataGridView1.DataSource = dt; // kothay fill korbe data gula,data table e(dt declare korechi-- data table)
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
