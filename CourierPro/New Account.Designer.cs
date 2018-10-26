namespace CourierPro
{
    partial class New_Account
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
            this.text_account_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_account_type = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.text_first_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.text_city = new System.Windows.Forms.TextBox();
            this.text_last_name = new System.Windows.Forms.TextBox();
            this.btn_save_account = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // text_account_id
            // 
            this.text_account_id.Location = new System.Drawing.Point(166, 17);
            this.text_account_id.Name = "text_account_id";
            this.text_account_id.Size = new System.Drawing.Size(100, 20);
            this.text_account_id.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Account ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Account Type";
            // 
            // cb_account_type
            // 
            this.cb_account_type.FormattingEnabled = true;
            this.cb_account_type.Location = new System.Drawing.Point(145, 44);
            this.cb_account_type.Name = "cb_account_type";
            this.cb_account_type.Size = new System.Drawing.Size(121, 21);
            this.cb_account_type.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "First Name";
            // 
            // text_first_name
            // 
            this.text_first_name.Location = new System.Drawing.Point(166, 69);
            this.text_first_name.Name = "text_first_name";
            this.text_first_name.Size = new System.Drawing.Size(100, 20);
            this.text_first_name.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "City";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Last Name";
            // 
            // text_city
            // 
            this.text_city.Location = new System.Drawing.Point(166, 120);
            this.text_city.Name = "text_city";
            this.text_city.Size = new System.Drawing.Size(100, 20);
            this.text_city.TabIndex = 8;
            // 
            // text_last_name
            // 
            this.text_last_name.Location = new System.Drawing.Point(166, 94);
            this.text_last_name.Name = "text_last_name";
            this.text_last_name.Size = new System.Drawing.Size(100, 20);
            this.text_last_name.TabIndex = 9;
            // 
            // btn_save_account
            // 
            this.btn_save_account.Location = new System.Drawing.Point(25, 157);
            this.btn_save_account.Name = "btn_save_account";
            this.btn_save_account.Size = new System.Drawing.Size(75, 23);
            this.btn_save_account.TabIndex = 10;
            this.btn_save_account.Text = "Save";
            this.btn_save_account.UseVisualStyleBackColor = true;
            // 
            // New_Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_save_account);
            this.Controls.Add(this.text_last_name);
            this.Controls.Add(this.text_city);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.text_first_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_account_type);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_account_id);
            this.Name = "New_Account";
            this.Text = "New_Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_account_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_account_type;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_first_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox text_city;
        private System.Windows.Forms.TextBox text_last_name;
        private System.Windows.Forms.Button btn_save_account;
    }
}