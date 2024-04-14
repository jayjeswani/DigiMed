namespace wheaterstation
{
    partial class instructions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(instructions));
            this.butFindInstruction = new System.Windows.Forms.Button();
            this.cmdClose = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtWindspeed = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.txtWaterLevel = new System.Windows.Forms.TextBox();
            this.txtTemperature = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRainfall = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCrop = new System.Windows.Forms.TextBox();
            this.txtPrediction = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // butFindInstruction
            // 
            this.butFindInstruction.Location = new System.Drawing.Point(862, 489);
            this.butFindInstruction.Name = "butFindInstruction";
            this.butFindInstruction.Size = new System.Drawing.Size(10, 35);
            this.butFindInstruction.TabIndex = 109;
            this.butFindInstruction.Text = "Find Instruction";
            this.butFindInstruction.UseVisualStyleBackColor = true;
            this.butFindInstruction.Visible = false;
            this.butFindInstruction.Click += new System.EventHandler(this.butFindInstruction_Click);
            // 
            // cmdClose
            // 
            this.cmdClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdClose.Location = new System.Drawing.Point(925, 530);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(10, 40);
            this.cmdClose.TabIndex = 110;
            this.cmdClose.Text = "Close Instruction Window";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Visible = false;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(287, 552);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(10, 91);
            this.dataGridView1.TabIndex = 111;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtWindspeed);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.btnShow);
            this.groupBox1.Controls.Add(this.txtWaterLevel);
            this.groupBox1.Controls.Add(this.txtTemperature);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtRainfall);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(146, 318);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(655, 87);
            this.groupBox1.TabIndex = 112;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Show Instructions From Database";
            // 
            // txtWindspeed
            // 
            this.txtWindspeed.Location = new System.Drawing.Point(321, 51);
            this.txtWindspeed.Name = "txtWindspeed";
            this.txtWindspeed.Size = new System.Drawing.Size(60, 22);
            this.txtWindspeed.TabIndex = 100;
            this.txtWindspeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(318, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 99;
            this.label1.Text = "Windspeed";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(558, 44);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(72, 34);
            this.btnExit.TabIndex = 98;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(433, 45);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(119, 34);
            this.btnShow.TabIndex = 6;
            this.btnShow.Text = "Perdiction";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // txtWaterLevel
            // 
            this.txtWaterLevel.Location = new System.Drawing.Point(223, 52);
            this.txtWaterLevel.Name = "txtWaterLevel";
            this.txtWaterLevel.Size = new System.Drawing.Size(60, 22);
            this.txtWaterLevel.TabIndex = 5;
            this.txtWaterLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTemperature
            // 
            this.txtTemperature.Location = new System.Drawing.Point(125, 52);
            this.txtTemperature.Name = "txtTemperature";
            this.txtTemperature.Size = new System.Drawing.Size(60, 22);
            this.txtTemperature.TabIndex = 4;
            this.txtTemperature.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Rainfall";
            // 
            // txtRainfall
            // 
            this.txtRainfall.Location = new System.Drawing.Point(24, 52);
            this.txtRainfall.Name = "txtRainfall";
            this.txtRainfall.Size = new System.Drawing.Size(60, 22);
            this.txtRainfall.TabIndex = 3;
            this.txtRainfall.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(226, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Humidty";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(135, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Temp";
            // 
            // txtCrop
            // 
            this.txtCrop.Location = new System.Drawing.Point(360, 484);
            this.txtCrop.Name = "txtCrop";
            this.txtCrop.Size = new System.Drawing.Size(200, 20);
            this.txtCrop.TabIndex = 113;
            // 
            // txtPrediction
            // 
            this.txtPrediction.Location = new System.Drawing.Point(360, 422);
            this.txtPrediction.Multiline = true;
            this.txtPrediction.Name = "txtPrediction";
            this.txtPrediction.Size = new System.Drawing.Size(200, 56);
            this.txtPrediction.TabIndex = 114;
            // 
            // instructions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(932, 575);
            this.Controls.Add(this.txtPrediction);
            this.Controls.Add(this.txtCrop);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.butFindInstruction);
            this.Name = "instructions";
            this.Text = "instructions";
            this.Load += new System.EventHandler(this.instructions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butFindInstruction;
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.TextBox txtWaterLevel;
        private System.Windows.Forms.TextBox txtTemperature;
        private System.Windows.Forms.TextBox txtRainfall;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtWindspeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCrop;
        private System.Windows.Forms.TextBox txtPrediction;
    }
}