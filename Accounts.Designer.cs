namespace CourierPro
{
    partial class Accounts
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
            this.dgAccounts = new System.Windows.Forms.DataGridView();
            this.btn_new_account = new System.Windows.Forms.Button();
            this.btn_update_account = new System.Windows.Forms.Button();
            this.button_delete_account = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgAccounts)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgAccounts
            // 
            this.dgAccounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgAccounts.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAccounts.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgAccounts.Location = new System.Drawing.Point(22, 22);
            this.dgAccounts.Name = "dgAccounts";
            this.dgAccounts.ReadOnly = true;
            this.dgAccounts.RowTemplate.Height = 28;
            this.dgAccounts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgAccounts.Size = new System.Drawing.Size(801, 437);
            this.dgAccounts.TabIndex = 0;
            // 
            // btn_new_account
            // 
            this.btn_new_account.Location = new System.Drawing.Point(22, 509);
            this.btn_new_account.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_new_account.Name = "btn_new_account";
            this.btn_new_account.Size = new System.Drawing.Size(112, 35);
            this.btn_new_account.TabIndex = 1;
            this.btn_new_account.Text = "New";
            this.btn_new_account.UseVisualStyleBackColor = true;
            this.btn_new_account.Click += new System.EventHandler(this.btn_new_account_Click);
            // 
            // btn_update_account
            // 
            this.btn_update_account.Location = new System.Drawing.Point(622, 507);
            this.btn_update_account.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_update_account.Name = "btn_update_account";
            this.btn_update_account.Size = new System.Drawing.Size(112, 35);
            this.btn_update_account.TabIndex = 2;
            this.btn_update_account.Text = "Update";
            this.btn_update_account.UseVisualStyleBackColor = true;
            // 
            // button_delete_account
            // 
            this.button_delete_account.Location = new System.Drawing.Point(753, 507);
            this.button_delete_account.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_delete_account.Name = "button_delete_account";
            this.button_delete_account.Size = new System.Drawing.Size(112, 35);
            this.button_delete_account.TabIndex = 3;
            this.button_delete_account.Text = "Delete";
            this.button_delete_account.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.dgAccounts);
            this.panel1.Location = new System.Drawing.Point(22, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(844, 486);
            this.panel1.TabIndex = 4;
            // 
            // Accounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 556);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_delete_account);
            this.Controls.Add(this.btn_update_account);
            this.Controls.Add(this.btn_new_account);
            this.Name = "Accounts";
            this.Text = "Accounts";
            ((System.ComponentModel.ISupportInitialize)(this.dgAccounts)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgAccounts;
        private System.Windows.Forms.Button btn_new_account;
        private System.Windows.Forms.Button btn_update_account;
        private System.Windows.Forms.Button button_delete_account;
        private System.Windows.Forms.Panel panel1;
    }
}