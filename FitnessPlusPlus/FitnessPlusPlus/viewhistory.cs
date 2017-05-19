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
     public partial class viewhistory : Form
     {
          SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\Documents\Visual Studio 2015\Projects\FitnessPlusPlus\FitnessPlusPlus\FitnessPlusPlus.mdf;Integrated Security=True;Connect Timeout=30");
          SqlDataAdapter sda;
          SqlCommandBuilder scb;
          DataTable dt;
          public viewhistory()
          {
               InitializeComponent();
          }

          private void viewhistory_Load(object sender, EventArgs e)
          {
               // TODO: This line of code loads data into the 'fitnessPlusPlusDataSet10.EffectedUser' table. You can move, or remove it, as needed.
               
               // TODO: This line of code loads data into the 'fitnessPlusPlusDataSet7.EffectedUser' table. You can move, or remove it, as needed.
              
               String usern = Login.UserUserName;
               sda = new SqlDataAdapter(@"select * from EffectedUser", con);
               dt = new DataTable();
               sda.Fill(dt);
               dataGridView1.DataSource = dt;
               con.Close();

          }

          private void button1_Click(object sender, EventArgs e)
          {
               this.Hide();
               UserMain um = new UserMain();
               um.Show();
          }

          private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
          {

          }
     }
}
