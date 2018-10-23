namespace CourierPro
{
    partial class NewVehicle
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
            this.cbVehicleType = new System.Windows.Forms.ComboBox();
            this.txtRego = new System.Windows.Forms.TextBox();
            this.lblrego = new System.Windows.Forms.Label();
            this.lbltype = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLicense = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPurchase = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.vehiclePurchaseCal = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // cbVehicleType
            // 
            this.cbVehicleType.FormattingEnabled = true;
            this.cbVehicleType.Location = new System.Drawing.Point(103, 39);
            this.cbVehicleType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbVehicleType.Name = "cbVehicleType";
            this.cbVehicleType.Size = new System.Drawing.Size(104, 21);
            this.cbVehicleType.TabIndex = 0;
            // 
            // txtRego
            // 
            this.txtRego.Location = new System.Drawing.Point(103, 86);
            this.txtRego.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRego.Name = "txtRego";
            this.txtRego.Size = new System.Drawing.Size(104, 20);
            this.txtRego.TabIndex = 1;
            // 
            // lblrego
            // 
            this.lblrego.AutoSize = true;
            this.lblrego.Location = new System.Drawing.Point(9, 88);
            this.lblrego.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblrego.Name = "lblrego";
            this.lblrego.Size = new System.Drawing.Size(39, 13);
            this.lblrego.TabIndex = 2;
            this.lblrego.Text = "Rego: ";
            // 
            // lbltype
            // 
            this.lbltype.AutoSize = true;
            this.lbltype.Location = new System.Drawing.Point(9, 39);
            this.lbltype.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltype.Name = "lbltype";
            this.lbltype.Size = new System.Drawing.Size(75, 13);
            this.lbltype.TabIndex = 3;
            this.lbltype.Text = "Vehicle Type: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 130);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "License class";
            // 
            // txtLicense
            // 
            this.txtLicense.Location = new System.Drawing.Point(103, 128);
            this.txtLicense.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLicense.Name = "txtLicense";
            this.txtLicense.Size = new System.Drawing.Size(104, 20);
            this.txtLicense.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 178);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Purchase date";
            // 
            // txtPurchase
            // 
            this.txtPurchase.Location = new System.Drawing.Point(103, 171);
            this.txtPurchase.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPurchase.Name = "txtPurchase";
            this.txtPurchase.Size = new System.Drawing.Size(104, 20);
            this.txtPurchase.TabIndex = 6;
            this.txtPurchase.Click += new System.EventHandler(this.txtPurchase_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // vehiclePurchaseCal
            // 
            this.vehiclePurchaseCal.Location = new System.Drawing.Point(278, 29);
            this.vehiclePurchaseCal.Name = "vehiclePurchaseCal";
            this.vehiclePurchaseCal.TabIndex = 9;
            this.vehiclePurchaseCal.Visible = false;
            this.vehiclePurchaseCal.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.vehiclePurchaseCal_DateSelected);
            // 
            // NewVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.vehiclePurchaseCal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPurchase);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLicense);
            this.Controls.Add(this.lbltype);
            this.Controls.Add(this.lblrego);
            this.Controls.Add(this.txtRego);
            this.Controls.Add(this.cbVehicleType);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "NewVehicle";
            this.Text = "NewVehicle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbVehicleType;
        private System.Windows.Forms.TextBox txtRego;
        private System.Windows.Forms.Label lblrego;
        private System.Windows.Forms.Label lbltype;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLicense;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPurchase;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MonthCalendar vehiclePurchaseCal;
    }
}