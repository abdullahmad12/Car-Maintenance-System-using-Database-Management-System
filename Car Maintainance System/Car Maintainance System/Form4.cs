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
    public partial class Form4 : Form
    {
        private void populate()
        {
            string ConnectionString = "Data Source=AI-NOTEBOOK\\SQLEXPRESS;Initial Catalog=car_maintainance;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string query = "SELECT * FROM customer";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            CustomerDataTable.DataSource = ds.Tables[0];
            con.Close();
        }
        public Form4()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=AI-NOTEBOOK\\SQLEXPRESS;Initial Catalog=car_maintainance;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            try
            {
                string query = "INSERT INTO customer VALUES('" + cid.Text + "', '" + cname.Text + "', '" + ccontact.Text + "', '" + cemail.Text + "', '" + caddress.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer data entered successfully.");
                populate();
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
            con.Close();
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=AI-NOTEBOOK\\SQLEXPRESS;Initial Catalog=car_maintainance;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string query = "UPDATE costumer SET c_name = '" + cname.Text + "', c_contact = '" + ccontact.Text + "', c_email = '" + cemail.Text + "', c_address = '" + caddress.Text + "' where c_id = '" + cid.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Record updated successfully");
            con.Close();
            populate();
        }

        private void edeletebtn_Click(object sender, EventArgs e)
        {
            try
            {
                string ConnectionString = "Data Source=AI-NOTEBOOK\\SQLEXPRESS;Initial Catalog=car_maintainance;Integrated Security=True";
                SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();
                string query = "DELETE FROM costumer where c_id = '" + cid.Text + "';";
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

        private void label15_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 frm5 = new Form5();
            frm5.Show();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 frm6 = new Form6();
            frm6.Show();
        }

        private void label17_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 frm3 = new Form3();
            frm3.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CustomerDataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm2 = new Form2();
            frm2.Show();
        }
    }
}
