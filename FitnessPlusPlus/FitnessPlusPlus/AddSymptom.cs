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
     public partial class AddSymptom : Form
     {
          SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\Documents\Visual Studio 2015\Projects\FitnessPlusPlus\FitnessPlusPlus\FitnessPlusPlus.mdf;Integrated Security=True;Connect Timeout=30");
          SqlDataAdapter sda;
          SqlCommandBuilder scb;
          DataTable dt;
          public AddSymptom()
          {
               InitializeComponent();
          }

          private void AddSymptom_Load(object sender, EventArgs e)
          {
               // TODO: This line of code loads data into the 'fitnessPlusPlusDataSet2.Disease' table. You can move, or remove it, as needed.
               this.diseaseTableAdapter.Fill(this.fitnessPlusPlusDataSet2.Disease);
               sda = new SqlDataAdapter(@"select * from Disease", con);
               dt = new DataTable();
               sda.Fill(dt);
               dataGridView1.DataSource = dt;
               con.Close();
          }

          private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
          {
               textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
               textBox3.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
          }

          private void button1_Click(object sender, EventArgs e)
          {
               if (textBox1.Text == "")
               {
                    MessageBox.Show("Please Select A Disease!");
               }
               else if (textBox2.Text == "")
               {
                    MessageBox.Show("Please Name A Symptom!");
               }

               else
               {
                    con.Close();
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "insert into Symptoms values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Symptom ADDED SUCCESSFULLY!");
               }
          }

          private void button3_Click(object sender, EventArgs e)
          {
               this.Hide();
               AddDisease ad = new AddDisease();
               ad.Show();
          }

          private void button2_Click(object sender, EventArgs e)
          {
               this.Hide();
               DoctorMain dm = new DoctorMain();
               dm.Show();
          }
     }
}
