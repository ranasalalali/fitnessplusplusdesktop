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
     public partial class UserMain : Form
     {
          String name;
          
          public UserMain()
          {
               name = Login.UserUserName;

               InitializeComponent();
          }

          private void UserMain_Load(object sender, EventArgs e)
          {
               label2.Text = DateTime.Now.ToShortDateString();
               label1.Text = name;
          }

          private void button4_Click(object sender, EventArgs e)
          {
               this.Hide();
               Login l = new Login();
               l.Show();
          }

          private void label1_Click(object sender, EventArgs e)
          {
               String name;
               name = Login.UserUserName;
          }

          private void button2_Click(object sender, EventArgs e)
          {
               this.Hide();
               GetExercise ge = new GetExercise();
               ge.Show();
          }

          private void button3_Click(object sender, EventArgs e)
          {
               this.Hide();
               viewhistory vh = new viewhistory();
               vh.Show();
          }

          private void button1_Click(object sender, EventArgs e)
          {
               this.Hide();
               Diagnose d = new Diagnose();
               d.Show();
          }
     }
}
