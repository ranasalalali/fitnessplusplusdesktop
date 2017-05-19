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
     public partial class Diagnose : Form
     {
          SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\Documents\Visual Studio 2015\Projects\FitnessPlusPlus\FitnessPlusPlus\FitnessPlusPlus.mdf;Integrated Security=True;Connect Timeout=30");
          SqlDataAdapter sda;
          SqlCommandBuilder scb;
          DataTable dt;
          public static String disease;
          public Diagnose()
          {
               InitializeComponent();
          }

          private void Diagnose_Load(object sender, EventArgs e)
          {
               // TODO: This line of code loads data into the 'fitnessPlusPlusDataSet5.Symptoms' table. You can move, or remove it, as needed.
               this.symptomsTableAdapter1.Fill(this.fitnessPlusPlusDataSet5.Symptoms);
               // TODO: This line of code loads data into the 'fitnessPlusPlusDataSet5.Symptoms' table. You can move, or remove it, as needed.
               this.symptomsTableAdapter1.Fill(this.fitnessPlusPlusDataSet5.Symptoms);
               // TODO: This line of code loads data into the 'fitnessPlusPlusDataSet4.Symptoms' table. You can move, or remove it, as needed.
               this.symptomsTableAdapter.Fill(this.fitnessPlusPlusDataSet4.Symptoms);
               con.Open();
               sda = new SqlDataAdapter(@"select * from Symptoms", con);
               dt = new DataTable();
               sda.Fill(dt);
               dataGridView1.DataSource = dt;
               con.Close();

          }

          private void button5_Click(object sender, EventArgs e)
          {

          }

          private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
          {
               con.Close();
               con.Open();
               sda = new SqlDataAdapter(@"select * from Symptoms where Symptom = '"+ dataGridView1.SelectedRows[0].Cells[0].Value.ToString()+"' ", con);
               dt = new DataTable();
               sda.Fill(dt);
               dataGridView2.DataSource = dt;
               con.Close();
          }

          private void dataGridView2_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
          {
               con.Close();
               con.Open();
               sda = new SqlDataAdapter(@"select * from Symptoms where DiseaseName = '" + dataGridView2.SelectedRows[0].Cells[0].Value.ToString() + "' ", con);
               dt = new DataTable();
               sda.Fill(dt);
               dataGridView3.DataSource = dt;
               con.Close();
          }

          private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
          {

          }

          private void button1_Click(object sender, EventArgs e)
          {
                    disease = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
                    con.Close();
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "insert into EffectedUser values('" + Login.UserUserName + "','" + disease + "','" + DateTime.Now.ToShortDateString() + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("RECORD UPDATED!");
                    Medicine m = new Medicine();
                    m.Show();
          }

          private void button2_Click(object sender, EventArgs e)
          {
               this.Hide();
               UserMain um = new UserMain();
               um.Show();
          }

          private void button3_Click(object sender, EventArgs e)
          {
               if(textBox1.Text!="")
               {
                    con.Close();
                    con.Open();
                    sda = new SqlDataAdapter("select Count(*) from Symptoms where Symptom ='" + textBox1.Text + "'", con);
                    dt = new DataTable();
                    sda.Fill(dt);
                    Int32 check = Int32.Parse(dt.Rows[0][0].ToString());
                    if (check > 1)
                    {
                         MessageBox.Show("Symptoms is already there!");
                    }
                    else
                    {
                         SqlCommand cmd = con.CreateCommand();
                         cmd.CommandText = "insert into RequestedSymptom values('" + textBox1.Text + "')";
                         cmd.ExecuteNonQuery();
                         con.Close();
                         MessageBox.Show("REQUEST ADDED!");
                    }
               }
              
          }
     }
}
