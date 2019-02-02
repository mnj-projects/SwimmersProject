namespace SwimmersProject
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listSwimmers = new System.Windows.Forms.ListView();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listOrdered = new System.Windows.Forms.ListView();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnMales = new System.Windows.Forms.Button();
            this.btnFemales = new System.Windows.Forms.Button();
            this.btnSwimmerAge = new System.Windows.Forms.Button();
            this.btnBestTimers = new System.Windows.Forms.Button();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnBestGroup3 = new System.Windows.Forms.Button();
            this.btnBestGroup2 = new System.Windows.Forms.Button();
            this.btnBestGroup1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel4, 0, 1);
            this.tableLayoutPanel1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.26849F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.73152F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1048, 514);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(518, 421);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listSwimmers);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(515, 412);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List of Swimmers";
            // 
            // listSwimmers
            // 
            this.listSwimmers.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listSwimmers.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.listSwimmers.LabelWrap = false;
            this.listSwimmers.Location = new System.Drawing.Point(9, 18);
            this.listSwimmers.Name = "listSwimmers";
            this.listSwimmers.Size = new System.Drawing.Size(500, 380);
            this.listSwimmers.TabIndex = 0;
            this.listSwimmers.UseCompatibleStateImageBehavior = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.groupBox2);
            this.flowLayoutPanel2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(527, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(518, 421);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listOrdered);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(515, 412);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ordered Swimmers Based On A Criteria";
            // 
            // listOrdered
            // 
            this.listOrdered.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listOrdered.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.listOrdered.LabelWrap = false;
            this.listOrdered.Location = new System.Drawing.Point(6, 18);
            this.listOrdered.Name = "listOrdered";
            this.listOrdered.Size = new System.Drawing.Size(503, 380);
            this.listOrdered.TabIndex = 0;
            this.listOrdered.UseCompatibleStateImageBehavior = false;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.groupBox3);
            this.flowLayoutPanel3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(527, 430);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(518, 80);
            this.flowLayoutPanel3.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnMales);
            this.groupBox3.Controls.Add(this.btnFemales);
            this.groupBox3.Controls.Add(this.btnSwimmerAge);
            this.groupBox3.Controls.Add(this.btnBestTimers);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(515, 68);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Parameter Arrange";
            // 
            // btnMales
            // 
            this.btnMales.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnMales.Location = new System.Drawing.Point(389, 21);
            this.btnMales.Name = "btnMales";
            this.btnMales.Size = new System.Drawing.Size(120, 33);
            this.btnMales.TabIndex = 0;
            this.btnMales.Text = "Male Swimmers";
            this.btnMales.UseVisualStyleBackColor = true;
            this.btnMales.Click += new System.EventHandler(this.btnMales_Click);
            // 
            // btnFemales
            // 
            this.btnFemales.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnFemales.Location = new System.Drawing.Point(241, 21);
            this.btnFemales.Name = "btnFemales";
            this.btnFemales.Size = new System.Drawing.Size(142, 33);
            this.btnFemales.TabIndex = 0;
            this.btnFemales.Text = "Female Swimmers";
            this.btnFemales.UseVisualStyleBackColor = true;
            this.btnFemales.Click += new System.EventHandler(this.btnFemales_Click);
            // 
            // btnSwimmerAge
            // 
            this.btnSwimmerAge.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSwimmerAge.Location = new System.Drawing.Point(114, 21);
            this.btnSwimmerAge.Name = "btnSwimmerAge";
            this.btnSwimmerAge.Size = new System.Drawing.Size(121, 33);
            this.btnSwimmerAge.TabIndex = 0;
            this.btnSwimmerAge.Text = "Swimmers Age";
            this.btnSwimmerAge.UseVisualStyleBackColor = true;
            this.btnSwimmerAge.Click += new System.EventHandler(this.btnSwimmerAge_Click);
            // 
            // btnBestTimers
            // 
            this.btnBestTimers.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnBestTimers.Location = new System.Drawing.Point(6, 21);
            this.btnBestTimers.Name = "btnBestTimers";
            this.btnBestTimers.Size = new System.Drawing.Size(102, 33);
            this.btnBestTimers.TabIndex = 0;
            this.btnBestTimers.Text = "Best Timers";
            this.btnBestTimers.UseVisualStyleBackColor = true;
            this.btnBestTimers.Click += new System.EventHandler(this.btnBestTimers_Click);
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.groupBox4);
            this.flowLayoutPanel4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 430);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(518, 80);
            this.flowLayoutPanel4.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnBestGroup3);
            this.groupBox4.Controls.Add(this.btnBestGroup2);
            this.groupBox4.Controls.Add(this.btnBestGroup1);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(515, 68);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Group Arrange";
            // 
            // btnBestGroup3
            // 
            this.btnBestGroup3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnBestGroup3.Location = new System.Drawing.Point(349, 21);
            this.btnBestGroup3.Name = "btnBestGroup3";
            this.btnBestGroup3.Size = new System.Drawing.Size(158, 33);
            this.btnBestGroup3.TabIndex = 0;
            this.btnBestGroup3.Text = "Best of Group 3";
            this.btnBestGroup3.UseVisualStyleBackColor = true;
            this.btnBestGroup3.Click += new System.EventHandler(this.btnBestGroup3_Click);
            // 
            // btnBestGroup2
            // 
            this.btnBestGroup2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnBestGroup2.Location = new System.Drawing.Point(173, 21);
            this.btnBestGroup2.Name = "btnBestGroup2";
            this.btnBestGroup2.Size = new System.Drawing.Size(170, 33);
            this.btnBestGroup2.TabIndex = 0;
            this.btnBestGroup2.Text = "Best of Group 2";
            this.btnBestGroup2.UseVisualStyleBackColor = true;
            this.btnBestGroup2.Click += new System.EventHandler(this.btnBestGroup2_Click);
            // 
            // btnBestGroup1
            // 
            this.btnBestGroup1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnBestGroup1.Location = new System.Drawing.Point(9, 21);
            this.btnBestGroup1.Name = "btnBestGroup1";
            this.btnBestGroup1.Size = new System.Drawing.Size(158, 33);
            this.btnBestGroup1.TabIndex = 0;
            this.btnBestGroup1.Text = "Best of Group 1";
            this.btnBestGroup1.UseVisualStyleBackColor = true;
            this.btnBestGroup1.Click += new System.EventHandler(this.btnBestGroup1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1067, 521);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Swimmers Nightmare";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listSwimmers;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listOrdered;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnMales;
        private System.Windows.Forms.Button btnFemales;
        private System.Windows.Forms.Button btnSwimmerAge;
        private System.Windows.Forms.Button btnBestTimers;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnBestGroup3;
        private System.Windows.Forms.Button btnBestGroup2;
        private System.Windows.Forms.Button btnBestGroup1;
    }
}

