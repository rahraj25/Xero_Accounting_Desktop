﻿namespace CourierPro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTracking = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCars = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.DepotLocations = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIM = new System.Windows.Forms.Button();
            this.btnAccounts = new System.Windows.Forms.Button();
            this.btnDepotMngemnt = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnTracking);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnCars);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.DepotLocations);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnIM);
            this.groupBox1.Controls.Add(this.btnAccounts);
            this.groupBox1.Controls.Add(this.btnDepotMngemnt);
            this.groupBox1.Location = new System.Drawing.Point(18, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1148, 537);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(754, 256);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Vehicles";
            // 
            // btnTracking
            // 
            this.btnTracking.BackgroundImage = global::CourierPro.Properties.Resources.map_marker;
            this.btnTracking.Enabled = false;
            this.btnTracking.Location = new System.Drawing.Point(500, 313);
            this.btnTracking.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTracking.Name = "btnTracking";
            this.btnTracking.Size = new System.Drawing.Size(186, 174);
            this.btnTracking.TabIndex = 10;
            this.btnTracking.UseVisualStyleBackColor = true;
            this.btnTracking.Click += new System.EventHandler(this.btnTracking_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(569, 256);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tracking";
            // 
            // btnCars
            // 
            this.btnCars.BackgroundImage = global::CourierPro.Properties.Resources.truck;
            this.btnCars.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCars.Enabled = false;
            this.btnCars.Location = new System.Drawing.Point(695, 313);
            this.btnCars.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCars.Name = "btnCars";
            this.btnCars.Size = new System.Drawing.Size(186, 174);
            this.btnCars.TabIndex = 8;
            this.btnCars.UseVisualStyleBackColor = true;
            this.btnCars.Click += new System.EventHandler(this.btnCars_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 118);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Location";
            // 
            // DepotLocations
            // 
            this.DepotLocations.FormattingEnabled = true;
            this.DepotLocations.Items.AddRange(new object[] {
            "Auckland - Central",
            "Auckland - Waitakere",
            "Auckland - Manukau",
            "Auckland - Howick",
            "Hamilton",
            "Thames",
            "Tauranga",
            "Rotorua",
            "Taupo",
            "New Plymouth",
            "Palmerston North",
            "Wellington - Johnsonville",
            "Wellington - Miramar"});
            this.DepotLocations.Location = new System.Drawing.Point(303, 114);
            this.DepotLocations.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DepotLocations.Name = "DepotLocations";
            this.DepotLocations.Size = new System.Drawing.Size(685, 28);
            this.DepotLocations.TabIndex = 1;
            this.DepotLocations.SelectedIndexChanged += new System.EventHandler(this.DepotLocationSelected);
            this.DepotLocations.SelectionChangeCommitted += new System.EventHandler(this.DepotLocationSelected);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(902, 256);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Inventory Management";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 256);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Accounts";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 256);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Depot Management";
            // 
            // btnIM
            // 
            this.btnIM.BackgroundImage = global::CourierPro.Properties.Resources.settings;
            this.btnIM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnIM.Enabled = false;
            this.btnIM.Location = new System.Drawing.Point(890, 313);
            this.btnIM.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnIM.Name = "btnIM";
            this.btnIM.Size = new System.Drawing.Size(186, 174);
            this.btnIM.TabIndex = 2;
            this.btnIM.UseVisualStyleBackColor = true;
            this.btnIM.Click += new System.EventHandler(this.btnIM_Click);
            // 
            // btnAccounts
            // 
            this.btnAccounts.BackgroundImage = global::CourierPro.Properties.Resources.money;
            this.btnAccounts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAccounts.Enabled = false;
            this.btnAccounts.Location = new System.Drawing.Point(305, 313);
            this.btnAccounts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAccounts.Name = "btnAccounts";
            this.btnAccounts.Size = new System.Drawing.Size(186, 174);
            this.btnAccounts.TabIndex = 1;
            this.btnAccounts.UseVisualStyleBackColor = true;
            this.btnAccounts.Click += new System.EventHandler(this.btnAccounts_Click);
            // 
            // btnDepotMngemnt
            // 
            this.btnDepotMngemnt.BackgroundImage = global::CourierPro.Properties.Resources.home;
            this.btnDepotMngemnt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDepotMngemnt.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnDepotMngemnt.Enabled = false;
            this.btnDepotMngemnt.Location = new System.Drawing.Point(110, 313);
            this.btnDepotMngemnt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDepotMngemnt.Name = "btnDepotMngemnt";
            this.btnDepotMngemnt.Size = new System.Drawing.Size(186, 174);
            this.btnDepotMngemnt.TabIndex = 0;
            this.btnDepotMngemnt.Text = "button1";
            this.btnDepotMngemnt.UseVisualStyleBackColor = true;
            this.btnDepotMngemnt.Click += new System.EventHandler(this.btnDepotMngemnt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 578);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Accounts";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDepotMngemnt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIM;
        private System.Windows.Forms.Button btnAccounts;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCars;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnTracking;
        public System.Windows.Forms.ComboBox DepotLocations;
    }
}

