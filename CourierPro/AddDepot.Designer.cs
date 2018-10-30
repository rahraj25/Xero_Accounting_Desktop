namespace CourierPro
{
    partial class AddDepot
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
            this.txtdepotName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdepotContact = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdepotAddress = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtdepotName
            // 
            this.txtdepotName.Location = new System.Drawing.Point(158, 75);
            this.txtdepotName.Name = "txtdepotName";
            this.txtdepotName.Size = new System.Drawing.Size(214, 26);
            this.txtdepotName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Depot name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Depot contact :";
            // 
            // txtdepotContact
            // 
            this.txtdepotContact.Location = new System.Drawing.Point(158, 143);
            this.txtdepotContact.Name = "txtdepotContact";
            this.txtdepotContact.Size = new System.Drawing.Size(214, 26);
            this.txtdepotContact.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Depot address :";
            // 
            // txtdepotAddress
            // 
            this.txtdepotAddress.Location = new System.Drawing.Point(158, 218);
            this.txtdepotAddress.Name = "txtdepotAddress";
            this.txtdepotAddress.Size = new System.Drawing.Size(214, 26);
            this.txtdepotAddress.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(106, 301);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(177, 53);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // AddDepot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 412);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtdepotAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtdepotContact);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtdepotName);
            this.Name = "AddDepot";
            this.Text = "AddDepot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtdepotName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtdepotContact;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdepotAddress;
        private System.Windows.Forms.Button btnSave;
    }
}