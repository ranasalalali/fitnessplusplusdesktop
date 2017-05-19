namespace FitnessPlusPlus
{
     partial class viewhistory
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
               this.fitnessPlusPlusDataSet7 = new FitnessPlusPlus.FitnessPlusPlusDataSet7();
               this.effectedUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
               this.effectedUserTableAdapter = new FitnessPlusPlus.FitnessPlusPlusDataSet7TableAdapters.EffectedUserTableAdapter();
               this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.diseaseNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.button1 = new System.Windows.Forms.Button();
               this.fitnessPlusPlusDataSet10 = new FitnessPlusPlus.FitnessPlusPlusDataSet10();
               this.effectedUserBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
               this.effectedUserTableAdapter1 = new FitnessPlusPlus.FitnessPlusPlusDataSet10TableAdapters.EffectedUserTableAdapter();
               ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.fitnessPlusPlusDataSet7)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.effectedUserBindingSource)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.fitnessPlusPlusDataSet10)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.effectedUserBindingSource1)).BeginInit();
               this.SuspendLayout();
               // 
               // dataGridView1
               // 
               this.dataGridView1.AutoGenerateColumns = false;
               this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
               this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernameDataGridViewTextBoxColumn,
            this.diseaseNameDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
               this.dataGridView1.DataSource = this.effectedUserBindingSource1;
               this.dataGridView1.Location = new System.Drawing.Point(45, 39);
               this.dataGridView1.Name = "dataGridView1";
               this.dataGridView1.Size = new System.Drawing.Size(876, 393);
               this.dataGridView1.TabIndex = 0;
               this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
               // 
               // fitnessPlusPlusDataSet7
               // 
               this.fitnessPlusPlusDataSet7.DataSetName = "FitnessPlusPlusDataSet7";
               this.fitnessPlusPlusDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
               // 
               // effectedUserBindingSource
               // 
               this.effectedUserBindingSource.DataMember = "EffectedUser";
               this.effectedUserBindingSource.DataSource = this.fitnessPlusPlusDataSet7;
               // 
               // effectedUserTableAdapter
               // 
               this.effectedUserTableAdapter.ClearBeforeFill = true;
               // 
               // usernameDataGridViewTextBoxColumn
               // 
               this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
               this.usernameDataGridViewTextBoxColumn.HeaderText = "username";
               this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
               // 
               // diseaseNameDataGridViewTextBoxColumn
               // 
               this.diseaseNameDataGridViewTextBoxColumn.DataPropertyName = "DiseaseName";
               this.diseaseNameDataGridViewTextBoxColumn.HeaderText = "DiseaseName";
               this.diseaseNameDataGridViewTextBoxColumn.Name = "diseaseNameDataGridViewTextBoxColumn";
               // 
               // dateDataGridViewTextBoxColumn
               // 
               this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
               this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
               this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
               // 
               // button1
               // 
               this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
               this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.button1.Location = new System.Drawing.Point(26, 459);
               this.button1.Name = "button1";
               this.button1.Size = new System.Drawing.Size(134, 31);
               this.button1.TabIndex = 9;
               this.button1.Text = "BACK";
               this.button1.UseVisualStyleBackColor = false;
               this.button1.Click += new System.EventHandler(this.button1_Click);
               // 
               // fitnessPlusPlusDataSet10
               // 
               this.fitnessPlusPlusDataSet10.DataSetName = "FitnessPlusPlusDataSet10";
               this.fitnessPlusPlusDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
               // 
               // effectedUserBindingSource1
               // 
               this.effectedUserBindingSource1.DataMember = "EffectedUser";
               this.effectedUserBindingSource1.DataSource = this.fitnessPlusPlusDataSet10;
               // 
               // effectedUserTableAdapter1
               // 
               this.effectedUserTableAdapter1.ClearBeforeFill = true;
               // 
               // viewhistory
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
               this.ClientSize = new System.Drawing.Size(984, 511);
               this.Controls.Add(this.button1);
               this.Controls.Add(this.dataGridView1);
               this.Name = "viewhistory";
               this.Text = "viewhistory";
               this.Load += new System.EventHandler(this.viewhistory_Load);
               ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.fitnessPlusPlusDataSet7)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.effectedUserBindingSource)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.fitnessPlusPlusDataSet10)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.effectedUserBindingSource1)).EndInit();
               this.ResumeLayout(false);

          }

          #endregion

          private System.Windows.Forms.DataGridView dataGridView1;
          private FitnessPlusPlusDataSet7 fitnessPlusPlusDataSet7;
          private System.Windows.Forms.BindingSource effectedUserBindingSource;
          private FitnessPlusPlusDataSet7TableAdapters.EffectedUserTableAdapter effectedUserTableAdapter;
          private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
          private System.Windows.Forms.DataGridViewTextBoxColumn diseaseNameDataGridViewTextBoxColumn;
          private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
          private System.Windows.Forms.Button button1;
          private FitnessPlusPlusDataSet10 fitnessPlusPlusDataSet10;
          private System.Windows.Forms.BindingSource effectedUserBindingSource1;
          private FitnessPlusPlusDataSet10TableAdapters.EffectedUserTableAdapter effectedUserTableAdapter1;
     }
}