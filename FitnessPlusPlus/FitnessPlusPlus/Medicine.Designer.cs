namespace FitnessPlusPlus
{
     partial class Medicine
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
               this.fitnessPlusPlusDataSet6 = new FitnessPlusPlus.FitnessPlusPlusDataSet6();
               this.medicineBindingSource = new System.Windows.Forms.BindingSource(this.components);
               this.medicineTableAdapter = new FitnessPlusPlus.FitnessPlusPlusDataSet6TableAdapters.MedicineTableAdapter();
               this.medicineNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.diseaseNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.fitnessPlusPlusDataSet8 = new FitnessPlusPlus.FitnessPlusPlusDataSet8();
               this.medicineBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
               this.medicineTableAdapter1 = new FitnessPlusPlus.FitnessPlusPlusDataSet8TableAdapters.MedicineTableAdapter();
               ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.fitnessPlusPlusDataSet6)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.medicineBindingSource)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.fitnessPlusPlusDataSet8)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.medicineBindingSource1)).BeginInit();
               this.SuspendLayout();
               // 
               // dataGridView1
               // 
               this.dataGridView1.AutoGenerateColumns = false;
               this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
               this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.medicineNameDataGridViewTextBoxColumn,
            this.diseaseNameDataGridViewTextBoxColumn});
               this.dataGridView1.DataSource = this.medicineBindingSource1;
               this.dataGridView1.Location = new System.Drawing.Point(12, 12);
               this.dataGridView1.Name = "dataGridView1";
               this.dataGridView1.Size = new System.Drawing.Size(342, 280);
               this.dataGridView1.TabIndex = 0;
               this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
               // 
               // fitnessPlusPlusDataSet6
               // 
               this.fitnessPlusPlusDataSet6.DataSetName = "FitnessPlusPlusDataSet6";
               this.fitnessPlusPlusDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
               // 
               // medicineBindingSource
               // 
               this.medicineBindingSource.DataMember = "Medicine";
               this.medicineBindingSource.DataSource = this.fitnessPlusPlusDataSet6;
               // 
               // medicineTableAdapter
               // 
               this.medicineTableAdapter.ClearBeforeFill = true;
               // 
               // medicineNameDataGridViewTextBoxColumn
               // 
               this.medicineNameDataGridViewTextBoxColumn.DataPropertyName = "MedicineName";
               this.medicineNameDataGridViewTextBoxColumn.HeaderText = "MedicineName";
               this.medicineNameDataGridViewTextBoxColumn.Name = "medicineNameDataGridViewTextBoxColumn";
               // 
               // diseaseNameDataGridViewTextBoxColumn
               // 
               this.diseaseNameDataGridViewTextBoxColumn.DataPropertyName = "DiseaseName";
               this.diseaseNameDataGridViewTextBoxColumn.HeaderText = "DiseaseName";
               this.diseaseNameDataGridViewTextBoxColumn.Name = "diseaseNameDataGridViewTextBoxColumn";
               // 
               // fitnessPlusPlusDataSet8
               // 
               this.fitnessPlusPlusDataSet8.DataSetName = "FitnessPlusPlusDataSet8";
               this.fitnessPlusPlusDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
               // 
               // medicineBindingSource1
               // 
               this.medicineBindingSource1.DataMember = "Medicine";
               this.medicineBindingSource1.DataSource = this.fitnessPlusPlusDataSet8;
               // 
               // medicineTableAdapter1
               // 
               this.medicineTableAdapter1.ClearBeforeFill = true;
               // 
               // Medicine
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(366, 304);
               this.Controls.Add(this.dataGridView1);
               this.Name = "Medicine";
               this.Text = "Medicine";
               this.Load += new System.EventHandler(this.Medicine_Load);
               ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.fitnessPlusPlusDataSet6)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.medicineBindingSource)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.fitnessPlusPlusDataSet8)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.medicineBindingSource1)).EndInit();
               this.ResumeLayout(false);

          }

          #endregion

          private System.Windows.Forms.DataGridView dataGridView1;
          private FitnessPlusPlusDataSet6 fitnessPlusPlusDataSet6;
          private System.Windows.Forms.BindingSource medicineBindingSource;
          private FitnessPlusPlusDataSet6TableAdapters.MedicineTableAdapter medicineTableAdapter;
          private System.Windows.Forms.DataGridViewTextBoxColumn medicineNameDataGridViewTextBoxColumn;
          private System.Windows.Forms.DataGridViewTextBoxColumn diseaseNameDataGridViewTextBoxColumn;
          private FitnessPlusPlusDataSet8 fitnessPlusPlusDataSet8;
          private System.Windows.Forms.BindingSource medicineBindingSource1;
          private FitnessPlusPlusDataSet8TableAdapters.MedicineTableAdapter medicineTableAdapter1;
     }
}