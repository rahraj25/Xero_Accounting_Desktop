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
            this.SuspendLayout();
            // 
            // cbVehicleType
            // 
            this.cbVehicleType.FormattingEnabled = true;
            this.cbVehicleType.Location = new System.Drawing.Point(155, 60);
            this.cbVehicleType.Name = "cbVehicleType";
            this.cbVehicleType.Size = new System.Drawing.Size(154, 28);
            this.cbVehicleType.TabIndex = 0;
            // 
            // txtRego
            // 
            this.txtRego.Location = new System.Drawing.Point(155, 132);
            this.txtRego.Name = "txtRego";
            this.txtRego.Size = new System.Drawing.Size(154, 26);
            this.txtRego.TabIndex = 1;
            // 
            // lblrego
            // 
            this.lblrego.AutoSize = true;
            this.lblrego.Location = new System.Drawing.Point(13, 135);
            this.lblrego.Name = "lblrego";
            this.lblrego.Size = new System.Drawing.Size(56, 20);
            this.lblrego.TabIndex = 2;
            this.lblrego.Text = "Rego: ";
            // 
            // lbltype
            // 
            this.lbltype.AutoSize = true;
            this.lbltype.Location = new System.Drawing.Point(13, 60);
            this.lbltype.Name = "lbltype";
            this.lbltype.Size = new System.Drawing.Size(107, 20);
            this.lbltype.TabIndex = 3;
            this.lbltype.Text = "Vehicle Type: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "License class";
            // 
            // txtLicense
            // 
            this.txtLicense.Location = new System.Drawing.Point(155, 197);
            this.txtLicense.Name = "txtLicense";
            this.txtLicense.Size = new System.Drawing.Size(154, 26);
            this.txtLicense.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Purchase date";
            // 
            // txtPurchase
            // 
            this.txtPurchase.Location = new System.Drawing.Point(155, 263);
            this.txtPurchase.Name = "txtPurchase";
            this.txtPurchase.Size = new System.Drawing.Size(154, 26);
            this.txtPurchase.TabIndex = 6;
            // 
            // NewVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPurchase);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLicense);
            this.Controls.Add(this.lbltype);
            this.Controls.Add(this.lblrego);
            this.Controls.Add(this.txtRego);
            this.Controls.Add(this.cbVehicleType);
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
    }
}