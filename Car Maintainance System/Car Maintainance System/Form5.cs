using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Car_Maintainance_System
{
    public partial class Form5 : Form
    {
        private void populate()
        {
            string ConnectionString = "Data Source=AI-NOTEBOOK\\SQLEXPRESS;Initial Catalog=car_maintainance;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string query = "SELECT * FROM services";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            ServiceDataTable.DataSource = ds.Tables[0];
            con.Close();
        }
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm2 = new Form2();
            frm2.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label17_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 frm3 = new Form3();
            frm3.Show();
        }

        private void label18_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 frm6 = new Form6();
            frm6.Show();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 frm4 = new Form4();
            frm4.Show();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 frm5 = new Form5();
            frm5.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=AI-NOTEBOOK\\SQLEXPRESS;Initial Catalog=car_maintainance;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            try
            {
                string query = "INSERT INTO services VALUES ('" + sid.Text + "', '" + sname.Text + "', '" + sprice.Text + "');";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Service data entered successfully.");
                populate();
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=AI-NOTEBOOK\\SQLEXPRESS;Initial Catalog=car_maintainance;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string query = "UPDATE services SET s_name = '" + sname.Text + "', s_price = '" + sprice.Text + "' where s_id = '" + sid.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Record updated successfully");
            con.Close();
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string ConnectionString = "Data Source=AI-NOTEBOOK\\SQLEXPRESS;Initial Catalog=car_maintainance;Integrated Security=True";
                SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();
                string query = "DELETE FROM services where s_id = '" + sid.Text + "';";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record deleted successfully.");
                con.Close();
                populate();
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }
    }
}
