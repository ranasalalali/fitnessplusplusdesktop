namespace FitnessPlusPlus
{
     partial class AdminMain
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
               this.components = new System.ComponentModel.Container();
               this.dataGridView1 = new System.Windows.Forms.DataGridView();
               this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.heightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
               this.fitnessPlusPlusDataSet1 = new FitnessPlusPlus.FitnessPlusPlusDataSet1();
               this.comboBox2 = new System.Windows.Forms.ComboBox();
               this.label10 = new System.Windows.Forms.Label();
               this.textBox9 = new System.Windows.Forms.TextBox();
               this.label9 = new System.Windows.Forms.Label();
               this.textBox8 = new System.Windows.Forms.TextBox();
               this.label7 = new System.Windows.Forms.Label();
               this.textBox6 = new System.Windows.Forms.TextBox();
               this.label8 = new System.Windows.Forms.Label();
               this.textBox7 = new System.Windows.Forms.TextBox();
               this.label5 = new System.Windows.Forms.Label();
               this.label6 = new System.Windows.Forms.Label();
               this.textBox5 = new System.Windows.Forms.TextBox();
               this.label4 = new System.Windows.Forms.Label();
               this.textBox3 = new System.Windows.Forms.TextBox();
               this.label3 = new System.Windows.Forms.Label();
               this.textBox2 = new System.Windows.Forms.TextBox();
               this.label2 = new System.Windows.Forms.Label();
               this.textBox1 = new System.Windows.Forms.TextBox();
               this.button1 = new System.Windows.Forms.Button();
               this.button2 = new System.Windows.Forms.Button();
               this.button3 = new System.Windows.Forms.Button();
               this.label1 = new System.Windows.Forms.Label();
               this.fitnessPlusPlusDataSet = new FitnessPlusPlus.FitnessPlusPlusDataSet();
               this.fitnessPlusPlusDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
               this.doctorTableAdapter = new FitnessPlusPlus.FitnessPlusPlusDataSet1TableAdapters.DoctorTableAdapter();
               ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.fitnessPlusPlusDataSet1)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.fitnessPlusPlusDataSet)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.fitnessPlusPlusDataSetBindingSource)).BeginInit();
               this.SuspendLayout();
               // 
               // dataGridView1
               // 
               this.dataGridView1.AutoGenerateColumns = false;
               this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
               this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.heightDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn});
               this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
               this.dataGridView1.DataSource = this.doctorBindingSource;
               this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
               this.dataGridView1.Location = new System.Drawing.Point(350, 12);
               this.dataGridView1.Name = "dataGridView1";
               this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
               this.dataGridView1.Size = new System.Drawing.Size(622, 487);
               this.dataGridView1.TabIndex = 0;
               this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
               // 
               // usernameDataGridViewTextBoxColumn
               // 
               this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
               this.usernameDataGridViewTextBoxColumn.HeaderText = "username";
               this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
               // 
               // passwordDataGridViewTextBoxColumn
               // 
               this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
               this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
               this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
               // 
               // nameDataGridViewTextBoxColumn
               // 
               this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
               this.nameDataGridViewTextBoxColumn.HeaderText = "name";
               this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
               // 
               // genderDataGridViewTextBoxColumn
               // 
               this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
               this.genderDataGridViewTextBoxColumn.HeaderText = "gender";
               this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
               // 
               // ageDataGridViewTextBoxColumn
               // 
               this.ageDataGridViewTextBoxColumn.DataPropertyName = "age";
               this.ageDataGridViewTextBoxColumn.HeaderText = "age";
               this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
               // 
               // phoneDataGridViewTextBoxColumn
               // 
               this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
               this.phoneDataGridViewTextBoxColumn.HeaderText = "phone";
               this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
               // 
               // emailDataGridViewTextBoxColumn
               // 
               this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
               this.emailDataGridViewTextBoxColumn.HeaderText = "email";
               this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
               // 
               // heightDataGridViewTextBoxColumn
               // 
               this.heightDataGridViewTextBoxColumn.DataPropertyName = "height";
               this.heightDataGridViewTextBoxColumn.HeaderText = "height";
               this.heightDataGridViewTextBoxColumn.Name = "heightDataGridViewTextBoxColumn";
               // 
               // weightDataGridViewTextBoxColumn
               // 
               this.weightDataGridViewTextBoxColumn.DataPropertyName = "weight";
               this.weightDataGridViewTextBoxColumn.HeaderText = "weight";
               this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
               // 
               // doctorBindingSource
               // 
               this.doctorBindingSource.DataMember = "Doctor";
               this.doctorBindingSource.DataSource = this.fitnessPlusPlusDataSet1;
               // 
               // fitnessPlusPlusDataSet1
               // 
               this.fitnessPlusPlusDataSet1.DataSetName = "FitnessPlusPlusDataSet1";
               this.fitnessPlusPlusDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
               // 
               // comboBox2
               // 
               this.comboBox2.FormattingEnabled = true;
               this.comboBox2.Items.AddRange(new object[] {
            "MALE",
            "FEMALE"});
               this.comboBox2.Location = new System.Drawing.Point(200, 167);
               this.comboBox2.Name = "comboBox2";
               this.comboBox2.Size = new System.Drawing.Size(135, 21);
               this.comboBox2.TabIndex = 49;
               // 
               // label10
               // 
               this.label10.AutoSize = true;
               this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label10.Location = new System.Drawing.Point(14, 89);
               this.label10.Name = "label10";
               this.label10.Size = new System.Drawing.Size(114, 22);
               this.label10.TabIndex = 48;
               this.label10.Text = "PASSWORD";
               // 
               // textBox9
               // 
               this.textBox9.Location = new System.Drawing.Point(199, 374);
               this.textBox9.Name = "textBox9";
               this.textBox9.Size = new System.Drawing.Size(135, 20);
               this.textBox9.TabIndex = 47;
               // 
               // label9
               // 
               this.label9.AutoSize = true;
               this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label9.Location = new System.Drawing.Point(15, 163);
               this.label9.Name = "label9";
               this.label9.Size = new System.Drawing.Size(87, 22);
               this.label9.TabIndex = 46;
               this.label9.Text = "GENDER";
               // 
               // textBox8
               // 
               this.textBox8.Location = new System.Drawing.Point(199, 339);
               this.textBox8.Name = "textBox8";
               this.textBox8.Size = new System.Drawing.Size(135, 20);
               this.textBox8.TabIndex = 45;
               // 
               // label7
               // 
               this.label7.AutoSize = true;
               this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label7.Location = new System.Drawing.Point(15, 288);
               this.label7.Name = "label7";
               this.label7.Size = new System.Drawing.Size(66, 22);
               this.label7.TabIndex = 44;
               this.label7.Text = "EMAIL";
               // 
               // textBox6
               // 
               this.textBox6.Location = new System.Drawing.Point(199, 256);
               this.textBox6.Name = "textBox6";
               this.textBox6.Size = new System.Drawing.Size(135, 20);
               this.textBox6.TabIndex = 43;
               // 
               // label8
               // 
               this.label8.AutoSize = true;
               this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label8.Location = new System.Drawing.Point(15, 243);
               this.label8.Name = "label8";
               this.label8.Size = new System.Drawing.Size(75, 22);
               this.label8.TabIndex = 42;
               this.label8.Text = "PHONE";
               // 
               // textBox7
               // 
               this.textBox7.Location = new System.Drawing.Point(199, 303);
               this.textBox7.Name = "textBox7";
               this.textBox7.Size = new System.Drawing.Size(135, 20);
               this.textBox7.TabIndex = 41;
               // 
               // label5
               // 
               this.label5.AutoSize = true;
               this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label5.Location = new System.Drawing.Point(15, 374);
               this.label5.Name = "label5";
               this.label5.Size = new System.Drawing.Size(126, 22);
               this.label5.TabIndex = 40;
               this.label5.Text = "WEIGHT(CM)";
               // 
               // label6
               // 
               this.label6.AutoSize = true;
               this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label6.Location = new System.Drawing.Point(15, 335);
               this.label6.Name = "label6";
               this.label6.Size = new System.Drawing.Size(122, 22);
               this.label6.TabIndex = 39;
               this.label6.Text = "HEIGHT(CM)";
               // 
               // textBox5
               // 
               this.textBox5.Location = new System.Drawing.Point(199, 215);
               this.textBox5.Name = "textBox5";
               this.textBox5.Size = new System.Drawing.Size(135, 20);
               this.textBox5.TabIndex = 38;
               // 
               // label4
               // 
               this.label4.AutoSize = true;
               this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label4.Location = new System.Drawing.Point(15, 202);
               this.label4.Name = "label4";
               this.label4.Size = new System.Drawing.Size(52, 22);
               this.label4.TabIndex = 37;
               this.label4.Text = "AGE";
               // 
               // textBox3
               // 
               this.textBox3.Location = new System.Drawing.Point(199, 131);
               this.textBox3.Name = "textBox3";
               this.textBox3.Size = new System.Drawing.Size(135, 20);
               this.textBox3.TabIndex = 36;
               // 
               // label3
               // 
               this.label3.AutoSize = true;
               this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label3.Location = new System.Drawing.Point(15, 125);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(66, 22);
               this.label3.TabIndex = 35;
               this.label3.Text = "NAME";
               // 
               // textBox2
               // 
               this.textBox2.Location = new System.Drawing.Point(199, 93);
               this.textBox2.Name = "textBox2";
               this.textBox2.Size = new System.Drawing.Size(135, 20);
               this.textBox2.TabIndex = 34;
               this.textBox2.UseSystemPasswordChar = true;
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label2.Location = new System.Drawing.Point(15, 54);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(109, 22);
               this.label2.TabIndex = 33;
               this.label2.Text = "USERNAME";
               // 
               // textBox1
               // 
               this.textBox1.Location = new System.Drawing.Point(200, 54);
               this.textBox1.Name = "textBox1";
               this.textBox1.Size = new System.Drawing.Size(135, 20);
               this.textBox1.TabIndex = 32;
               // 
               // button1
               // 
               this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
               this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.button1.Location = new System.Drawing.Point(201, 421);
               this.button1.Name = "button1";
               this.button1.Size = new System.Drawing.Size(134, 31);
               this.button1.TabIndex = 50;
               this.button1.Text = "APPROVE";
               this.button1.UseVisualStyleBackColor = false;
               this.button1.Click += new System.EventHandler(this.button1_Click);
               // 
               // button2
               // 
               this.button2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
               this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.button2.Location = new System.Drawing.Point(19, 421);
               this.button2.Name = "button2";
               this.button2.Size = new System.Drawing.Size(134, 31);
               this.button2.TabIndex = 51;
               this.button2.Text = "REJECT";
               this.button2.UseVisualStyleBackColor = false;
               this.button2.Click += new System.EventHandler(this.button2_Click);
               // 
               // button3
               // 
               this.button3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
               this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.button3.Location = new System.Drawing.Point(19, 468);
               this.button3.Name = "button3";
               this.button3.Size = new System.Drawing.Size(134, 31);
               this.button3.TabIndex = 52;
               this.button3.Text = "LOGOUT";
               this.button3.UseVisualStyleBackColor = false;
               this.button3.Click += new System.EventHandler(this.button3_Click);
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label1.Location = new System.Drawing.Point(-1, 9);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(345, 23);
               this.label1.TabIndex = 53;
               this.label1.Text = "APPROVE/REJECT DOCTOR REQUESTS";
               // 
               // fitnessPlusPlusDataSet
               // 
               this.fitnessPlusPlusDataSet.DataSetName = "FitnessPlusPlusDataSet";
               this.fitnessPlusPlusDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
               // 
               // fitnessPlusPlusDataSetBindingSource
               // 
               this.fitnessPlusPlusDataSetBindingSource.DataSource = this.fitnessPlusPlusDataSet;
               this.fitnessPlusPlusDataSetBindingSource.Position = 0;
               // 
               // doctorTableAdapter
               // 
               this.doctorTableAdapter.ClearBeforeFill = true;
               // 
               // AdminMain
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
               this.ClientSize = new System.Drawing.Size(984, 511);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.button3);
               this.Controls.Add(this.button2);
               this.Controls.Add(this.button1);
               this.Controls.Add(this.comboBox2);
               this.Controls.Add(this.label10);
               this.Controls.Add(this.textBox9);
               this.Controls.Add(this.label9);
               this.Controls.Add(this.textBox8);
               this.Controls.Add(this.label7);
               this.Controls.Add(this.textBox6);
               this.Controls.Add(this.label8);
               this.Controls.Add(this.textBox7);
               this.Controls.Add(this.label5);
               this.Controls.Add(this.label6);
               this.Controls.Add(this.textBox5);
               this.Controls.Add(this.label4);
               this.Controls.Add(this.textBox3);
               this.Controls.Add(this.label3);
               this.Controls.Add(this.textBox2);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.textBox1);
               this.Controls.Add(this.dataGridView1);
               this.Name = "AdminMain";
               this.Text = "AdminMain";
               this.Load += new System.EventHandler(this.AdminMain_Load);
               ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.fitnessPlusPlusDataSet1)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.fitnessPlusPlusDataSet)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.fitnessPlusPlusDataSetBindingSource)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.DataGridView dataGridView1;
          private System.Windows.Forms.ComboBox comboBox2;
          private System.Windows.Forms.Label label10;
          private System.Windows.Forms.TextBox textBox9;
          private System.Windows.Forms.Label label9;
          private System.Windows.Forms.TextBox textBox8;
          private System.Windows.Forms.Label label7;
          private System.Windows.Forms.TextBox textBox6;
          private System.Windows.Forms.Label label8;
          private System.Windows.Forms.TextBox textBox7;
          private System.Windows.Forms.Label label5;
          private System.Windows.Forms.Label label6;
          private System.Windows.Forms.TextBox textBox5;
          private System.Windows.Forms.Label label4;
          private System.Windows.Forms.TextBox textBox3;
          private System.Windows.Forms.Label label3;
          private System.Windows.Forms.TextBox textBox2;
          private System.Windows.Forms.Label label2;
          private System.Windows.Forms.TextBox textBox1;
          private System.Windows.Forms.BindingSource fitnessPlusPlusDataSetBindingSource;
          private FitnessPlusPlusDataSet fitnessPlusPlusDataSet;
          private System.Windows.Forms.Button button1;
          private System.Windows.Forms.Button button2;
          private System.Windows.Forms.Button button3;
          private System.Windows.Forms.Label label1;
          private FitnessPlusPlusDataSet1 fitnessPlusPlusDataSet1;
          private System.Windows.Forms.BindingSource doctorBindingSource;
          private FitnessPlusPlusDataSet1TableAdapters.DoctorTableAdapter doctorTableAdapter;
          private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
          private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
          private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
          private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
          private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
          private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
          private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
          private System.Windows.Forms.DataGridViewTextBoxColumn heightDataGridViewTextBoxColumn;
          private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
     }
}