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
     public partial class Medicine : Form
     {
          SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\Documents\Visual Studio 2015\Projects\FitnessPlusPlus\FitnessPlusPlus\FitnessPlusPlus.mdf;Integrated Security=True;Connect Timeout=30");
          SqlDataAdapter sda;
          SqlCommandBuilder scb;
          DataTable dt;
          public Medicine()
          {
               InitializeComponent();
          }

          private void Medicine_Load(object sender, EventArgs e)
          {
               // TODO: This line of code loads data into the 'fitnessPlusPlusDataSet8.Medicine' table. You can move, or remove it, as needed.
               this.medicineTableAdapter1.Fill(this.fitnessPlusPlusDataSet8.Medicine);
               // TODO: This line of code loads data into the 'fitnessPlusPlusDataSet6.Medicine' table. You can move, or remove it, as needed.
               this.medicineTableAdapter.Fill(this.fitnessPlusPlusDataSet6.Medicine);
               con.Close();
               con.Open();
               sda = new SqlDataAdapter(@"select * from Medicine where DiseaseName = '" + Diagnose.disease + "' ", con);
               dt = new DataTable();
               sda.Fill(dt);
               dataGridView1.DataSource = dt;
               con.Close();
          }

          private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
          {

          }
     }
}
