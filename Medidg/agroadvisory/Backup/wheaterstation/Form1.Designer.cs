namespace wheaterstation
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
            this.label1 = new System.Windows.Forms.Label();
            this.infoDataSet = new wheaterstation.InfoDataSet();
            this.infoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.infoDataSet1 = new wheaterstation.InfoDataSet1();
            this.agrofieldBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agrofieldTableAdapter = new wheaterstation.InfoDataSet1TableAdapters.agrofieldTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.humidityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.windspeedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perdicationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.infoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agrofieldBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wheter station for agricultre";
            // 
            // infoDataSet
            // 
            this.infoDataSet.DataSetName = "InfoDataSet";
            this.infoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // infoDataSetBindingSource
            // 
            this.infoDataSetBindingSource.DataSource = this.infoDataSet;
            this.infoDataSetBindingSource.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.tempDataGridViewTextBoxColumn,
            this.humidityDataGridViewTextBoxColumn,
            this.windspeedDataGridViewTextBoxColumn,
            this.perdicationDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.agrofieldBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(98, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(555, 222);
            this.dataGridView1.TabIndex = 1;
            // 
            // infoDataSet1
            // 
            this.infoDataSet1.DataSetName = "InfoDataSet1";
            this.infoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // agrofieldBindingSource
            // 
            this.agrofieldBindingSource.DataMember = "agrofield";
            this.agrofieldBindingSource.DataSource = this.infoDataSet1;
            // 
            // agrofieldTableAdapter
            // 
            this.agrofieldTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // tempDataGridViewTextBoxColumn
            // 
            this.tempDataGridViewTextBoxColumn.DataPropertyName = "temp";
            this.tempDataGridViewTextBoxColumn.HeaderText = "temp";
            this.tempDataGridViewTextBoxColumn.Name = "tempDataGridViewTextBoxColumn";
            // 
            // humidityDataGridViewTextBoxColumn
            // 
            this.humidityDataGridViewTextBoxColumn.DataPropertyName = "humidity";
            this.humidityDataGridViewTextBoxColumn.HeaderText = "humidity";
            this.humidityDataGridViewTextBoxColumn.Name = "humidityDataGridViewTextBoxColumn";
            // 
            // windspeedDataGridViewTextBoxColumn
            // 
            this.windspeedDataGridViewTextBoxColumn.DataPropertyName = "windspeed";
            this.windspeedDataGridViewTextBoxColumn.HeaderText = "windspeed";
            this.windspeedDataGridViewTextBoxColumn.Name = "windspeedDataGridViewTextBoxColumn";
            // 
            // perdicationDataGridViewTextBoxColumn
            // 
            this.perdicationDataGridViewTextBoxColumn.DataPropertyName = "perdication";
            this.perdicationDataGridViewTextBoxColumn.HeaderText = "perdication";
            this.perdicationDataGridViewTextBoxColumn.Name = "perdicationDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(773, 311);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.infoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agrofieldBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource infoDataSetBindingSource;
        private InfoDataSet infoDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private InfoDataSet1 infoDataSet1;
        private System.Windows.Forms.BindingSource agrofieldBindingSource;
        private wheaterstation.InfoDataSet1TableAdapters.agrofieldTableAdapter agrofieldTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn humidityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn windspeedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perdicationDataGridViewTextBoxColumn;
    }
}

