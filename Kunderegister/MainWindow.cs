using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sysprog
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public Action<String, String, String, String, String> OnSavePrivateCustomer { get; set; }
        public Action<String, String, String, String> OnSaveBusinessCustomer { get; set; }
        public Action<String> OnDeleteCustomer { get; set; }
        public Func<ICollection<ListViewItem>> PopulateCustomerList { get; set; }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void Surname_Click(object sender, EventArgs e)
        {

        }

        private void button_DeleteCustomers_Click(object sender, EventArgs e)
        {

        }

        private void FirstName_Click(object sender, EventArgs e)
        {

        }

        private void Address_Click(object sender, EventArgs e)
        {

        }

        private void Phone_Click(object sender, EventArgs e)
        {

        }

        private void textBox_FirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Surname_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Address_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_PrivateSave_Click(object sender, EventArgs e)
        {
            OnSavePrivateCustomer?.Invoke(textBox_FirstName.Text, textBox_Surname.Text, textBox_Address.Text, textBox_Private_postcode.Text, textBox_Phone.Text);
        }

        private void BusinessName_Click(object sender, EventArgs e)
        {

        }

        private void BusinessAdress_Click(object sender, EventArgs e)
        {

        }

        private void BusinessPhone_Click(object sender, EventArgs e)
        {

        }

        private void textBox_BusinessName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_BusinessAdress_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_BusinessPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_BusinessSave_Click(object sender, EventArgs e)
        {
            OnSaveBusinessCustomer?.Invoke(textBox_BusinessName.Text, textBox_BusinessAdress.Text, textBox_Business_Postcode.Text, textBox_BusinessPhone.Text);
        }

        private void tabControl_ChooseTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((TabControl)sender).SelectedIndex == 1 && PopulateCustomerList != null)
            {
                listView_Customer.Items.Clear();
                listView_Customer.Items.AddRange(PopulateCustomerList().ToArray());
                listView_Customer.Update();
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView_Customer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox_Delete_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void postcode_Click(object sender, EventArgs e)
        {

        }

        private void textBox_Business_Postcode_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_private_postcode_TextChanged(object sender, EventArgs e)
        {

        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void button_DeleteCustomer_Click(object sender, EventArgs e)
        {
            OnDeleteCustomer?.Invoke(listView_Customer.FocusedItem.SubItems[0].Text);
            listView_Customer.FocusedItem.Remove();
        }
    }
}
