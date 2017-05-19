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
     public partial class Registration : Form
     {
          SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\Documents\Visual Studio 2015\Projects\FitnessPlusPlus\FitnessPlusPlus\FitnessPlusPlus.mdf;Integrated Security=True;Connect Timeout=30");
          SqlDataAdapter sda;
          SqlCommandBuilder scb;
          DataTable dt;
          public Registration()
          {
               InitializeComponent();
          }

          private void button1_Click(object sender, EventArgs e)
          {
               this.Hide();
               Login l = new Login();
               l.Show();
          }

          private void button2_Click(object sender, EventArgs e)
          {
               if (comboBox1.Text == "DOCTOR")
               {
                    con.Close();
                    con.Open();
                    sda = new SqlDataAdapter("select Count(*) from Doctor where username ='" + textBox1.Text + "'",con);
                    dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                         MessageBox.Show("Please Choose Another Username, This username already exists!");
                    }
                    else
                    {
                         SqlCommand cmd = con.CreateCommand();
                         cmd.CommandText = "insert into Doctor values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + comboBox2.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "')";
                         cmd.ExecuteNonQuery();
                         con.Close();
                         MessageBox.Show("CONGRATULATIONS! YOUR REQUEST HAVE BEEN SUBMITTED, KINDLY LOGIN TO CHECK IF YOUR REQUEST HAS BEEN APPROVED AFTER 24HOURS, THANKYOU!");
                         this.Hide();
                         Login l = new Login();
                         l.Show();
                    }
               }
               else if (comboBox1.Text == "USER")
               {
                    con.Close();
                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from [User] where username ='" + textBox1.Text + "'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                         MessageBox.Show("Please Choose Another Username, This username already exists!");
                    }
                    else
                    {
                         SqlCommand cmd = con.CreateCommand();
                         cmd.CommandText = "insert into [User] values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + comboBox2.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "')";
                         cmd.ExecuteNonQuery();
                         con.Close();
                         MessageBox.Show("CONGRATULATIONS! YOU HAVE BEEN SUCCESSFULLY REGISTERED, THANKYOU!");
                         this.Hide();
                         Login l = new Login();
                         l.Show();
                    }
               }
               else
               {
                    MessageBox.Show("Who are you? Please choose an option");
               }


          }
     }
}
