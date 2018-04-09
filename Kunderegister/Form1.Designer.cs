namespace Kunderegister
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.AddCustomers = new System.Windows.Forms.TabPage();
            this.DeleteCustomers = new System.Windows.Forms.TabPage();
            this.ViewCustomers = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.AddCustomers);
            this.tabControl1.Controls.Add(this.DeleteCustomers);
            this.tabControl1.Controls.Add(this.ViewCustomers);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1090, 535);
            this.tabControl1.TabIndex = 0;
            // 
            // AddCustomers
            // 
            this.AddCustomers.Location = new System.Drawing.Point(4, 25);
            this.AddCustomers.Name = "AddCustomers";
            this.AddCustomers.Padding = new System.Windows.Forms.Padding(3);
            this.AddCustomers.Size = new System.Drawing.Size(1082, 506);
            this.AddCustomers.TabIndex = 0;
            this.AddCustomers.Text = "Add Customers";
            this.AddCustomers.UseVisualStyleBackColor = true;
            // 
            // DeleteCustomers
            // 
            this.DeleteCustomers.Location = new System.Drawing.Point(4, 25);
            this.DeleteCustomers.Name = "DeleteCustomers";
            this.DeleteCustomers.Padding = new System.Windows.Forms.Padding(3);
            this.DeleteCustomers.Size = new System.Drawing.Size(1082, 506);
            this.DeleteCustomers.TabIndex = 1;
            this.DeleteCustomers.Text = "Delete Customers";
            this.DeleteCustomers.UseVisualStyleBackColor = true;
            // 
            // ViewCustomers
            // 
            this.ViewCustomers.Location = new System.Drawing.Point(4, 25);
            this.ViewCustomers.Name = "ViewCustomers";
            this.ViewCustomers.Size = new System.Drawing.Size(1082, 506);
            this.ViewCustomers.TabIndex = 2;
            this.ViewCustomers.Text = "View Customers";
            this.ViewCustomers.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 532);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage AddCustomers;
        private System.Windows.Forms.TabPage DeleteCustomers;
        private System.Windows.Forms.TabPage ViewCustomers;
    }
}

