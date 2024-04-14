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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.infoDataSet = new wheaterstation.InfoDataSet();
            this.infoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agrofieldBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.infoDataSet1 = new wheaterstation.InfoDataSet1();
            this.agrofieldTableAdapter = new wheaterstation.InfoDataSet1TableAdapters.agrofieldTableAdapter();
            this.infoDataSet2 = new wheaterstation.InfoDataSet2();
            this.agrofieldBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.agrofieldTableAdapter1 = new wheaterstation.InfoDataSet2TableAdapters.agrofieldTableAdapter();
            this.infoDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.infoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agrofieldBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agrofieldBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(432, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dataset ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            // agrofieldBindingSource
            // 
            this.agrofieldBindingSource.DataMember = "agrofield";
            this.agrofieldBindingSource.DataSource = this.infoDataSet1;
            // 
            // infoDataSet1
            // 
            this.infoDataSet1.DataSetName = "InfoDataSet1";
            this.infoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // agrofieldTableAdapter
            // 
            this.agrofieldTableAdapter.ClearBeforeFill = true;
            // 
            // infoDataSet2
            // 
            this.infoDataSet2.DataSetName = "InfoDataSet2";
            this.infoDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // agrofieldBindingSource1
            // 
            this.agrofieldBindingSource1.DataMember = "agrofield";
            this.agrofieldBindingSource1.DataSource = this.infoDataSet2;
            // 
            // agrofieldTableAdapter1
            // 
            this.agrofieldTableAdapter1.ClearBeforeFill = true;
            // 
            // infoDataSet2BindingSource
            // 
            this.infoDataSet2BindingSource.DataSource = this.infoDataSet2;
            this.infoDataSet2BindingSource.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(134, 255);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(657, 210);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(811, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "upload";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(810, 382);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 25);
            this.button2.TabIndex = 3;
            this.button2.Text = "Instuctions";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(976, 532);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.infoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agrofieldBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agrofieldBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource infoDataSetBindingSource;
        private InfoDataSet infoDataSet;
        private InfoDataSet1 infoDataSet1;
        private System.Windows.Forms.BindingSource agrofieldBindingSource;
        private wheaterstation.InfoDataSet1TableAdapters.agrofieldTableAdapter agrofieldTableAdapter;
        private InfoDataSet2 infoDataSet2;
        private System.Windows.Forms.BindingSource agrofieldBindingSource1;
        private InfoDataSet2TableAdapters.agrofieldTableAdapter agrofieldTableAdapter1;
        private System.Windows.Forms.BindingSource infoDataSet2BindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

