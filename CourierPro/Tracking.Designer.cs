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
            this.textBox_enter_package_no = new System.Windows.Forms.TextBox();
            this.button_trace_package = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_enter_package_no
            // 
            this.textBox_enter_package_no.Location = new System.Drawing.Point(271, 114);
            this.textBox_enter_package_no.Name = "textBox_enter_package_no";
            this.textBox_enter_package_no.Size = new System.Drawing.Size(100, 20);
            this.textBox_enter_package_no.TabIndex = 0;
            // 
            // button_trace_package
            // 
            this.button_trace_package.Location = new System.Drawing.Point(397, 111);
            this.button_trace_package.Name = "button_trace_package";
            this.button_trace_package.Size = new System.Drawing.Size(139, 23);
            this.button_trace_package.TabIndex = 1;
            this.button_trace_package.Text = "Track Package";
            this.button_trace_package.UseVisualStyleBackColor = true;
            this.button_trace_package.Click += new System.EventHandler(this.button_trace_package_Click);
            // 
            // Tracking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_trace_package);
            this.Controls.Add(this.textBox_enter_package_no);
            this.Name = "Tracking";
            this.Text = "Tracking";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_enter_package_no;
        private System.Windows.Forms.Button button_trace_package;
    }
}