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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.ViewCustomers = new System.Windows.Forms.TabPage();
            this.listView_CustomerGeneral = new System.Windows.Forms.ListView();
            this.AddCustomers = new System.Windows.Forms.TabPage();
            this.tabControl_CustomerType = new System.Windows.Forms.TabControl();
            this.BusinessCustomer = new System.Windows.Forms.TabPage();
            this.BusinessName = new System.Windows.Forms.Label();
            this.BusinessAdress = new System.Windows.Forms.Label();
            this.BusinessPhone = new System.Windows.Forms.Label();
            this.textBox_BusinessName = new System.Windows.Forms.TextBox();
            this.textBox_BusinessAdress = new System.Windows.Forms.TextBox();
            this.textBox_BusinessPhone = new System.Windows.Forms.TextBox();
            this.button_BusinessSave = new System.Windows.Forms.Button();
            this.Business_postcode = new System.Windows.Forms.Label();
            this.textBox_Business_Postcode = new System.Windows.Forms.TextBox();
            this.PrivateCustomer = new System.Windows.Forms.TabPage();
            this.FirstName = new System.Windows.Forms.Label();
            this.Surname = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.Label();
            this.textBox_FirstName = new System.Windows.Forms.TextBox();
            this.textBox_Surname = new System.Windows.Forms.TextBox();
            this.textBox_Private_Address = new System.Windows.Forms.TextBox();
            this.textBox_Private_Phone = new System.Windows.Forms.TextBox();
            this.button_PrivateSave = new System.Windows.Forms.Button();
            this.label_postCode = new System.Windows.Forms.Label();
            this.textBox_Private_postcode = new System.Windows.Forms.TextBox();
            this.tabControl_ChooseTab = new System.Windows.Forms.TabControl();
            this.button_DeleteCustomer = new System.Windows.Forms.Button();
            this.listView_CustomerDetail = new System.Windows.Forms.ListView();
            this.ViewCustomers.SuspendLayout();
            this.AddCustomers.SuspendLayout();
            this.tabControl_CustomerType.SuspendLayout();
            this.BusinessCustomer.SuspendLayout();
            this.PrivateCustomer.SuspendLayout();
            this.tabControl_ChooseTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // ViewCustomers
            // 
            this.ViewCustomers.BackColor = System.Drawing.Color.LightBlue;
            this.ViewCustomers.Controls.Add(this.listView_CustomerDetail);
            this.ViewCustomers.Controls.Add(this.button_DeleteCustomer);
            this.ViewCustomers.Controls.Add(this.listView_CustomerGeneral);
            this.ViewCustomers.Location = new System.Drawing.Point(4, 38);
            this.ViewCustomers.Name = "ViewCustomers";
            this.ViewCustomers.Size = new System.Drawing.Size(1082, 493);
            this.ViewCustomers.TabIndex = 2;
            this.ViewCustomers.Text = "View Customers";
            // 
            // listView_CustomerGeneral
            // 
            this.listView_CustomerGeneral.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.listView_CustomerGeneral.Location = new System.Drawing.Point(8, 3);
            this.listView_CustomerGeneral.Name = "listView_CustomerGeneral";
            this.listView_CustomerGeneral.Size = new System.Drawing.Size(406, 375);
            this.listView_CustomerGeneral.TabIndex = 0;
            this.listView_CustomerGeneral.UseCompatibleStateImageBehavior = false;
            this.listView_CustomerGeneral.SelectedIndexChanged += new System.EventHandler(this.listView_Customer_SelectedIndexChanged);
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
            // BusinessCustomer
            // 
            this.BusinessCustomer.BackColor = System.Drawing.Color.LightBlue;
            this.BusinessCustomer.Controls.Add(this.textBox_Business_Postcode);
            this.BusinessCustomer.Controls.Add(this.Business_postcode);
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
            // BusinessPhone
            // 
            this.BusinessPhone.AutoSize = true;
            this.BusinessPhone.Location = new System.Drawing.Point(6, 167);
            this.BusinessPhone.Name = "BusinessPhone";
            this.BusinessPhone.Size = new System.Drawing.Size(88, 29);
            this.BusinessPhone.TabIndex = 2;
            this.BusinessPhone.Text = "Phone";
            this.BusinessPhone.Click += new System.EventHandler(this.BusinessPhone_Click);
            // 
            // textBox_BusinessName
            // 
            this.textBox_BusinessName.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox_BusinessName.Location = new System.Drawing.Point(168, 9);
            this.textBox_BusinessName.Name = "textBox_BusinessName";
            this.textBox_BusinessName.Size = new System.Drawing.Size(100, 34);
            this.textBox_BusinessName.TabIndex = 3;
            this.textBox_BusinessName.TextChanged += new System.EventHandler(this.textBox_BusinessName_TextChanged);
            // 
            // textBox_BusinessAdress
            // 
            this.textBox_BusinessAdress.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox_BusinessAdress.Location = new System.Drawing.Point(168, 60);
            this.textBox_BusinessAdress.Name = "textBox_BusinessAdress";
            this.textBox_BusinessAdress.Size = new System.Drawing.Size(100, 34);
            this.textBox_BusinessAdress.TabIndex = 4;
            this.textBox_BusinessAdress.TextChanged += new System.EventHandler(this.textBox_BusinessAdress_TextChanged);
            // 
            // textBox_BusinessPhone
            // 
            this.textBox_BusinessPhone.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox_BusinessPhone.Location = new System.Drawing.Point(168, 162);
            this.textBox_BusinessPhone.Name = "textBox_BusinessPhone";
            this.textBox_BusinessPhone.Size = new System.Drawing.Size(100, 34);
            this.textBox_BusinessPhone.TabIndex = 5;
            this.textBox_BusinessPhone.TextChanged += new System.EventHandler(this.textBox_BusinessPhone_TextChanged);
            // 
            // button_BusinessSave
            // 
            this.button_BusinessSave.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_BusinessSave.Location = new System.Drawing.Point(69, 273);
            this.button_BusinessSave.Name = "button_BusinessSave";
            this.button_BusinessSave.Size = new System.Drawing.Size(265, 57);
            this.button_BusinessSave.TabIndex = 6;
            this.button_BusinessSave.Text = "Save Customer";
            this.button_BusinessSave.UseVisualStyleBackColor = false;
            this.button_BusinessSave.Click += new System.EventHandler(this.button_BusinessSave_Click);
            // 
            // Business_postcode
            // 
            this.Business_postcode.AutoSize = true;
            this.Business_postcode.Location = new System.Drawing.Point(3, 110);
            this.Business_postcode.Name = "Business_postcode";
            this.Business_postcode.Size = new System.Drawing.Size(123, 29);
            this.Business_postcode.TabIndex = 7;
            this.Business_postcode.Text = "Postcode";
            this.Business_postcode.Click += new System.EventHandler(this.postcode_Click);
            // 
            // textBox_Business_Postcode
            // 
            this.textBox_Business_Postcode.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox_Business_Postcode.Location = new System.Drawing.Point(168, 110);
            this.textBox_Business_Postcode.Name = "textBox_Business_Postcode";
            this.textBox_Business_Postcode.Size = new System.Drawing.Size(100, 34);
            this.textBox_Business_Postcode.TabIndex = 8;
            this.textBox_Business_Postcode.TextChanged += new System.EventHandler(this.textBox_Business_Postcode_TextChanged);
            // 
            // PrivateCustomer
            // 
            this.PrivateCustomer.BackColor = System.Drawing.Color.LightBlue;
            this.PrivateCustomer.Controls.Add(this.textBox_Private_postcode);
            this.PrivateCustomer.Controls.Add(this.label_postCode);
            this.PrivateCustomer.Controls.Add(this.button_PrivateSave);
            this.PrivateCustomer.Controls.Add(this.textBox_Private_Phone);
            this.PrivateCustomer.Controls.Add(this.textBox_Private_Address);
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
            // Surname
            // 
            this.Surname.AutoSize = true;
            this.Surname.Location = new System.Drawing.Point(3, 51);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(117, 29);
            this.Surname.TabIndex = 2;
            this.Surname.Text = "Surname";
            this.Surname.Click += new System.EventHandler(this.Surname_Click);
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
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Location = new System.Drawing.Point(6, 216);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(88, 29);
            this.Phone.TabIndex = 4;
            this.Phone.Text = "Phone";
            this.Phone.Click += new System.EventHandler(this.Phone_Click);
            // 
            // textBox_FirstName
            // 
            this.textBox_FirstName.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox_FirstName.Location = new System.Drawing.Point(153, 3);
            this.textBox_FirstName.Name = "textBox_FirstName";
            this.textBox_FirstName.Size = new System.Drawing.Size(100, 34);
            this.textBox_FirstName.TabIndex = 5;
            this.textBox_FirstName.TextChanged += new System.EventHandler(this.textBox_FirstName_TextChanged);
            // 
            // textBox_Surname
            // 
            this.textBox_Surname.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox_Surname.Location = new System.Drawing.Point(153, 51);
            this.textBox_Surname.Name = "textBox_Surname";
            this.textBox_Surname.Size = new System.Drawing.Size(100, 34);
            this.textBox_Surname.TabIndex = 6;
            this.textBox_Surname.TextChanged += new System.EventHandler(this.textBox_Surname_TextChanged);
            // 
            // textBox_Private_Address
            // 
            this.textBox_Private_Address.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox_Private_Address.Location = new System.Drawing.Point(153, 103);
            this.textBox_Private_Address.Name = "textBox_Private_Address";
            this.textBox_Private_Address.Size = new System.Drawing.Size(100, 34);
            this.textBox_Private_Address.TabIndex = 7;
            this.textBox_Private_Address.TextChanged += new System.EventHandler(this.textBox_Address_TextChanged);
            // 
            // textBox_Private_Phone
            // 
            this.textBox_Private_Phone.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox_Private_Phone.Location = new System.Drawing.Point(153, 211);
            this.textBox_Private_Phone.Name = "textBox_Private_Phone";
            this.textBox_Private_Phone.Size = new System.Drawing.Size(100, 34);
            this.textBox_Private_Phone.TabIndex = 8;
            this.textBox_Private_Phone.TextChanged += new System.EventHandler(this.textBox_Phone_TextChanged);
            // 
            // button_PrivateSave
            // 
            this.button_PrivateSave.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_PrivateSave.Location = new System.Drawing.Point(84, 295);
            this.button_PrivateSave.Name = "button_PrivateSave";
            this.button_PrivateSave.Size = new System.Drawing.Size(249, 58);
            this.button_PrivateSave.TabIndex = 9;
            this.button_PrivateSave.Text = "Save Customer";
            this.button_PrivateSave.UseVisualStyleBackColor = false;
            this.button_PrivateSave.Click += new System.EventHandler(this.button_PrivateSave_Click);
            // 
            // label_postCode
            // 
            this.label_postCode.AutoSize = true;
            this.label_postCode.Location = new System.Drawing.Point(3, 158);
            this.label_postCode.Name = "label_postCode";
            this.label_postCode.Size = new System.Drawing.Size(123, 29);
            this.label_postCode.TabIndex = 10;
            this.label_postCode.Text = "Postcode";
            // 
            // textBox_Private_postcode
            // 
            this.textBox_Private_postcode.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox_Private_postcode.Location = new System.Drawing.Point(153, 155);
            this.textBox_Private_postcode.Name = "textBox_Private_postcode";
            this.textBox_Private_postcode.Size = new System.Drawing.Size(100, 34);
            this.textBox_Private_postcode.TabIndex = 11;
            this.textBox_Private_postcode.TextChanged += new System.EventHandler(this.textBox_private_postcode_TextChanged);
            // 
            // tabControl_ChooseTab
            // 
            this.tabControl_ChooseTab.Controls.Add(this.AddCustomers);
            this.tabControl_ChooseTab.Controls.Add(this.ViewCustomers);
            this.tabControl_ChooseTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl_ChooseTab.Location = new System.Drawing.Point(0, 0);
            this.tabControl_ChooseTab.Name = "tabControl_ChooseTab";
            this.tabControl_ChooseTab.SelectedIndex = 0;
            this.tabControl_ChooseTab.Size = new System.Drawing.Size(1090, 535);
            this.tabControl_ChooseTab.TabIndex = 0;
            // 
            // button_DeleteCustomer
            // 
            this.button_DeleteCustomer.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_DeleteCustomer.Location = new System.Drawing.Point(74, 425);
            this.button_DeleteCustomer.Name = "button_DeleteCustomer";
            this.button_DeleteCustomer.Size = new System.Drawing.Size(211, 43);
            this.button_DeleteCustomer.TabIndex = 1;
            this.button_DeleteCustomer.Text = "Delete customer";
            this.button_DeleteCustomer.UseVisualStyleBackColor = false;
            // 
            // listView_CustomerDetail
            // 
            this.listView_CustomerDetail.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.listView_CustomerDetail.Location = new System.Drawing.Point(516, 3);
            this.listView_CustomerDetail.Name = "listView_CustomerDetail";
            this.listView_CustomerDetail.Size = new System.Drawing.Size(384, 375);
            this.listView_CustomerDetail.TabIndex = 2;
            this.listView_CustomerDetail.UseCompatibleStateImageBehavior = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(1086, 532);
            this.Controls.Add(this.tabControl_ChooseTab);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Registration";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ViewCustomers.ResumeLayout(false);
            this.AddCustomers.ResumeLayout(false);
            this.tabControl_CustomerType.ResumeLayout(false);
            this.BusinessCustomer.ResumeLayout(false);
            this.BusinessCustomer.PerformLayout();
            this.PrivateCustomer.ResumeLayout(false);
            this.PrivateCustomer.PerformLayout();
            this.tabControl_ChooseTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage ViewCustomers;
        private System.Windows.Forms.Button button_DeleteCustomer;
        private System.Windows.Forms.ListView listView_CustomerGeneral;
        private System.Windows.Forms.TabPage AddCustomers;
        private System.Windows.Forms.TabControl tabControl_CustomerType;
        private System.Windows.Forms.TabPage PrivateCustomer;
        private System.Windows.Forms.TextBox textBox_Private_postcode;
        private System.Windows.Forms.Label label_postCode;
        private System.Windows.Forms.Button button_PrivateSave;
        private System.Windows.Forms.TextBox textBox_Private_Phone;
        private System.Windows.Forms.TextBox textBox_Private_Address;
        private System.Windows.Forms.TextBox textBox_Surname;
        private System.Windows.Forms.TextBox textBox_FirstName;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Label Surname;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.TabPage BusinessCustomer;
        private System.Windows.Forms.TextBox textBox_Business_Postcode;
        private System.Windows.Forms.Label Business_postcode;
        private System.Windows.Forms.Button button_BusinessSave;
        private System.Windows.Forms.TextBox textBox_BusinessPhone;
        private System.Windows.Forms.TextBox textBox_BusinessAdress;
        private System.Windows.Forms.TextBox textBox_BusinessName;
        private System.Windows.Forms.Label BusinessPhone;
        private System.Windows.Forms.Label BusinessAdress;
        private System.Windows.Forms.Label BusinessName;
        private System.Windows.Forms.TabControl tabControl_ChooseTab;
        private System.Windows.Forms.ListView listView_CustomerDetail;
    }
}

