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
     public partial class AddDisease : Form
     {
          SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\Documents\Visual Studio 2015\Projects\FitnessPlusPlus\FitnessPlusPlus\FitnessPlusPlus.mdf;Integrated Security=True;Connect Timeout=30");
          SqlDataAdapter sda;
          SqlCommandBuilder scb;
          DataTable dt;
          public AddDisease()
          {
               InitializeComponent();
          }

          private void AddDisease_Load(object sender, EventArgs e)
          {

          }

          private void button1_Click(object sender, EventArgs e)
          {
               if (comboBox1.Text == "")
               {
                    MessageBox.Show("Please Select A Disorder!");
               }
               else if (textBox1.Text == "")
               {
                    MessageBox.Show("Please Name a Disease!");
               }
               else
               {
                    con.Close();
                    con.Open();
                    sda = new SqlDataAdapter("select Count(*) from Disease where DiseaseName ='" + textBox1.Text + "'", con);
                    dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                         MessageBox.Show("Disease Already Exists!");
                    }
                    else
                    {
                         SqlCommand cmd = con.CreateCommand();
                         cmd.CommandText = "insert into Disease values('" + textBox1.Text + "','" + comboBox1.Text + "')";
                         cmd.ExecuteNonQuery();
                         con.Close();
                         MessageBox.Show("DISEASE ADDED SUCCESSFULLY!");
                    }
               }


          }

          private void button2_Click(object sender, EventArgs e)
          {
               this.Hide();
               DoctorMain dm = new DoctorMain();
               dm.Show();
          }

          private void button3_Click(object sender, EventArgs e)
          {
               this.Hide();
               AddMedicine am = new AddMedicine();
               am.Show();
          }
     }
}
