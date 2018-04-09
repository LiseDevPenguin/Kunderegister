namespace Kunderegister
{
    partial class MainWindow
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
            this.tabControl_ChooseTab = new System.Windows.Forms.TabControl();
            this.AddCustomers = new System.Windows.Forms.TabPage();
            this.tabControl_CustomerType = new System.Windows.Forms.TabControl();
            this.PrivateCustomer = new System.Windows.Forms.TabPage();
            this.button_PrivateSave = new System.Windows.Forms.Button();
            this.textBox_Phone = new System.Windows.Forms.TextBox();
            this.textBox_Address = new System.Windows.Forms.TextBox();
            this.textBox_Surname = new System.Windows.Forms.TextBox();
            this.textBox_FirstName = new System.Windows.Forms.TextBox();
            this.Phone = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.Label();
            this.Surname = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.Label();
            this.BusinessCustomer = new System.Windows.Forms.TabPage();
            this.button_BusinessSave = new System.Windows.Forms.Button();
            this.textBox_BusinessPhone = new System.Windows.Forms.TextBox();
            this.textBox_BusinessAdress = new System.Windows.Forms.TextBox();
            this.textBox_BusinessName = new System.Windows.Forms.TextBox();
            this.BusinessPhone = new System.Windows.Forms.Label();
            this.BusinessAdress = new System.Windows.Forms.Label();
            this.BusinessName = new System.Windows.Forms.Label();
            this.checkbox_delete = new System.Windows.Forms.TabPage();
            this.button_DeleteCustomers = new System.Windows.Forms.Button();
            this.ViewCustomers = new System.Windows.Forms.TabPage();
            this.listView_Customer = new System.Windows.Forms.ListView();
            this.checkedListBox_Delete = new System.Windows.Forms.CheckedListBox();
            this.tabControl_ChooseTab.SuspendLayout();
            this.AddCustomers.SuspendLayout();
            this.tabControl_CustomerType.SuspendLayout();
            this.PrivateCustomer.SuspendLayout();
            this.BusinessCustomer.SuspendLayout();
            this.checkbox_delete.SuspendLayout();
            this.ViewCustomers.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_ChooseTab
            // 
            this.tabControl_ChooseTab.Controls.Add(this.AddCustomers);
            this.tabControl_ChooseTab.Controls.Add(this.checkbox_delete);
            this.tabControl_ChooseTab.Controls.Add(this.ViewCustomers);
            this.tabControl_ChooseTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl_ChooseTab.Location = new System.Drawing.Point(0, 0);
            this.tabControl_ChooseTab.Name = "tabControl_ChooseTab";
            this.tabControl_ChooseTab.SelectedIndex = 0;
            this.tabControl_ChooseTab.Size = new System.Drawing.Size(1090, 535);
            this.tabControl_ChooseTab.TabIndex = 0;
            // 
            // AddCustomers
            // 
            this.AddCustomers.Controls.Add(this.tabControl_CustomerType);
            this.AddCustomers.Location = new System.Drawing.Point(4, 38);
            this.AddCustomers.Name = "AddCustomers";
            this.AddCustomers.Padding = new System.Windows.Forms.Padding(3);
            this.AddCustomers.Size = new System.Drawing.Size(1082, 493);
            this.AddCustomers.TabIndex = 0;
            this.AddCustomers.Text = "Add Customers";
            this.AddCustomers.UseVisualStyleBackColor = true;
            // 
            // tabControl_CustomerType
            // 
            this.tabControl_CustomerType.Controls.Add(this.PrivateCustomer);
            this.tabControl_CustomerType.Controls.Add(this.BusinessCustomer);
            this.tabControl_CustomerType.Location = new System.Drawing.Point(8, 6);
            this.tabControl_CustomerType.Name = "tabControl_CustomerType";
            this.tabControl_CustomerType.SelectedIndex = 0;
            this.tabControl_CustomerType.Size = new System.Drawing.Size(1074, 491);
            this.tabControl_CustomerType.TabIndex = 0;
            // 
            // PrivateCustomer
            // 
            this.PrivateCustomer.Controls.Add(this.button_PrivateSave);
            this.PrivateCustomer.Controls.Add(this.textBox_Phone);
            this.PrivateCustomer.Controls.Add(this.textBox_Address);
            this.PrivateCustomer.Controls.Add(this.textBox_Surname);
            this.PrivateCustomer.Controls.Add(this.textBox_FirstName);
            this.PrivateCustomer.Controls.Add(this.Phone);
            this.PrivateCustomer.Controls.Add(this.Address);
            this.PrivateCustomer.Controls.Add(this.Surname);
            this.PrivateCustomer.Controls.Add(this.FirstName);
            this.PrivateCustomer.Location = new System.Drawing.Point(4, 38);
            this.PrivateCustomer.Name = "PrivateCustomer";
            this.PrivateCustomer.Padding = new System.Windows.Forms.Padding(3);
            this.PrivateCustomer.Size = new System.Drawing.Size(1066, 449);
            this.PrivateCustomer.TabIndex = 0;
            this.PrivateCustomer.Text = "Private customer";
            this.PrivateCustomer.UseVisualStyleBackColor = true;
            // 
            // button_PrivateSave
            // 
            this.button_PrivateSave.BackColor = System.Drawing.Color.Green;
            this.button_PrivateSave.Location = new System.Drawing.Point(86, 266);
            this.button_PrivateSave.Name = "button_PrivateSave";
            this.button_PrivateSave.Size = new System.Drawing.Size(249, 58);
            this.button_PrivateSave.TabIndex = 9;
            this.button_PrivateSave.Text = "Save Customer";
            this.button_PrivateSave.UseVisualStyleBackColor = false;
            this.button_PrivateSave.Click += new System.EventHandler(this.button_PrivateSave_Click);
            // 
            // textBox_Phone
            // 
            this.textBox_Phone.Location = new System.Drawing.Point(153, 148);
            this.textBox_Phone.Name = "textBox_Phone";
            this.textBox_Phone.Size = new System.Drawing.Size(100, 34);
            this.textBox_Phone.TabIndex = 8;
            this.textBox_Phone.TextChanged += new System.EventHandler(this.textBox_Phone_TextChanged);
            // 
            // textBox_Address
            // 
            this.textBox_Address.Location = new System.Drawing.Point(153, 103);
            this.textBox_Address.Name = "textBox_Address";
            this.textBox_Address.Size = new System.Drawing.Size(100, 34);
            this.textBox_Address.TabIndex = 7;
            this.textBox_Address.TextChanged += new System.EventHandler(this.textBox_Address_TextChanged);
            // 
            // textBox_Surname
            // 
            this.textBox_Surname.Location = new System.Drawing.Point(153, 46);
            this.textBox_Surname.Name = "textBox_Surname";
            this.textBox_Surname.Size = new System.Drawing.Size(100, 34);
            this.textBox_Surname.TabIndex = 6;
            this.textBox_Surname.TextChanged += new System.EventHandler(this.textBox_Surname_TextChanged);
            // 
            // textBox_FirstName
            // 
            this.textBox_FirstName.Location = new System.Drawing.Point(153, 3);
            this.textBox_FirstName.Name = "textBox_FirstName";
            this.textBox_FirstName.Size = new System.Drawing.Size(100, 34);
            this.textBox_FirstName.TabIndex = 5;
            this.textBox_FirstName.TextChanged += new System.EventHandler(this.textBox_FirstName_TextChanged);
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Location = new System.Drawing.Point(3, 151);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(88, 29);
            this.Phone.TabIndex = 4;
            this.Phone.Text = "Phone";
            this.Phone.Click += new System.EventHandler(this.Phone_Click);
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Location = new System.Drawing.Point(3, 103);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(109, 29);
            this.Address.TabIndex = 3;
            this.Address.Text = "Address";
            this.Address.Click += new System.EventHandler(this.Address_Click);
            // 
            // Surname
            // 
            this.Surname.AutoSize = true;
            this.Surname.Location = new System.Drawing.Point(6, 46);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(117, 29);
            this.Surname.TabIndex = 2;
            this.Surname.Text = "Surname";
            this.Surname.Click += new System.EventHandler(this.Surname_Click);
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Location = new System.Drawing.Point(6, 3);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(136, 29);
            this.FirstName.TabIndex = 1;
            this.FirstName.Text = "First name";
            this.FirstName.Click += new System.EventHandler(this.FirstName_Click);
            // 
            // BusinessCustomer
            // 
            this.BusinessCustomer.Controls.Add(this.button_BusinessSave);
            this.BusinessCustomer.Controls.Add(this.textBox_BusinessPhone);
            this.BusinessCustomer.Controls.Add(this.textBox_BusinessAdress);
            this.BusinessCustomer.Controls.Add(this.textBox_BusinessName);
            this.BusinessCustomer.Controls.Add(this.BusinessPhone);
            this.BusinessCustomer.Controls.Add(this.BusinessAdress);
            this.BusinessCustomer.Controls.Add(this.BusinessName);
            this.BusinessCustomer.Location = new System.Drawing.Point(4, 38);
            this.BusinessCustomer.Name = "BusinessCustomer";
            this.BusinessCustomer.Padding = new System.Windows.Forms.Padding(3);
            this.BusinessCustomer.Size = new System.Drawing.Size(1066, 449);
            this.BusinessCustomer.TabIndex = 1;
            this.BusinessCustomer.Text = "Business customer";
            this.BusinessCustomer.UseVisualStyleBackColor = true;
            // 
            // button_BusinessSave
            // 
            this.button_BusinessSave.BackColor = System.Drawing.Color.ForestGreen;
            this.button_BusinessSave.Location = new System.Drawing.Point(60, 233);
            this.button_BusinessSave.Name = "button_BusinessSave";
            this.button_BusinessSave.Size = new System.Drawing.Size(265, 57);
            this.button_BusinessSave.TabIndex = 6;
            this.button_BusinessSave.Text = "Save Customer";
            this.button_BusinessSave.UseVisualStyleBackColor = false;
            this.button_BusinessSave.Click += new System.EventHandler(this.button_BusinessSave_Click);
            // 
            // textBox_BusinessPhone
            // 
            this.textBox_BusinessPhone.Location = new System.Drawing.Point(168, 113);
            this.textBox_BusinessPhone.Name = "textBox_BusinessPhone";
            this.textBox_BusinessPhone.Size = new System.Drawing.Size(100, 34);
            this.textBox_BusinessPhone.TabIndex = 5;
            this.textBox_BusinessPhone.TextChanged += new System.EventHandler(this.textBox_BusinessPhone_TextChanged);
            // 
            // textBox_BusinessAdress
            // 
            this.textBox_BusinessAdress.Location = new System.Drawing.Point(168, 57);
            this.textBox_BusinessAdress.Name = "textBox_BusinessAdress";
            this.textBox_BusinessAdress.Size = new System.Drawing.Size(100, 34);
            this.textBox_BusinessAdress.TabIndex = 4;
            this.textBox_BusinessAdress.TextChanged += new System.EventHandler(this.textBox_BusinessAdress_TextChanged);
            // 
            // textBox_BusinessName
            // 
            this.textBox_BusinessName.Location = new System.Drawing.Point(168, 9);
            this.textBox_BusinessName.Name = "textBox_BusinessName";
            this.textBox_BusinessName.Size = new System.Drawing.Size(100, 34);
            this.textBox_BusinessName.TabIndex = 3;
            this.textBox_BusinessName.TextChanged += new System.EventHandler(this.textBox_BusinessName_TextChanged);
            // 
            // BusinessPhone
            // 
            this.BusinessPhone.AutoSize = true;
            this.BusinessPhone.Location = new System.Drawing.Point(6, 113);
            this.BusinessPhone.Name = "BusinessPhone";
            this.BusinessPhone.Size = new System.Drawing.Size(88, 29);
            this.BusinessPhone.TabIndex = 2;
            this.BusinessPhone.Text = "Phone";
            this.BusinessPhone.Click += new System.EventHandler(this.BusinessPhone_Click);
            // 
            // BusinessAdress
            // 
            this.BusinessAdress.AutoSize = true;
            this.BusinessAdress.Location = new System.Drawing.Point(6, 60);
            this.BusinessAdress.Name = "BusinessAdress";
            this.BusinessAdress.Size = new System.Drawing.Size(109, 29);
            this.BusinessAdress.TabIndex = 1;
            this.BusinessAdress.Text = "Address";
            this.BusinessAdress.Click += new System.EventHandler(this.BusinessAdress_Click);
            // 
            // BusinessName
            // 
            this.BusinessName.AutoSize = true;
            this.BusinessName.Location = new System.Drawing.Point(6, 14);
            this.BusinessName.Name = "BusinessName";
            this.BusinessName.Size = new System.Drawing.Size(82, 29);
            this.BusinessName.TabIndex = 0;
            this.BusinessName.Text = "Name";
            this.BusinessName.Click += new System.EventHandler(this.BusinessName_Click);
            // 
            // checkbox_delete
            // 
            this.checkbox_delete.Controls.Add(this.checkedListBox_Delete);
            this.checkbox_delete.Controls.Add(this.button_DeleteCustomers);
            this.checkbox_delete.Location = new System.Drawing.Point(4, 38);
            this.checkbox_delete.Name = "checkbox_delete";
            this.checkbox_delete.Padding = new System.Windows.Forms.Padding(3);
            this.checkbox_delete.Size = new System.Drawing.Size(1082, 493);
            this.checkbox_delete.TabIndex = 1;
            this.checkbox_delete.Text = "Delete Customers";
            this.checkbox_delete.UseVisualStyleBackColor = true;
            // 
            // button_DeleteCustomers
            // 
            this.button_DeleteCustomers.BackColor = System.Drawing.Color.Green;
            this.button_DeleteCustomers.Location = new System.Drawing.Point(33, 361);
            this.button_DeleteCustomers.Name = "button_DeleteCustomers";
            this.button_DeleteCustomers.Size = new System.Drawing.Size(253, 58);
            this.button_DeleteCustomers.TabIndex = 1;
            this.button_DeleteCustomers.Text = "Delete Selected";
            this.button_DeleteCustomers.UseVisualStyleBackColor = false;
            this.button_DeleteCustomers.Click += new System.EventHandler(this.button_DeleteCustomers_Click);
            // 
            // ViewCustomers
            // 
            this.ViewCustomers.Controls.Add(this.listView_Customer);
            this.ViewCustomers.Location = new System.Drawing.Point(4, 38);
            this.ViewCustomers.Name = "ViewCustomers";
            this.ViewCustomers.Size = new System.Drawing.Size(1082, 493);
            this.ViewCustomers.TabIndex = 2;
            this.ViewCustomers.Text = "View Customers";
            this.ViewCustomers.UseVisualStyleBackColor = true;
            // 
            // listView_Customer
            // 
            this.listView_Customer.Location = new System.Drawing.Point(8, 3);
            this.listView_Customer.Name = "listView_Customer";
            this.listView_Customer.Size = new System.Drawing.Size(489, 384);
            this.listView_Customer.TabIndex = 0;
            this.listView_Customer.UseCompatibleStateImageBehavior = false;
            this.listView_Customer.SelectedIndexChanged += new System.EventHandler(this.listView_Customer_SelectedIndexChanged);
            // 
            // checkedListBox_Delete
            // 
            this.checkedListBox_Delete.FormattingEnabled = true;
            this.checkedListBox_Delete.Location = new System.Drawing.Point(21, 15);
            this.checkedListBox_Delete.Name = "checkedListBox_Delete";
            this.checkedListBox_Delete.Size = new System.Drawing.Size(305, 265);
            this.checkedListBox_Delete.TabIndex = 2;
            this.checkedListBox_Delete.SelectedIndexChanged += new System.EventHandler(this.checkedListBox_Delete_SelectedIndexChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1086, 532);
            this.Controls.Add(this.tabControl_ChooseTab);
            this.Name = "MainWindow";
            this.Text = "Customer Registration";
            this.tabControl_ChooseTab.ResumeLayout(false);
            this.AddCustomers.ResumeLayout(false);
            this.tabControl_CustomerType.ResumeLayout(false);
            this.PrivateCustomer.ResumeLayout(false);
            this.PrivateCustomer.PerformLayout();
            this.BusinessCustomer.ResumeLayout(false);
            this.BusinessCustomer.PerformLayout();
            this.checkbox_delete.ResumeLayout(false);
            this.ViewCustomers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_ChooseTab;
        private System.Windows.Forms.TabPage AddCustomers;
        private System.Windows.Forms.TabPage checkbox_delete;
        private System.Windows.Forms.TabPage ViewCustomers;
        private System.Windows.Forms.TabControl tabControl_CustomerType;
        private System.Windows.Forms.TabPage PrivateCustomer;
        private System.Windows.Forms.TabPage BusinessCustomer;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Label Surname;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.TextBox textBox_Phone;
        private System.Windows.Forms.TextBox textBox_Address;
        private System.Windows.Forms.TextBox textBox_Surname;
        private System.Windows.Forms.TextBox textBox_FirstName;
        private System.Windows.Forms.TextBox textBox_BusinessPhone;
        private System.Windows.Forms.TextBox textBox_BusinessAdress;
        private System.Windows.Forms.TextBox textBox_BusinessName;
        private System.Windows.Forms.Label BusinessPhone;
        private System.Windows.Forms.Label BusinessAdress;
        private System.Windows.Forms.Label BusinessName;
        private System.Windows.Forms.Button button_PrivateSave;
        private System.Windows.Forms.Button button_BusinessSave;
        private System.Windows.Forms.Button button_DeleteCustomers;
        private System.Windows.Forms.ListView listView_Customer;
        private System.Windows.Forms.CheckedListBox checkedListBox_Delete;
    }
}

