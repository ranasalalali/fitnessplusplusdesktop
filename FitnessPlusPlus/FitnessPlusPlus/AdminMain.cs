using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FitnessPlusPlus
{
     public partial class AdminMain : Form
     {
          SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\Documents\Visual Studio 2015\Projects\FitnessPlusPlus\FitnessPlusPlus\FitnessPlusPlus.mdf;Integrated Security=True;Connect Timeout=30");
          SqlDataAdapter sda;
          SqlCommandBuilder scb;
          DataTable dt;
          public AdminMain()
          {
               InitializeComponent();
          }

          private void AdminMain_Load(object sender, EventArgs e)
          {
               // TODO: This line of code loads data into the 'fitnessPlusPlusDataSet1.Doctor' table. You can move, or remove it, as needed.
               this.doctorTableAdapter.Fill(this.fitnessPlusPlusDataSet1.Doctor);
          }

         
          private void button1_Click(object sender, EventArgs e)
          {
               con.Close();
               con.Open();
               SqlCommand cmd = con.CreateCommand();
               cmd.CommandText = "insert into RegisteredDoctor values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + comboBox2.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "')";
               cmd.ExecuteNonQuery();
               cmd = con.CreateCommand();
               cmd.CommandText = "delete from Doctor where username = '" + textBox1.Text + "'";
               cmd.ExecuteNonQuery();
               sda = new SqlDataAdapter(@"select * from Doctor", con);
               dt = new DataTable();
               sda.Fill(dt);
               dataGridView1.DataSource = dt;
               con.Close();
               MessageBox.Show("Doctor Added to Database!");
          }

          private void button2_Click(object sender, EventArgs e)
          {
               con.Close();
               con.Open();
               SqlCommand cmd = con.CreateCommand();
               cmd.CommandText = "delete from Doctor where username = '"+textBox1.Text+"'";
               cmd.ExecuteNonQuery();
               this.doctorTableAdapter.Fill(this.fitnessPlusPlusDataSet1.Doctor);
               sda = new SqlDataAdapter(@"select * from Doctor", con);
               dt = new DataTable();
               sda.Fill(dt);
               dataGridView1.DataSource = dt;
               con.Close();
               MessageBox.Show("Doctor Requested Rejected!");
          }

          private void button3_Click(object sender, EventArgs e)
          {
               this.Hide();
               Login l = new Login();
               l.Show();
          }

          private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
          {
               textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
               textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
               textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
               comboBox2.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
               textBox5.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
               textBox6.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
               textBox7.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
               textBox8.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
               textBox9.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
          }
     }
}
