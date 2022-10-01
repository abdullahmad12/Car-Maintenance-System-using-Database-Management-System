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
    public partial class Form3 : Form
    {
        private void populate()
        {
            string ConnectionString = "Data Source=AI-NOTEBOOK\\SQLEXPRESS;Initial Catalog=car_maintainance;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string query = "SELECT * FROM employee";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            EmpDataTable.DataSource = ds.Tables[0];
            con.Close();
        }
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=AI-NOTEBOOK\\SQLEXPRESS;Initial Catalog=car_maintainance;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            try
            {
                string query = "INSERT INTO employee VALUES('" + eid.Text + "', '" + ename.Text + "', '" + egender.Text + "', '" + eph.Text + "', '" + esalary.Text + "', '" + eage.Text + "', '" + ecnic.Text + "', '" + equalification.Text + "', '" + edojoining.Text + "', '" + eposition.Text + "', '" + eaddress.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee data entered successfully.");
                populate();
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
            con.Close();
        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=AI-NOTEBOOK\\SQLEXPRESS;Initial Catalog=car_maintainance;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string query = "UPDATE employee SET emp_name = '" + ename.Text + "', emp_contact = '" + eph.Text + "', emp_salary = '" + esalary.Text + "', emp_gender = '" + egender.Text + "', emp_age = '" + eage.Text + "', emp_qualification = '" + equalification.Text + "', emp_position = '" + eposition.Text + "', emp_address = '" + eaddress.Text + "', emp_cnic = '" + ecnic.Text + "' where emp_id = '" + eid.Text + "'";
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
                string query = "DELETE FROM employee where emp_id = '" + eid.Text + "';";
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

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 frm6 = new Form6();
            frm6.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 frm4 = new Form4();
            frm4.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 frm5 = new Form5();
            frm5.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm2 = new Form2();
            frm2.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
