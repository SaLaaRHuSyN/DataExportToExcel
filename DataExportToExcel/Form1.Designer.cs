namespace DataExportToExcel
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.wATERandPOWERDataSet = new DataExportToExcel.WATERandPOWERDataSet();
            this.aREABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aREATableAdapter = new DataExportToExcel.WATERandPOWERDataSetTableAdapters.AREATableAdapter();
            this.aREAIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aREADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wATERandPOWERDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aREABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 392);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 67);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(14, 9);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "Export";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aREAIDDataGridViewTextBoxColumn,
            this.aREADataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.aREABindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(700, 392);
            this.dataGridView1.TabIndex = 1;
            // 
            // wATERandPOWERDataSet
            // 
            this.wATERandPOWERDataSet.DataSetName = "WATERandPOWERDataSet";
            this.wATERandPOWERDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aREABindingSource
            // 
            this.aREABindingSource.DataMember = "AREA";
            this.aREABindingSource.DataSource = this.wATERandPOWERDataSet;
            // 
            // aREATableAdapter
            // 
            this.aREATableAdapter.ClearBeforeFill = true;
            // 
            // aREAIDDataGridViewTextBoxColumn
            // 
            this.aREAIDDataGridViewTextBoxColumn.DataPropertyName = "AREA_ID";
            this.aREAIDDataGridViewTextBoxColumn.HeaderText = "AREA_ID";
            this.aREAIDDataGridViewTextBoxColumn.Name = "aREAIDDataGridViewTextBoxColumn";
            this.aREAIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aREADataGridViewTextBoxColumn
            // 
            this.aREADataGridViewTextBoxColumn.DataPropertyName = "AREA";
            this.aREADataGridViewTextBoxColumn.HeaderText = "AREA";
            this.aREADataGridViewTextBoxColumn.Name = "aREADataGridViewTextBoxColumn";
            this.aREADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 459);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wATERandPOWERDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aREABindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private WATERandPOWERDataSet wATERandPOWERDataSet;
        private System.Windows.Forms.BindingSource aREABindingSource;
        private WATERandPOWERDataSetTableAdapters.AREATableAdapter aREATableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn aREAIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aREADataGridViewTextBoxColumn;
    }
}

