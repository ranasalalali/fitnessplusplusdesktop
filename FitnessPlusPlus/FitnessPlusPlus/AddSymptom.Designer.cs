﻿namespace FitnessPlusPlus
{
     partial class AddSymptom
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
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSymptom));
               this.label1 = new System.Windows.Forms.Label();
               this.textBox2 = new System.Windows.Forms.TextBox();
               this.button3 = new System.Windows.Forms.Button();
               this.label2 = new System.Windows.Forms.Label();
               this.textBox1 = new System.Windows.Forms.TextBox();
               this.dataGridView1 = new System.Windows.Forms.DataGridView();
               this.button2 = new System.Windows.Forms.Button();
               this.button1 = new System.Windows.Forms.Button();
               this.fitnessPlusPlusDataSet2 = new FitnessPlusPlus.FitnessPlusPlusDataSet2();
               this.diseaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
               this.diseaseTableAdapter = new FitnessPlusPlus.FitnessPlusPlusDataSet2TableAdapters.DiseaseTableAdapter();
               this.diseaseNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.disorderTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.label3 = new System.Windows.Forms.Label();
               this.textBox3 = new System.Windows.Forms.TextBox();
               ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.fitnessPlusPlusDataSet2)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.diseaseBindingSource)).BeginInit();
               this.SuspendLayout();
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label1.Location = new System.Drawing.Point(417, 208);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(109, 22);
               this.label1.TabIndex = 41;
               this.label1.Text = "SYMPTOMS";
               // 
               // textBox2
               // 
               this.textBox2.Location = new System.Drawing.Point(576, 208);
               this.textBox2.Name = "textBox2";
               this.textBox2.Size = new System.Drawing.Size(135, 20);
               this.textBox2.TabIndex = 40;
               // 
               // button3
               // 
               this.button3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
               this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.button3.Location = new System.Drawing.Point(769, 199);
               this.button3.Name = "button3";
               this.button3.Size = new System.Drawing.Size(134, 62);
               this.button3.TabIndex = 39;
               this.button3.Text = "ADD NEW DISEASE";
               this.button3.UseVisualStyleBackColor = false;
               this.button3.Click += new System.EventHandler(this.button3_Click);
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label2.Location = new System.Drawing.Point(417, 171);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(82, 22);
               this.label2.TabIndex = 38;
               this.label2.Text = "DISEASE";
               // 
               // textBox1
               // 
               this.textBox1.Location = new System.Drawing.Point(576, 171);
               this.textBox1.Name = "textBox1";
               this.textBox1.Size = new System.Drawing.Size(135, 20);
               this.textBox1.TabIndex = 37;
               // 
               // dataGridView1
               // 
               this.dataGridView1.AutoGenerateColumns = false;
               this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
               this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.diseaseNameDataGridViewTextBoxColumn,
            this.disorderTypeDataGridViewTextBoxColumn});
               this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
               this.dataGridView1.DataSource = this.diseaseBindingSource;
               this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
               this.dataGridView1.Location = new System.Drawing.Point(157, 40);
               this.dataGridView1.Name = "dataGridView1";
               this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
               this.dataGridView1.Size = new System.Drawing.Size(242, 375);
               this.dataGridView1.TabIndex = 36;
               this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
               // 
               // button2
               // 
               this.button2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
               this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.button2.Location = new System.Drawing.Point(82, 440);
               this.button2.Name = "button2";
               this.button2.Size = new System.Drawing.Size(134, 31);
               this.button2.TabIndex = 35;
               this.button2.Text = "BACK";
               this.button2.UseVisualStyleBackColor = false;
               this.button2.Click += new System.EventHandler(this.button2_Click);
               // 
               // button1
               // 
               this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
               this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.button1.Location = new System.Drawing.Point(577, 280);
               this.button1.Name = "button1";
               this.button1.Size = new System.Drawing.Size(134, 31);
               this.button1.TabIndex = 34;
               this.button1.Text = "ADD";
               this.button1.UseVisualStyleBackColor = false;
               this.button1.Click += new System.EventHandler(this.button1_Click);
               // 
               // fitnessPlusPlusDataSet2
               // 
               this.fitnessPlusPlusDataSet2.DataSetName = "FitnessPlusPlusDataSet2";
               this.fitnessPlusPlusDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
               // 
               // diseaseBindingSource
               // 
               this.diseaseBindingSource.DataMember = "Disease";
               this.diseaseBindingSource.DataSource = this.fitnessPlusPlusDataSet2;
               // 
               // diseaseTableAdapter
               // 
               this.diseaseTableAdapter.ClearBeforeFill = true;
               // 
               // diseaseNameDataGridViewTextBoxColumn
               // 
               this.diseaseNameDataGridViewTextBoxColumn.DataPropertyName = "DiseaseName";
               this.diseaseNameDataGridViewTextBoxColumn.HeaderText = "DiseaseName";
               this.diseaseNameDataGridViewTextBoxColumn.Name = "diseaseNameDataGridViewTextBoxColumn";
               // 
               // disorderTypeDataGridViewTextBoxColumn
               // 
               this.disorderTypeDataGridViewTextBoxColumn.DataPropertyName = "DisorderType";
               this.disorderTypeDataGridViewTextBoxColumn.HeaderText = "DisorderType";
               this.disorderTypeDataGridViewTextBoxColumn.Name = "disorderTypeDataGridViewTextBoxColumn";
               // 
               // label3
               // 
               this.label3.AutoSize = true;
               this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label3.Location = new System.Drawing.Point(417, 242);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(148, 22);
               this.label3.TabIndex = 43;
               this.label3.Text = "DISORDER TYPE";
               // 
               // textBox3
               // 
               this.textBox3.Location = new System.Drawing.Point(576, 242);
               this.textBox3.Name = "textBox3";
               this.textBox3.Size = new System.Drawing.Size(135, 20);
               this.textBox3.TabIndex = 42;
               // 
               // AddSymptom
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
               this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
               this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
               this.ClientSize = new System.Drawing.Size(984, 511);
               this.Controls.Add(this.label3);
               this.Controls.Add(this.textBox3);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.textBox2);
               this.Controls.Add(this.button3);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.textBox1);
               this.Controls.Add(this.dataGridView1);
               this.Controls.Add(this.button2);
               this.Controls.Add(this.button1);
               this.Name = "AddSymptom";
               this.Text = "AddSymptom";
               this.Load += new System.EventHandler(this.AddSymptom_Load);
               ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.fitnessPlusPlusDataSet2)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.diseaseBindingSource)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.TextBox textBox2;
          private System.Windows.Forms.Button button3;
          private System.Windows.Forms.Label label2;
          private System.Windows.Forms.TextBox textBox1;
          private System.Windows.Forms.DataGridView dataGridView1;
          private System.Windows.Forms.Button button2;
          private System.Windows.Forms.Button button1;
          private FitnessPlusPlusDataSet2 fitnessPlusPlusDataSet2;
          private System.Windows.Forms.BindingSource diseaseBindingSource;
          private FitnessPlusPlusDataSet2TableAdapters.DiseaseTableAdapter diseaseTableAdapter;
          private System.Windows.Forms.DataGridViewTextBoxColumn diseaseNameDataGridViewTextBoxColumn;
          private System.Windows.Forms.DataGridViewTextBoxColumn disorderTypeDataGridViewTextBoxColumn;
          private System.Windows.Forms.Label label3;
          private System.Windows.Forms.TextBox textBox3;
     }
}