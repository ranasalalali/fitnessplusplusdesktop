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
     public partial class Login : Form
     {
          SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\Documents\Visual Studio 2015\Projects\FitnessPlusPlus\FitnessPlusPlus\FitnessPlusPlus.mdf;Integrated Security=True;Connect Timeout=30");
          SqlDataAdapter sda;
          SqlCommandBuilder scb;
          DataTable dt;
          public static String DoctorUserName;
          public static String UserUserName;
          public Login()
          {
               InitializeComponent();
          }

          private void radioButton4_CheckedChanged(object sender, EventArgs e)
          {

          }

          private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
          {
               this.Hide();
               Registration r = new Registration();
               r.Show();
          }

          private void Login_Load(object sender, EventArgs e)
          {

          }

          private void button1_Click(object sender, EventArgs e)
          {
               if (comboBox1.Text == "ADMIN")
               {
                    if (textBox1.Text == "admin" && textBox2.Text == "admin")
                    {
                         this.Hide();
                         AdminMain a = new AdminMain();
                         a.Show();
                    }
               }
               else if (comboBox1.Text == "DOCTOR")
               {
                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from RegisteredDoctor where username = '" + textBox1.Text + "' and password = '" + textBox2.Text + "'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                         DoctorUserName = textBox1.Text;
                         this.Hide();
                         DoctorMain stmain = new DoctorMain();
                         stmain.Show();
                    }
                    else
                    {
                         MessageBox.Show("Please enter correct username and password!");
                    }
                    //sda.SelectCommand.ExecuteNonQuery();
                    con.Close();
               }
               else if (comboBox1.Text == "USER")
               {
                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from [User] where username = '" + textBox1.Text + "' and password = '" + textBox2.Text + "'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                         UserUserName = textBox1.Text;
                         this.Hide();
                         UserMain stmain = new UserMain();
                         stmain.Show();
                    }
                    else
                    {
                         MessageBox.Show("Please enter correct username and password!");
                    }
                    //sda.SelectCommand.ExecuteNonQuery();
                    con.Close();
               }
               else {
                    MessageBox.Show("Who Are You? Please Choose An Option!");
               }

          }
     }
}
