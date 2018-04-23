using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kunderegister
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            const String filename = "test.bin";
            Storage<CustomerRegister> storage = new Storage<CustomerRegister>(filename);
            CustomerRegister customerRegister = storage.Load() ?? new CustomerRegister();

            Contact test = new Contact("Ole", "Olsen", "123");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainWindow mainWindow = new MainWindow();
            mainWindow.OnSavePrivateCustomer = (String firstName, String surname, String address, String postcode, String phone) => 
            {
                customerRegister.Add(new PrivateCustomer(firstName, surname, address, postcode, phone));
            };
            mainWindow.OnSaveBusinessCustomer = (String name, String address, String postCode, String phone) =>
            {
                customerRegister.Add(new BusinessCustomer(name, address, postCode, phone, test));
            };
            mainWindow.PopulateCustomerList = () => 
            {
                IList<ListViewItem> items = new List<ListViewItem>();
                foreach (Customer c in customerRegister.Customers)
                {
                    String[] row = { c.Name, c.Address, c.PostCode, c.PhoneNumber };
                    items.Add(new ListViewItem(row));
                }
                return items;
            };

            Application.Run(mainWindow);

            storage.Save(customerRegister);
        }
    }
}
