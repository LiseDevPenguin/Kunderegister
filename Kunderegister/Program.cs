using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sysprog
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            const String filename = "CustomerStorage.bin";
            Storage<CustomerRegister> storage = new Storage<CustomerRegister>(filename);
            CustomerRegister customerRegister = storage.Load() ?? new CustomerRegister();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainWindow mainWindow = new MainWindow();
            mainWindow.OnSavePrivateCustomer = (String firstName, String surname, String address, String postcode, String phone) => 
            {
                customerRegister.Add(new PrivateCustomer(firstName, surname, address, postcode, phone));
                mainWindow.ClearPrivateCustomerFields();
            };
            mainWindow.OnSaveBusinessCustomer = (String name, String address, String postCode, String phone) =>
            {
                customerRegister.Add(new BusinessCustomer(name, address, postCode, phone));
                mainWindow.ClearBusinessCustomerFields();
            };
            mainWindow.PopulateCustomerList = () => 
            {
                IList<ListViewItem> items = new List<ListViewItem>();
                foreach (Customer c in customerRegister.Customers)
                {
                    String type = "";
                    if (c is PrivateCustomer)
                        type = "Private";
                    else if (c is BusinessCustomer)
                        type = "Business";  

                    String[] row = { c.ID, c.Name, c.Address, c.PostCode, c.PhoneNumber, type };
                    items.Add(new ListViewItem(row));
                }
                return items;
            };
            mainWindow.OnDeleteCustomer = (String ID) =>
            {
                customerRegister.Remove(ID);
            };

            Application.Run(mainWindow);

            storage.Save(customerRegister);
        }
    }
}
