using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessPlusPlus
{
     public partial class DoctorMain : Form
     {
          public DoctorMain()
          {
               InitializeComponent();
          }

          private void button4_Click(object sender, EventArgs e)
          {
               this.Hide();
               Login l = new Login();
               l.Show();
          }

          private void button1_Click(object sender, EventArgs e)
          {
               this.Hide();
               AddDisease ad = new AddDisease();
               ad.Show();
          }

          private void button2_Click(object sender, EventArgs e)
          {
               this.Hide();
               AddMedicine am = new AddMedicine();
               am.Show();
          }

          private void button3_Click(object sender, EventArgs e)
          {
               this.Hide();
               AddSymptom asy = new AddSymptom();
               asy.Show();
          }

          private void button5_Click(object sender, EventArgs e)
          {
               this.Hide();
               RequestedSymptom rs = new RequestedSymptom();
               rs.Show();
          }
     }
}
