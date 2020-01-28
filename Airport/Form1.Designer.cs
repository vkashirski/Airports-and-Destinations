namespace Airport
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
            this.lbAirports = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMostExpensiveDestination = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAverageDistanceDestinations = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btAddAirport = new System.Windows.Forms.Button();
            this.btDeleteAirport = new System.Windows.Forms.Button();
            this.btAddDestination = new System.Windows.Forms.Button();
            this.lbDestinations = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbAirports
            // 
            this.lbAirports.FormattingEnabled = true;
            this.lbAirports.Location = new System.Drawing.Point(12, 29);
            this.lbAirports.Name = "lbAirports";
            this.lbAirports.Size = new System.Drawing.Size(247, 264);
            this.lbAirports.TabIndex = 0;
            this.lbAirports.SelectedIndexChanged += new System.EventHandler(this.lbAirports_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbMostExpensiveDestination);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbAverageDistanceDestinations);
            this.groupBox1.Location = new System.Drawing.Point(280, 294);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 102);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Дестинации";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Најскапа дестинација";
            // 
            // tbMostExpensiveDestination
            // 
            this.tbMostExpensiveDestination.Location = new System.Drawing.Point(6, 35);
            this.tbMostExpensiveDestination.Name = "tbMostExpensiveDestination";
            this.tbMostExpensiveDestination.ReadOnly = true;
            this.tbMostExpensiveDestination.Size = new System.Drawing.Size(235, 20);
            this.tbMostExpensiveDestination.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Просечна должина на дестинациите";
            // 
            // tbAverageDistanceDestinations
            // 
            this.tbAverageDistanceDestinations.Location = new System.Drawing.Point(6, 74);
            this.tbAverageDistanceDestinations.Name = "tbAverageDistanceDestinations";
            this.tbAverageDistanceDestinations.ReadOnly = true;
            this.tbAverageDistanceDestinations.Size = new System.Drawing.Size(235, 20);
            this.tbAverageDistanceDestinations.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Аеродроми";
            // 
            // btAddAirport
            // 
            this.btAddAirport.Location = new System.Drawing.Point(12, 309);
            this.btAddAirport.Name = "btAddAirport";
            this.btAddAirport.Size = new System.Drawing.Size(247, 23);
            this.btAddAirport.TabIndex = 4;
            this.btAddAirport.Text = "Додади аеродром";
            this.btAddAirport.UseVisualStyleBackColor = true;
            this.btAddAirport.Click += new System.EventHandler(this.btAddAirport_Click);
            // 
            // btDeleteAirport
            // 
            this.btDeleteAirport.Location = new System.Drawing.Point(12, 341);
            this.btDeleteAirport.Name = "btDeleteAirport";
            this.btDeleteAirport.Size = new System.Drawing.Size(247, 23);
            this.btDeleteAirport.TabIndex = 5;
            this.btDeleteAirport.Text = "Избриши аеродром";
            this.btDeleteAirport.UseVisualStyleBackColor = true;
            this.btDeleteAirport.Click += new System.EventHandler(this.btDeleteAirport_Click);
            // 
            // btAddDestination
            // 
            this.btAddDestination.Location = new System.Drawing.Point(12, 373);
            this.btAddDestination.Name = "btAddDestination";
            this.btAddDestination.Size = new System.Drawing.Size(247, 23);
            this.btAddDestination.TabIndex = 6;
            this.btAddDestination.Text = "Додади дестинација";
            this.btAddDestination.UseVisualStyleBackColor = true;
            this.btAddDestination.Click += new System.EventHandler(this.btAddDestination_Click);
            // 
            // lbDestinations
            // 
            this.lbDestinations.Enabled = false;
            this.lbDestinations.ForeColor = System.Drawing.Color.Aqua;
            this.lbDestinations.FormattingEnabled = true;
            this.lbDestinations.Location = new System.Drawing.Point(280, 29);
            this.lbDestinations.Name = "lbDestinations";
            this.lbDestinations.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbDestinations.Size = new System.Drawing.Size(247, 264);
            this.lbDestinations.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Дестинации";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 412);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbDestinations);
            this.Controls.Add(this.btAddDestination);
            this.Controls.Add(this.btDeleteAirport);
            this.Controls.Add(this.btAddAirport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbAirports);
            this.Name = "Form1";
            this.Text = "Аеродроми";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbAirports;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMostExpensiveDestination;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAverageDistanceDestinations;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAddAirport;
        private System.Windows.Forms.Button btDeleteAirport;
        private System.Windows.Forms.Button btAddDestination;
        private System.Windows.Forms.ListBox lbDestinations;
        private System.Windows.Forms.Label label4;
    }
}

