namespace CourierPro
{
    partial class Tracking
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtPackageNo = new System.Windows.Forms.RichTextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(485, 62);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(208, 35);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Track Package";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.button_trace_package_Click);
            // 
            // txtPackageNo
            // 
            this.txtPackageNo.Location = new System.Drawing.Point(53, 62);
            this.txtPackageNo.Name = "txtPackageNo";
            this.txtPackageNo.Size = new System.Drawing.Size(401, 35);
            this.txtPackageNo.TabIndex = 2;
            this.txtPackageNo.Text = "";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.DarkRed;
            this.lblError.Location = new System.Drawing.Point(49, 138);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(57, 20);
            this.lblError.TabIndex = 9;
            this.lblError.Text = "label4";
            this.lblError.Visible = false;
            // 
            // Tracking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 187);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.txtPackageNo);
            this.Controls.Add(this.btnSearch);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Tracking";
            this.Text = "Tracking";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.RichTextBox txtPackageNo;
        private System.Windows.Forms.Label lblError;
    }
}