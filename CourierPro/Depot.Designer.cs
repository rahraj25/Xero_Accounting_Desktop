namespace CourierPro
{
    partial class Depot
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
            this.dgDepots = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgDepots)).BeginInit();
            this.SuspendLayout();
            // 
            // dgDepots
            // 
            this.dgDepots.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDepots.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDepots.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgDepots.Location = new System.Drawing.Point(37, 38);
            this.dgDepots.Name = "dgDepots";
            this.dgDepots.ReadOnly = true;
            this.dgDepots.RowTemplate.Height = 28;
            this.dgDepots.Size = new System.Drawing.Size(959, 412);
            this.dgDepots.TabIndex = 3;
            this.dgDepots.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDepots_CellContentClick);
            this.dgDepots.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDepots_CellValueChanged);
            this.dgDepots.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgDepots_RowsAdded);
            this.dgDepots.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgDepots_UserAddedRow);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(37, 476);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(103, 42);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Depot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 540);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgDepots);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Depot";
            this.Text = "Depot";
            ((System.ComponentModel.ISupportInitialize)(this.dgDepots)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgDepots;
        private System.Windows.Forms.Button btnAdd;
    }
}