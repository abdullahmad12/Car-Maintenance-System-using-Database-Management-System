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
    public partial class Form6 : Form
    {
        private void populate()
        {
            string ConnectionString = "Data Source=AI-NOTEBOOK\\SQLEXPRESS;Initial Catalog=car_maintainance;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string query = "SELECT * FROM part";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            RepairDataTable.DataSource = ds.Tables[0];
            con.Close();
        }
        public Form6()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm2 = new Form2();
            frm2.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
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

        private void Form6_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=AI-NOTEBOOK\\SQLEXPRESS;Initial Catalog=car_maintainance;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            try
            {
                string query = "INSERT INTO part VALUES ('" + pid.Text + "', '" + pname.Text + "', '" + pprice.Text + "');";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Repair data entered successfully.");
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
            string query = "UPDATE part SET p_name = '" + pname.Text + "', p_price = '" + pprice.Text + "' where p_id = '" + pid.Text + "'";
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
                string query = "DELETE FROM part where p_id = '" + pid.Text + "';";
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
