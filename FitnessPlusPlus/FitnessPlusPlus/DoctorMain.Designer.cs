﻿namespace FitnessPlusPlus
{
     partial class DoctorMain
     {
          /// <summary>
          /// Required designer variable.
          /// </summary>
          private System.ComponentModel.IContainer components = null;

          /// <summary>
          /// Clean up any resources being used.
          /// </summary>
          /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
          protected override void Dispose(bool disposing)
          {
               if (disposing && (components != null))
               {
                    components.Dispose();
               }
               base.Dispose(disposing);
          }

          #region Windows Form Designer generated code

          /// <summary>
          /// Required method for Designer support - do not modify
          /// the contents of this method with the code editor.
          /// </summary>
          private void InitializeComponent()
          {
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorMain));
               this.button1 = new System.Windows.Forms.Button();
               this.button2 = new System.Windows.Forms.Button();
               this.button3 = new System.Windows.Forms.Button();
               this.button4 = new System.Windows.Forms.Button();
               this.button5 = new System.Windows.Forms.Button();
               this.SuspendLayout();
               // 
               // button1
               // 
               this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
               this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.button1.Location = new System.Drawing.Point(481, 389);
               this.button1.Name = "button1";
               this.button1.Size = new System.Drawing.Size(159, 68);
               this.button1.TabIndex = 9;
               this.button1.Text = "ADD NEW DISEASE";
               this.button1.UseVisualStyleBackColor = false;
               this.button1.Click += new System.EventHandler(this.button1_Click);
               // 
               // button2
               // 
               this.button2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
               this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.button2.Location = new System.Drawing.Point(309, 318);
               this.button2.Name = "button2";
               this.button2.Size = new System.Drawing.Size(166, 65);
               this.button2.TabIndex = 10;
               this.button2.Text = "ADD NEW MEDICINE";
               this.button2.UseVisualStyleBackColor = false;
               this.button2.Click += new System.EventHandler(this.button2_Click);
               // 
               // button3
               // 
               this.button3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
               this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.button3.Location = new System.Drawing.Point(145, 318);
               this.button3.Name = "button3";
               this.button3.Size = new System.Drawing.Size(164, 65);
               this.button3.TabIndex = 11;
               this.button3.Text = "ADD NEW SYMPTOMS";
               this.button3.UseVisualStyleBackColor = false;
               this.button3.Click += new System.EventHandler(this.button3_Click);
               // 
               // button4
               // 
               this.button4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
               this.button4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.button4.Location = new System.Drawing.Point(12, 468);
               this.button4.Name = "button4";
               this.button4.Size = new System.Drawing.Size(134, 31);
               this.button4.TabIndex = 12;
               this.button4.Text = "LOGOUT";
               this.button4.UseVisualStyleBackColor = false;
               this.button4.Click += new System.EventHandler(this.button4_Click);
               // 
               // button5
               // 
               this.button5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
               this.button5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.button5.Location = new System.Drawing.Point(309, 389);
               this.button5.Name = "button5";
               this.button5.Size = new System.Drawing.Size(166, 68);
               this.button5.TabIndex = 13;
               this.button5.Text = "VIEW REQUESTED SYMPTOMS";
               this.button5.UseVisualStyleBackColor = false;
               this.button5.Click += new System.EventHandler(this.button5_Click);
               // 
               // DoctorMain
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
               this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
               this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
               this.ClientSize = new System.Drawing.Size(984, 511);
               this.Controls.Add(this.button5);
               this.Controls.Add(this.button4);
               this.Controls.Add(this.button3);
               this.Controls.Add(this.button2);
               this.Controls.Add(this.button1);
               this.Name = "DoctorMain";
               this.Text = "DoctorMain";
               this.ResumeLayout(false);

          }

          #endregion

          private System.Windows.Forms.Button button1;
          private System.Windows.Forms.Button button2;
          private System.Windows.Forms.Button button3;
          private System.Windows.Forms.Button button4;
          private System.Windows.Forms.Button button5;
     }
}