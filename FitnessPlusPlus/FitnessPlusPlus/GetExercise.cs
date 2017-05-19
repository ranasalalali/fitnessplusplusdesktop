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
     public partial class GetExercise : Form
     {
          public GetExercise()
          {
               InitializeComponent();
          }

          private void button2_Click(object sender, EventArgs e)
          {
               this.Hide();
               UserMain um = new UserMain();
               um.Show();
          }

          private void button1_Click(object sender, EventArgs e)
          {
               MessageBox.Show("Yoga " + Environment.NewLine + "Beginners: " + Environment.NewLine + "Perform 1 set " + Environment.NewLine + "5 reps " + Environment.NewLine + "Hold for 10 seconds each " + Environment.NewLine + "Intermeidate: " + Environment.NewLine + "Perform 1 set " + Environment.NewLine + "10 reps" + Environment.NewLine + "Hold for 10 seconds each" + Environment.NewLine + "Perform 2 circuits" + Environment.NewLine + "10 reps" + Environment.NewLine + "Hold for 30 seconds each");
          }

          private void button3_Click(object sender, EventArgs e)
          {
               MessageBox.Show("Yoga " + Environment.NewLine + "Beginners: " + Environment.NewLine + "Perform 1 set " + Environment.NewLine + "5 reps " + Environment.NewLine + "Hold for 10 seconds each " + Environment.NewLine + "Intermeidate: " + Environment.NewLine + "Perform 1 set " + Environment.NewLine + "10 reps" + Environment.NewLine + "Hold for 10 seconds each" + Environment.NewLine + "Perform 2 circuits" + Environment.NewLine + "10 reps" + Environment.NewLine + "Hold for 30 seconds each");

          }

          private void button4_Click(object sender, EventArgs e)
          {
               MessageBox.Show("Yoga " + Environment.NewLine + "Beginners: " + Environment.NewLine + "Perform 1 set " + Environment.NewLine + "5 reps " + Environment.NewLine + "Hold for 10 seconds each " + Environment.NewLine + "Intermeidate: " + Environment.NewLine + "Perform 1 set " + Environment.NewLine + "10 reps" + Environment.NewLine + "Hold for 10 seconds each" + Environment.NewLine + "Perform 2 circuits" + Environment.NewLine + "10 reps" + Environment.NewLine + "Hold for 30 seconds each");
          }

          private void button5_Click(object sender, EventArgs e)
          {
               MessageBox.Show("Yoga " + Environment.NewLine + "Beginners: " + Environment.NewLine + "Perform 1 set " + Environment.NewLine + "5 reps " + Environment.NewLine + "Hold for 10 seconds each " + Environment.NewLine + "Intermeidate: " + Environment.NewLine + "Perform 1 set " + Environment.NewLine + "10 reps" + Environment.NewLine + "Hold for 10 seconds each" + Environment.NewLine + "Perform 2 circuits" + Environment.NewLine + "10 reps" + Environment.NewLine + "Hold for 30 seconds each");
          }
     }
}
