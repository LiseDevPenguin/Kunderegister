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

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainWindow mainWindow = new MainWindow();
            mainWindow.OnSavePrivateCustomer = (String firstName, String surname, String address, String postcode, String phone) => 
            {
                customerRegister.Add(new PrivateCustomer(firstName, surname, address, postcode, phone));
            };
            Application.Run(mainWindow);

            storage.Save(customerRegister);
        }
    }
}
