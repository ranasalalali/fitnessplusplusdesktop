namespace FitnessPlusPlus
{
     partial class Diagnose
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
               this.fitnessPlusPlusDataSet4 = new FitnessPlusPlus.FitnessPlusPlusDataSet4();
               this.symptomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
               this.symptomsTableAdapter = new FitnessPlusPlus.FitnessPlusPlusDataSet4TableAdapters.SymptomsTableAdapter();
               this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
               this.dataGridView1 = new System.Windows.Forms.DataGridView();
               this.symptomsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
               this.symptomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.symptomsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
               this.fitnessPlusPlusDataSet5 = new FitnessPlusPlus.FitnessPlusPlusDataSet5();
               this.dataGridView2 = new System.Windows.Forms.DataGridView();
               this.diseaseNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.symptomDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.symptomsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
               this.symptomsTableAdapter1 = new FitnessPlusPlus.FitnessPlusPlusDataSet5TableAdapters.SymptomsTableAdapter();
               this.button1 = new System.Windows.Forms.Button();
               this.label2 = new System.Windows.Forms.Label();
               this.dataGridView3 = new System.Windows.Forms.DataGridView();
               this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.label1 = new System.Windows.Forms.Label();
               this.label3 = new System.Windows.Forms.Label();
               this.button2 = new System.Windows.Forms.Button();
               this.label4 = new System.Windows.Forms.Label();
               this.textBox1 = new System.Windows.Forms.TextBox();
               this.button3 = new System.Windows.Forms.Button();
               ((System.ComponentModel.ISupportInitialize)(this.fitnessPlusPlusDataSet4)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.symptomsBindingSource)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.symptomsBindingSource1)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.symptomsBindingSource2)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.fitnessPlusPlusDataSet5)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.symptomsBindingSource3)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
               this.SuspendLayout();
               // 
               // fitnessPlusPlusDataSet4
               // 
               this.fitnessPlusPlusDataSet4.DataSetName = "FitnessPlusPlusDataSet4";
               this.fitnessPlusPlusDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
               // 
               // symptomsBindingSource
               // 
               this.symptomsBindingSource.DataMember = "Symptoms";
               this.symptomsBindingSource.DataSource = this.fitnessPlusPlusDataSet4;
               // 
               // symptomsTableAdapter
               // 
               this.symptomsTableAdapter.ClearBeforeFill = true;
               // 
               // dataGridView1
               // 
               this.dataGridView1.AutoGenerateColumns = false;
               this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
               this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.symptomDataGridViewTextBoxColumn});
               this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
               this.dataGridView1.DataSource = this.symptomsBindingSource3;
               this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
               this.dataGridView1.Location = new System.Drawing.Point(45, 35);
               this.dataGridView1.Name = "dataGridView1";
               this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
               this.dataGridView1.Size = new System.Drawing.Size(145, 375);
               this.dataGridView1.TabIndex = 44;
               this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
               // 
               // symptomsBindingSource1
               // 
               this.symptomsBindingSource1.DataMember = "Symptoms";
               this.symptomsBindingSource1.DataSource = this.fitnessPlusPlusDataSet4;
               // 
               // symptomDataGridViewTextBoxColumn
               // 
               this.symptomDataGridViewTextBoxColumn.DataPropertyName = "Symptom";
               this.symptomDataGridViewTextBoxColumn.HeaderText = "Symptom";
               this.symptomDataGridViewTextBoxColumn.Name = "symptomDataGridViewTextBoxColumn";
               // 
               // symptomsBindingSource2
               // 
               this.symptomsBindingSource2.DataMember = "Symptoms";
               this.symptomsBindingSource2.DataSource = this.fitnessPlusPlusDataSet4;
               // 
               // fitnessPlusPlusDataSet5
               // 
               this.fitnessPlusPlusDataSet5.DataSetName = "FitnessPlusPlusDataSet5";
               this.fitnessPlusPlusDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
               // 
               // dataGridView2
               // 
               this.dataGridView2.AutoGenerateColumns = false;
               this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
               this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.diseaseNameDataGridViewTextBoxColumn1,
            this.symptomDataGridViewTextBoxColumn1});
               this.dataGridView2.Cursor = System.Windows.Forms.Cursors.Default;
               this.dataGridView2.DataSource = this.symptomsBindingSource2;
               this.dataGridView2.GridColor = System.Drawing.SystemColors.ButtonFace;
               this.dataGridView2.Location = new System.Drawing.Point(211, 35);
               this.dataGridView2.Name = "dataGridView2";
               this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
               this.dataGridView2.Size = new System.Drawing.Size(242, 375);
               this.dataGridView2.TabIndex = 45;
               this.dataGridView2.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_CellMouseDoubleClick);
               // 
               // diseaseNameDataGridViewTextBoxColumn1
               // 
               this.diseaseNameDataGridViewTextBoxColumn1.DataPropertyName = "DiseaseName";
               this.diseaseNameDataGridViewTextBoxColumn1.HeaderText = "DiseaseName";
               this.diseaseNameDataGridViewTextBoxColumn1.Name = "diseaseNameDataGridViewTextBoxColumn1";
               // 
               // symptomDataGridViewTextBoxColumn1
               // 
               this.symptomDataGridViewTextBoxColumn1.DataPropertyName = "Symptom";
               this.symptomDataGridViewTextBoxColumn1.HeaderText = "Symptom";
               this.symptomDataGridViewTextBoxColumn1.Name = "symptomDataGridViewTextBoxColumn1";
               // 
               // symptomsBindingSource3
               // 
               this.symptomsBindingSource3.DataMember = "Symptoms";
               this.symptomsBindingSource3.DataSource = this.fitnessPlusPlusDataSet5;
               // 
               // symptomsTableAdapter1
               // 
               this.symptomsTableAdapter1.ClearBeforeFill = true;
               // 
               // button1
               // 
               this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
               this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.button1.Location = new System.Drawing.Point(474, 329);
               this.button1.Name = "button1";
               this.button1.Size = new System.Drawing.Size(134, 31);
               this.button1.TabIndex = 47;
               this.button1.Text = "SELECT";
               this.button1.UseVisualStyleBackColor = false;
               this.button1.Click += new System.EventHandler(this.button1_Click);
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label2.Location = new System.Drawing.Point(470, 35);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(355, 22);
               this.label2.TabIndex = 48;
               this.label2.Text = "POSSIBLE SYMPTOMS FOR THIS DISEASE";
               // 
               // dataGridView3
               // 
               this.dataGridView3.AutoGenerateColumns = false;
               this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
               this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
               this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
               this.dataGridView3.Cursor = System.Windows.Forms.Cursors.Default;
               this.dataGridView3.DataSource = this.symptomsBindingSource3;
               this.dataGridView3.GridColor = System.Drawing.SystemColors.ButtonFace;
               this.dataGridView3.Location = new System.Drawing.Point(474, 74);
               this.dataGridView3.Name = "dataGridView3";
               this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
               this.dataGridView3.Size = new System.Drawing.Size(390, 183);
               this.dataGridView3.TabIndex = 49;
               this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
               // 
               // dataGridViewTextBoxColumn1
               // 
               this.dataGridViewTextBoxColumn1.DataPropertyName = "Symptom";
               this.dataGridViewTextBoxColumn1.HeaderText = "Symptom";
               this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label1.Location = new System.Drawing.Point(470, 270);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(446, 20);
               this.label1.TabIndex = 50;
               this.label1.Text = "SELECT THE DISEASE WHICH YOU FIND THE MOST APPROPRIATE";
               // 
               // label3
               // 
               this.label3.AutoSize = true;
               this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label3.Location = new System.Drawing.Point(470, 290);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(459, 20);
               this.label3.TabIndex = 51;
               this.label3.Text = "TO SHOW MEDICINES ACCORDINGLY AND SAVE YOUR HISTORY";
               // 
               // button2
               // 
               this.button2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
               this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.button2.Location = new System.Drawing.Point(35, 455);
               this.button2.Name = "button2";
               this.button2.Size = new System.Drawing.Size(134, 31);
               this.button2.TabIndex = 52;
               this.button2.Text = "BACK";
               this.button2.UseVisualStyleBackColor = false;
               this.button2.Click += new System.EventHandler(this.button2_Click);
               // 
               // label4
               // 
               this.label4.AutoSize = true;
               this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label4.Location = new System.Drawing.Point(544, 440);
               this.label4.Name = "label4";
               this.label4.Size = new System.Drawing.Size(235, 22);
               this.label4.TabIndex = 54;
               this.label4.Text = "REQUEST FOR SYMPTOMS";
               // 
               // textBox1
               // 
               this.textBox1.Location = new System.Drawing.Point(781, 440);
               this.textBox1.Name = "textBox1";
               this.textBox1.Size = new System.Drawing.Size(173, 20);
               this.textBox1.TabIndex = 53;
               // 
               // button3
               // 
               this.button3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
               this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.button3.Location = new System.Drawing.Point(820, 468);
               this.button3.Name = "button3";
               this.button3.Size = new System.Drawing.Size(134, 31);
               this.button3.TabIndex = 55;
               this.button3.Text = "REQUEST";
               this.button3.UseVisualStyleBackColor = false;
               this.button3.Click += new System.EventHandler(this.button3_Click);
               // 
               // Diagnose
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
               this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
               this.ClientSize = new System.Drawing.Size(984, 511);
               this.Controls.Add(this.button3);
               this.Controls.Add(this.label4);
               this.Controls.Add(this.textBox1);
               this.Controls.Add(this.button2);
               this.Controls.Add(this.label3);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.dataGridView3);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.button1);
               this.Controls.Add(this.dataGridView2);
               this.Controls.Add(this.dataGridView1);
               this.Name = "Diagnose";
               this.Text = "Diagnose";
               this.Load += new System.EventHandler(this.Diagnose_Load);
               ((System.ComponentModel.ISupportInitialize)(this.fitnessPlusPlusDataSet4)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.symptomsBindingSource)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.symptomsBindingSource1)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.symptomsBindingSource2)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.fitnessPlusPlusDataSet5)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.symptomsBindingSource3)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion
          private FitnessPlusPlusDataSet4 fitnessPlusPlusDataSet4;
          private System.Windows.Forms.BindingSource symptomsBindingSource;
          private FitnessPlusPlusDataSet4TableAdapters.SymptomsTableAdapter symptomsTableAdapter;
          private System.ComponentModel.BackgroundWorker backgroundWorker1;
          private System.Windows.Forms.DataGridView dataGridView1;
          private System.Windows.Forms.DataGridViewTextBoxColumn symptomDataGridViewTextBoxColumn;
          private System.Windows.Forms.BindingSource symptomsBindingSource1;
          private System.Windows.Forms.BindingSource symptomsBindingSource2;
          private FitnessPlusPlusDataSet5 fitnessPlusPlusDataSet5;
          private System.Windows.Forms.DataGridView dataGridView2;
          private System.Windows.Forms.DataGridViewTextBoxColumn diseaseNameDataGridViewTextBoxColumn1;
          private System.Windows.Forms.DataGridViewTextBoxColumn symptomDataGridViewTextBoxColumn1;
          private System.Windows.Forms.BindingSource symptomsBindingSource3;
          private FitnessPlusPlusDataSet5TableAdapters.SymptomsTableAdapter symptomsTableAdapter1;
          private System.Windows.Forms.Button button1;
          private System.Windows.Forms.Label label2;
          private System.Windows.Forms.DataGridView dataGridView3;
          private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.Label label3;
          private System.Windows.Forms.Button button2;
          private System.Windows.Forms.Label label4;
          private System.Windows.Forms.TextBox textBox1;
          private System.Windows.Forms.Button button3;
     }
}