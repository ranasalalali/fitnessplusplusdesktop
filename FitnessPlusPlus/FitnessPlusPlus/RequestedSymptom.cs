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
     public partial class RequestedSymptom : Form
     {
          SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\Documents\Visual Studio 2015\Projects\FitnessPlusPlus\FitnessPlusPlus\FitnessPlusPlus.mdf;Integrated Security=True;Connect Timeout=30");
          SqlDataAdapter sda;
          SqlCommandBuilder scb;
          DataTable dt;
          public RequestedSymptom()
          {
               InitializeComponent();
          }

          private void RequestedSymptom_Load(object sender, EventArgs e)
          {
               // TODO: This line of code loads data into the 'fitnessPlusPlusDataSet2.Disease' table. You can move, or remove it, as needed.
               this.diseaseTableAdapter.Fill(this.fitnessPlusPlusDataSet2.Disease);
               // TODO: This line of code loads data into the 'fitnessPlusPlusDataSet3.RequestedSymptom' table. You can move, or remove it, as needed.
               this.requestedSymptomTableAdapter.Fill(this.fitnessPlusPlusDataSet3.RequestedSymptom);
               con.Open();
               sda = new SqlDataAdapter(@"select * from RequestedSymptom", con);
               dt = new DataTable();
               sda.Fill(dt);
               dataGridView1.DataSource = dt;
               con.Close();
               con.Open();
               sda = new SqlDataAdapter(@"select * from Disease", con);
               dt = new DataTable();
               sda.Fill(dt);
               dataGridView2.DataSource = dt;
               con.Close();

          }

          private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
          {
               textBox2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
          }

          private void dataGridView2_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
          {
               textBox1.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
               comboBox1.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
          }

          private void button3_Click(object sender, EventArgs e)
          {
               this.Hide();
               AddDisease ad = new AddDisease();
               ad.Show();
          }

          private void button1_Click(object sender, EventArgs e)
          {
               if (textBox1.Text == "")
               {
                    MessageBox.Show("Please Select A Symptom!");
               }
               else if (textBox2.Text == "")
               {
                    MessageBox.Show("Please Name A Disease!");
               }
               else
               {
                    con.Close();
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "insert into Symptom values('" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.Text + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Symptom ADDED SUCCESSFULLY!");
               }
          }

          private void button2_Click(object sender, EventArgs e)
          {
               this.Hide();
               DoctorMain dm = new DoctorMain();
               dm.Show();
          }

          private void textBox2_TextChanged(object sender, EventArgs e)
          {

          }
     }
}
