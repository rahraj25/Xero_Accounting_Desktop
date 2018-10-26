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
            ((System.ComponentModel.ISupportInitialize)(this.dgAccounts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgAccounts
            // 
            this.dgAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAccounts.Location = new System.Drawing.Point(40, 27);
            this.dgAccounts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgAccounts.Name = "dgAccounts";
            this.dgAccounts.RowTemplate.Height = 28;
            this.dgAccounts.Size = new System.Drawing.Size(332, 266);
            this.dgAccounts.TabIndex = 0;
            // 
            // btn_new_account
            // 
            this.btn_new_account.Location = new System.Drawing.Point(40, 331);
            this.btn_new_account.Name = "btn_new_account";
            this.btn_new_account.Size = new System.Drawing.Size(75, 23);
            this.btn_new_account.TabIndex = 1;
            this.btn_new_account.Text = "New";
            this.btn_new_account.UseVisualStyleBackColor = true;
            this.btn_new_account.Click += new System.EventHandler(this.btn_new_account_Click);
            // 
            // btn_update_account
            // 
            this.btn_update_account.Location = new System.Drawing.Point(165, 330);
            this.btn_update_account.Name = "btn_update_account";
            this.btn_update_account.Size = new System.Drawing.Size(75, 23);
            this.btn_update_account.TabIndex = 2;
            this.btn_update_account.Text = "Update";
            this.btn_update_account.UseVisualStyleBackColor = true;
            // 
            // button_delete_account
            // 
            this.button_delete_account.Location = new System.Drawing.Point(297, 329);
            this.button_delete_account.Name = "button_delete_account";
            this.button_delete_account.Size = new System.Drawing.Size(75, 23);
            this.button_delete_account.TabIndex = 3;
            this.button_delete_account.Text = "Delete";
            this.button_delete_account.UseVisualStyleBackColor = true;
            // 
            // Accounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 389);
            this.Controls.Add(this.button_delete_account);
            this.Controls.Add(this.btn_update_account);
            this.Controls.Add(this.btn_new_account);
            this.Controls.Add(this.dgAccounts);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Accounts";
            this.Text = "Accounts";
            ((System.ComponentModel.ISupportInitialize)(this.dgAccounts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgAccounts;
        private System.Windows.Forms.Button btn_new_account;
        private System.Windows.Forms.Button btn_update_account;
        private System.Windows.Forms.Button button_delete_account;
    }
}